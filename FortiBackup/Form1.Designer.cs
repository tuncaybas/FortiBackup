namespace FortiBackup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBaglan = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listCihazlar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duzenle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndFortimail = new MetroFramework.Controls.MetroRadioButton();
            this.rndFortigate = new MetroFramework.Controls.MetroRadioButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtSSHPort = new MetroFramework.Controls.MetroTextBox();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.txtCihazAdi = new MetroFramework.Controls.MetroTextBox();
            this.btnCihazKayit = new MetroFramework.Controls.MetroButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblSSHPort = new MetroFramework.Controls.MetroLabel();
            this.lblCihazAdres = new MetroFramework.Controls.MetroLabel();
            this.lblCihazIsmi = new MetroFramework.Controls.MetroLabel();
            this.btnHepsiniYedekle = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.picTR = new System.Windows.Forms.PictureBox();
            this.picEn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(20, 393);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(139, 23);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Seçileni Yedek Al";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listCihazlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 357);
            this.panel1.TabIndex = 1;
            // 
            // listCihazlar
            // 
            this.listCihazlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCihazlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Isim,
            this.IP,
            this.Port,
            this.Username,
            this.Password,
            this.Tip,
            this.Durum,
            this.Duzenle,
            this.Sil});
            this.listCihazlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCihazlar.FullRowSelect = true;
            this.listCihazlar.GridLines = true;
            this.listCihazlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listCihazlar.Location = new System.Drawing.Point(0, 0);
            this.listCihazlar.MultiSelect = false;
            this.listCihazlar.Name = "listCihazlar";
            this.listCihazlar.Size = new System.Drawing.Size(1168, 357);
            this.listCihazlar.TabIndex = 0;
            this.listCihazlar.UseCompatibleStateImageBehavior = false;
            this.listCihazlar.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "#";
            // 
            // Isim
            // 
            this.Isim.Text = "İsim";
            this.Isim.Width = 220;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 73;
            // 
            // Port
            // 
            this.Port.Text = "SSH Port";
            this.Port.Width = 82;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 124;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 158;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            // 
            // Durum
            // 
            this.Durum.Text = "";
            this.Durum.Width = 115;
            // 
            // Duzenle
            // 
            this.Duzenle.Text = "";
            this.Duzenle.Width = 95;
            // 
            // Sil
            // 
            this.Sil.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndFortimail);
            this.groupBox1.Controls.Add(this.rndFortigate);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtSSHPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtCihazAdi);
            this.groupBox1.Controls.Add(this.btnCihazKayit);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblSSHPort);
            this.groupBox1.Controls.Add(this.lblCihazAdres);
            this.groupBox1.Controls.Add(this.lblCihazIsmi);
            this.groupBox1.Location = new System.Drawing.Point(20, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Cihaz Kayıt";
            // 
            // rndFortimail
            // 
            this.rndFortimail.AutoSize = true;
            this.rndFortimail.Location = new System.Drawing.Point(809, 126);
            this.rndFortimail.Name = "rndFortimail";
            this.rndFortimail.Size = new System.Drawing.Size(70, 15);
            this.rndFortimail.TabIndex = 12;
            this.rndFortimail.Text = "Fortimail";
            this.rndFortimail.UseVisualStyleBackColor = true;
            // 
            // rndFortigate
            // 
            this.rndFortigate.AutoSize = true;
            this.rndFortigate.Checked = true;
            this.rndFortigate.Location = new System.Drawing.Point(707, 126);
            this.rndFortigate.Name = "rndFortigate";
            this.rndFortigate.Size = new System.Drawing.Size(70, 15);
            this.rndFortigate.TabIndex = 11;
            this.rndFortigate.TabStop = true;
            this.rndFortigate.Text = "Fortigate";
            this.rndFortigate.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(471, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 126);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 23);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSSHPort
            // 
            this.txtSSHPort.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSSHPort.Location = new System.Drawing.Point(782, 57);
            this.txtSSHPort.Name = "txtSSHPort";
            this.txtSSHPort.Size = new System.Drawing.Size(163, 23);
            this.txtSSHPort.TabIndex = 8;
            this.txtSSHPort.Text = "22";
            this.txtSSHPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(471, 57);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(163, 23);
            this.txtIP.TabIndex = 7;
            this.txtIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.Location = new System.Drawing.Point(136, 57);
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.Size = new System.Drawing.Size(163, 23);
            this.txtCihazAdi.TabIndex = 6;
            this.txtCihazAdi.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnCihazKayit
            // 
            this.btnCihazKayit.Location = new System.Drawing.Point(1063, 167);
            this.btnCihazKayit.Name = "btnCihazKayit";
            this.btnCihazKayit.Size = new System.Drawing.Size(75, 23);
            this.btnCihazKayit.TabIndex = 5;
            this.btnCihazKayit.Text = "Kaydet";
            this.btnCihazKayit.Click += new System.EventHandler(this.btnCihazKayit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPassword.Location = new System.Drawing.Point(360, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password : ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.Location = new System.Drawing.Point(47, 126);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 19);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username : ";
            // 
            // lblSSHPort
            // 
            this.lblSSHPort.AutoSize = true;
            this.lblSSHPort.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSSHPort.Location = new System.Drawing.Point(707, 57);
            this.lblSSHPort.Name = "lblSSHPort";
            this.lblSSHPort.Size = new System.Drawing.Size(69, 19);
            this.lblSSHPort.TabIndex = 2;
            this.lblSSHPort.Text = "SSH Port: ";
            // 
            // lblCihazAdres
            // 
            this.lblCihazAdres.AutoSize = true;
            this.lblCihazAdres.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCihazAdres.Location = new System.Drawing.Point(360, 57);
            this.lblCihazAdres.Name = "lblCihazAdres";
            this.lblCihazAdres.Size = new System.Drawing.Size(92, 19);
            this.lblCihazAdres.TabIndex = 1;
            this.lblCihazAdres.Text = "Cihaz Adres : ";
            // 
            // lblCihazIsmi
            // 
            this.lblCihazIsmi.AutoSize = true;
            this.lblCihazIsmi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCihazIsmi.Location = new System.Drawing.Point(47, 57);
            this.lblCihazIsmi.Name = "lblCihazIsmi";
            this.lblCihazIsmi.Size = new System.Drawing.Size(82, 19);
            this.lblCihazIsmi.TabIndex = 0;
            this.lblCihazIsmi.Text = "Cihaz İsmi : ";
            // 
            // btnHepsiniYedekle
            // 
            this.btnHepsiniYedekle.Location = new System.Drawing.Point(165, 394);
            this.btnHepsiniYedekle.Name = "btnHepsiniYedekle";
            this.btnHepsiniYedekle.Size = new System.Drawing.Size(97, 23);
            this.btnHepsiniYedekle.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnHepsiniYedekle.TabIndex = 3;
            this.btnHepsiniYedekle.Text = "Hepsini Yedekle";
            this.btnHepsiniYedekle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHepsiniYedekle.Click += new System.EventHandler(this.btnHepsiniYedekle_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(343, 392);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(845, 23);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.TabIndex = 4;
            this.metroProgressBar1.Visible = false;
            // 
            // picTR
            // 
            this.picTR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTR.Image = ((System.Drawing.Image)(resources.GetObject("picTR.Image")));
            this.picTR.Location = new System.Drawing.Point(23, 5);
            this.picTR.Name = "picTR";
            this.picTR.Size = new System.Drawing.Size(27, 19);
            this.picTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTR.TabIndex = 5;
            this.picTR.TabStop = false;
            this.picTR.Click += new System.EventHandler(this.picTR_Click);
            // 
            // picEn
            // 
            this.picEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEn.Image = ((System.Drawing.Image)(resources.GetObject("picEn.Image")));
            this.picEn.Location = new System.Drawing.Point(56, 5);
            this.picEn.Name = "picEn";
            this.picEn.Size = new System.Drawing.Size(27, 19);
            this.picEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEn.TabIndex = 6;
            this.picEn.TabStop = false;
            this.picEn.Click += new System.EventHandler(this.picEn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1208, 656);
            this.Controls.Add(this.picEn);
            this.Controls.Add(this.picTR);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.btnHepsiniYedekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBaglan);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "FortiBackup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBaglan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Isim;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtSSHPort;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroTextBox txtCihazAdi;
        private MetroFramework.Controls.MetroButton btnCihazKayit;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblSSHPort;
        private MetroFramework.Controls.MetroLabel lblCihazAdres;
        private MetroFramework.Controls.MetroLabel lblCihazIsmi;
        private MetroFramework.Controls.MetroButton btnHepsiniYedekle;
        private System.Windows.Forms.ColumnHeader Durum;
        private System.Windows.Forms.ColumnHeader Duzenle;
        private System.Windows.Forms.ColumnHeader Sil;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        internal System.Windows.Forms.ListView listCihazlar;
        private MetroFramework.Controls.MetroRadioButton rndFortimail;
        private MetroFramework.Controls.MetroRadioButton rndFortigate;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.PictureBox picTR;
        private System.Windows.Forms.PictureBox picEn;
    }
}

