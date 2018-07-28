namespace FortiBackup
{
    partial class frmDuzenle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndFortimail = new MetroFramework.Controls.MetroRadioButton();
            this.rndFortigate = new MetroFramework.Controls.MetroRadioButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtSSHPort = new MetroFramework.Controls.MetroTextBox();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.txtCihazAdi = new MetroFramework.Controls.MetroTextBox();
            this.btnCihazDuzenle = new MetroFramework.Controls.MetroButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblSSHPort = new MetroFramework.Controls.MetroLabel();
            this.lblCihazAdres = new MetroFramework.Controls.MetroLabel();
            this.lblCihazIsmi = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnCihazDuzenle);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lblSSHPort);
            this.groupBox1.Controls.Add(this.lblCihazAdres);
            this.groupBox1.Controls.Add(this.lblCihazIsmi);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 210);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rndFortimail
            // 
            this.rndFortimail.AutoSize = true;
            this.rndFortimail.Location = new System.Drawing.Point(809, 126);
            this.rndFortimail.Name = "rndFortimail";
            this.rndFortimail.Size = new System.Drawing.Size(70, 15);
            this.rndFortimail.TabIndex = 14;
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
            this.rndFortigate.TabIndex = 13;
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
            // btnCihazDuzenle
            // 
            this.btnCihazDuzenle.Location = new System.Drawing.Point(870, 181);
            this.btnCihazDuzenle.Name = "btnCihazDuzenle";
            this.btnCihazDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnCihazDuzenle.TabIndex = 5;
            this.btnCihazDuzenle.Text = "Düzenle";
            this.btnCihazDuzenle.Click += new System.EventHandler(this.btnCihazDuzenle_Click);
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
            // frmDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1004, 328);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDuzenle";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cihaz Düzenleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtSSHPort;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroTextBox txtCihazAdi;
        private MetroFramework.Controls.MetroButton btnCihazDuzenle;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblSSHPort;
        private MetroFramework.Controls.MetroLabel lblCihazAdres;
        private MetroFramework.Controls.MetroLabel lblCihazIsmi;
        private MetroFramework.Controls.MetroRadioButton rndFortimail;
        private MetroFramework.Controls.MetroRadioButton rndFortigate;
    }
}