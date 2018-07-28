using FortiBackup.Objeler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortiBackup
{
    public partial class frmDuzenle : MetroFramework.Forms.MetroForm
    {
        public Cihazlar cihaz;
        public Form1 anaForm;

        public static ResourceManager res_man;
        public static CultureInfo cul;

        public frmDuzenle()
        {
            InitializeComponent();
            res_man = Form1.res_man;
            cul = Form1.cul;

            lblCihazAdres.Text = res_man.GetString("txtIP", cul);
            lblCihazIsmi.Text = res_man.GetString("txtCihazAdi", cul);
            lblPassword.Text = res_man.GetString("txtPassword", cul);
            lblSSHPort.Text = res_man.GetString("txtSSHPort", cul);
            lblUsername.Text = res_man.GetString("txtUsername", cul);
            btnCihazDuzenle.Text = res_man.GetString("btnCihazDuzenle", cul);
            this.Text = res_man.GetString("frmDuzenle", cul);
        }

        internal void cihazGetir()
        {
            txtCihazAdi.Text = cihaz.CihazAdi;
            txtIP.Text = cihaz.Adres;
            txtPassword.Text = cihaz.Password;
            txtSSHPort.Text = cihaz.Port.ToString();
            txtUsername.Text =cihaz.Username;
            rndFortigate.Checked = (cihaz.Tip == Turu.Fortigate) ? true : false;
            rndFortimail.Checked= (cihaz.Tip == Turu.Fortimail) ? true : false;
        }

        private void btnCihazDuzenle_Click(object sender, EventArgs e)
        {
            string isim = txtCihazAdi.Text;
            string adres = txtIP.Text;
            string port = txtSSHPort.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrEmpty(isim) || String.IsNullOrEmpty(adres) || String.IsNullOrEmpty(port) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || port == "0")
            {
                MessageBox.Show(res_man.GetString("txtTumAlanlarDoldur", cul));
            }
            else
            {
                cihaz.CihazAdi = isim;
                cihaz.Adres = adres;
                cihaz.Port = Convert.ToInt32(port);
                cihaz.Username = username;
                cihaz.Password = password;
                cihaz.Tip = (rndFortigate.Checked) ? Turu.Fortigate : Turu.Fortimail;
                islemler islem = new islemler();
                
                Result r = islem.CihazD(cihaz);
                if (r.success)
                {
                    MessageBox.Show(r.mesaj);
                    anaForm.ListeyiGuncelle();
                }
                else
                {
                    MessageBox.Show(r.mesaj);
                }

            }
        }
    }
}
