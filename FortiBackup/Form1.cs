using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;
using FortiBackup.Objeler;
using System.Threading;
using System.Globalization;
using System.Resources;

namespace FortiBackup
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static  ResourceManager res_man;
        public static CultureInfo cul;
        public Form1()
        {
            InitializeComponent();

            ListViewExtender extender = new ListViewExtender(listCihazlar);
            //ListViewExtender extenderSil = new ListViewExtender(listCihazlar);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(8);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            ListViewButtonColumn btnSil = new ListViewButtonColumn(9);
            btnSil.Click += SilClick;
            btnSil.FixedWidth = true;

            extender.AddColumn(buttonAction);
            extender.AddColumn(btnSil);
            res_man = new ResourceManager("FortiBackup.Resources.Res", typeof(Form1).Assembly);
            cul = CultureInfo.CreateSpecificCulture("en-GB");

            switch_Language(cul);
        }

        private void switch_Language(CultureInfo cul)
        {
            lblCihazAdres.Text = res_man.GetString("txtIP", cul);
            lblCihazIsmi.Text= res_man.GetString("txtCihazAdi", cul);
            lblPassword.Text= res_man.GetString("txtPassword", cul);
            lblSSHPort.Text= res_man.GetString("txtSSHPort", cul);
            lblUsername.Text= res_man.GetString("txtUsername", cul);
            btnBaglan.Text= res_man.GetString("btnBaglan", cul);
            btnCihazKayit.Text= res_man.GetString("btnCihazKayit", cul);
            btnHepsiniYedekle.Text= res_man.GetString("btnHepsiniYedekle", cul);
            this.Isim.Text = res_man.GetString("isim", cul);
            this.IP.Text = res_man.GetString("ip", cul);
            this.Port.Text = res_man.GetString("txtSSHPort", cul);
            this.Username.Text = res_man.GetString("txtUsername", cul);
            this.Password.Text = res_man.GetString("txtPassword", cul);
            this.Tip.Text = res_man.GetString("tip", cul);
            groupBox1.Text= res_man.GetString("grpYeniCihaz", cul);
            ListeyiGuncelle();
        }

        private void SilClick(object sender, ListViewColumnMouseEventArgs e)
        {
            CihazList clist = islemler.GetAllCihazlar();
            var item = listCihazlar.SelectedItems[0];

            var cihaz = clist.cihazlar.Where(c => c.ID.ToString().Equals(e.Item.SubItems[0].Text)).FirstOrDefault();
            if (cihaz != null)
            {
                DialogResult myResult;
                myResult = MessageBox.Show(res_man.GetString("txtSilinsinmi", cul), res_man.GetString("txtSil", cul), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    islemler islem = new islemler();
                    Result r = islem.CihazS(cihaz);
                    if (r.success)
                    {
                        MessageBox.Show(r.mesaj);
                        ListeyiGuncelle();
                    }
                    else
                    {
                        MessageBox.Show(r.mesaj);
                    }
                }
            }
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {

            CihazList clist = islemler.GetAllCihazlar();

            var cihaz = clist.cihazlar.Where(c => c.ID.ToString().Equals(e.Item.SubItems[0].Text)).FirstOrDefault();
            if (cihaz != null)
            {
                frmDuzenle UForm = IsFormAlreadyOpen(typeof(frmDuzenle));
                if (UForm == null)
                {
                    UForm = new frmDuzenle();
                    UForm.cihaz = cihaz;
                    UForm.cihazGetir();
                    UForm.anaForm = this;
                    UForm.Show();
                }
                else
                {
                    UForm.cihaz = cihaz;
                    UForm.cihazGetir();
                    UForm.anaForm = this;
                    UForm.Show();
                    UForm.Focus();
                    UForm.WindowState = FormWindowState.Normal;
                }
            }


        }

        private frmDuzenle IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return (frmDuzenle)OpenForm;
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islemler.DbKontrol();
            ListeyiGuncelle();
        }


        private void btnCihazKayit_Click(object sender, EventArgs e)
        {
            string isim = txtCihazAdi.Text;
            string adres = txtIP.Text;
            string port = txtSSHPort.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrEmpty(isim) || String.IsNullOrEmpty(adres) || String.IsNullOrEmpty(port) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || port=="0")
            {
                MessageBox.Show(res_man.GetString("txtTumAlanlarDoldur", cul));
            }else
            {
                Cihazlar cihaz = new Cihazlar();
                cihaz.CihazAdi = isim;
                cihaz.Adres = adres;
                cihaz.Port = Convert.ToInt32(port);
                cihaz.Username = username;
                cihaz.Password = password;
                cihaz.Tip = (rndFortigate.Checked) ? Turu.Fortigate : Turu.Fortimail;
                islemler islem = new islemler();
                Result r = islem.CihazK(cihaz);
                if (r.success)
                {
                    MessageBox.Show(res_man.GetString("txtKayitBasarili", cul));
                    AlanlariTazele();
                    ListeyiGuncelle();
                }else
                {
                    MessageBox.Show(r.mesaj);
                }

            }
        }

        public void ListeyiGuncelle()
        {
            listCihazlar.Items.Clear();
            CihazList clist = islemler.GetAllCihazlar();
            if (clist.cihazlar.Count > 0)
            {
                foreach (Cihazlar c in clist.cihazlar)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = c.ID.ToString();
                    item.SubItems.Add(c.CihazAdi);
                    item.SubItems.Add(c.Adres);
                    item.SubItems.Add(c.Port.ToString());
                    item.SubItems.Add(c.Username);
                    item.SubItems.Add("********");
                    item.SubItems.Add(c.Tip.ToString());
                    item.SubItems.Add("");
                    item.SubItems.Add(res_man.GetString("btnCihazDuzenle", cul));
                    item.SubItems.Add(res_man.GetString("txtSil", cul));
                    item.Tag = c.Password;
                    listCihazlar.Items.Add(item);
                }
                listCihazlar.Refresh();
            }
        }
        private void AlanlariTazele()
        {
            txtCihazAdi.Text = "";
            txtIP.Text = "";
            txtPassword.Text = "";
            txtSSHPort.Text = "22";
            txtUsername.Text = "";
            rndFortigate.Checked = true;
            rndFortimail.Checked = false;
        }

        private void btnHepsiniYedekle_Click(object sender, EventArgs e)
        {
            CihazList clist = islemler.GetAllCihazlar();
            if (clist.cihazlar.Count > 0)
            {
                metroProgressBar1.Visible = true;
                metroProgressBar1.Maximum = clist.cihazlar.Count;
                metroProgressBar1.Value = 0;
                var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
                Parallel.ForEach(listCihazlar.Items.Cast<ListViewItem>(), options, item =>
                {
                    //   foreach (ListViewItem item in listCihazlar.Items)
                    //{
                    var cihaz = clist.cihazlar.Where(c => c.ID.ToString().Equals(item.SubItems[0].Text)).FirstOrDefault();
                    if (cihaz != null)
                    {
                        item.SubItems[7].Text = res_man.GetString("txtIslemde", cul);
                        item.SubItems[7].ForeColor = Color.Blue;
                        item.UseItemStyleForSubItems = false;
                        Backup b = new Backup();
                        b.c = cihaz;
                        b.item = item;
                        
                        ParameterizedThreadStart start = new ParameterizedThreadStart(SSHBaglan);
                        Thread newThread = new Thread(start);
                        newThread.IsBackground = true;
                        newThread.Start(b);
                        newThread.Join();
                        
                        /*
                        Task.Factory.StartNew(delegate
                        {
                            SSHBaglan(b);
                        });
                        */
                    }
                });
            }
        }

        private void SSHBaglan(object b) //Cihazlar cihaz, ListViewItem item
        {
            Backup bb = (Backup)b;
            if (islemler.SSHBaglan(bb.c,bb.item))
            {
                bb.item.SubItems[7].Text = res_man.GetString("txtTamamlandi", cul);
                bb.item.SubItems[7].ForeColor = Color.Green;
                Thread.Sleep(2000);
                bb.item.SubItems[7].Text = "";
            }
            else
            {
                bb.item.SubItems[7].Text = res_man.GetString("txtHataVerdi", cul);
                bb.item.SubItems[7].ForeColor = Color.Red;
            }
            metroProgressBar1.Value +=1;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (listCihazlar.SelectedItems.Count > 0)
            {
                CihazList clist = islemler.GetAllCihazlar();
                var item = listCihazlar.SelectedItems[0];
                var cihaz = clist.cihazlar.Where(c => c.ID.ToString().Equals(item.SubItems[0].Text)).FirstOrDefault();
                if (cihaz != null)
                {
                    item.SubItems[7].Text = res_man.GetString("txtIslemde", cul);
                    item.SubItems[7].ForeColor = Color.Blue;
                    item.UseItemStyleForSubItems = false;

                    Backup b = new Backup();
                    b.c = cihaz;
                    b.item = item;
                    ParameterizedThreadStart start = new ParameterizedThreadStart(SSHBaglan);
                    Thread newThread = new Thread(start);
                    newThread.IsBackground = true;
                    newThread.Start(b);
                    newThread.Join();
                    /*

                    Task.Factory.StartNew(delegate
                    {
                        SSHBaglan(cihaz, item);
                    });
                    */
                }
            }
        }

        private void picTR_Click(object sender, EventArgs e)
        {
            cul = CultureInfo.CreateSpecificCulture("tr-TR");
            switch_Language(cul);
        }

        private void picEn_Click(object sender, EventArgs e)
        {
            cul = CultureInfo.CreateSpecificCulture("en-GB");
            switch_Language(cul);
        }
    }
}
