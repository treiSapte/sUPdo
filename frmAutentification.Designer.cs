namespace sUPdo
{
    partial class frmAutentifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutentifications));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lblTeach = new System.Windows.Forms.Label();
            this.btnSingUP = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordT = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailT = new MetroFramework.Controls.MetroTextBox();
            this.txtNameT = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pnlForgotEmaiil = new MetroFramework.Controls.MetroPanel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.lblSendEmail = new System.Windows.Forms.Label();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtForgotEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSignIN = new System.Windows.Forms.Button();
            this.txtPassSignIN = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailSignIN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnSignupS = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCode_teacher = new MetroFramework.Controls.MetroTextBox();
            this.txtClass = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.pnlForgotEmaiil.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 52);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(334, 359);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lblTeach);
            this.metroTabPage3.Controls.Add(this.btnSingUP);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.txtPasswordT);
            this.metroTabPage3.Controls.Add(this.txtEmailT);
            this.metroTabPage3.Controls.Add(this.txtNameT);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(326, 317);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Înregistrare profesor";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lblTeach
            // 
            this.lblTeach.AutoSize = true;
            this.lblTeach.BackColor = System.Drawing.Color.Transparent;
            this.lblTeach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeach.ForeColor = System.Drawing.Color.Red;
            this.lblTeach.Location = new System.Drawing.Point(18, 23);
            this.lblTeach.Name = "lblTeach";
            this.lblTeach.Size = new System.Drawing.Size(266, 16);
            this.lblTeach.TabIndex = 18;
            this.lblTeach.Text = "Adresa de email există deja în baza de date.";
            this.lblTeach.Visible = false;
            // 
            // btnSingUP
            // 
            this.btnSingUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUP.Location = new System.Drawing.Point(218, 196);
            this.btnSingUP.Name = "btnSingUP";
            this.btnSingUP.Size = new System.Drawing.Size(90, 32);
            this.btnSingUP.TabIndex = 17;
            this.btnSingUP.Text = "Înregistrare";
            this.btnSingUP.UseVisualStyleBackColor = true;
            this.btnSingUP.Click += new System.EventHandler(this.btnSingUP_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Parolă";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 107);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Email";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Nume si prenume";
            // 
            // txtPasswordT
            // 
            // 
            // 
            // 
            this.txtPasswordT.CustomButton.Image = null;
            this.txtPasswordT.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPasswordT.CustomButton.Name = "";
            this.txtPasswordT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordT.CustomButton.TabIndex = 1;
            this.txtPasswordT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordT.CustomButton.UseSelectable = true;
            this.txtPasswordT.CustomButton.Visible = false;
            this.txtPasswordT.Lines = new string[0];
            this.txtPasswordT.Location = new System.Drawing.Point(154, 153);
            this.txtPasswordT.MaxLength = 32767;
            this.txtPasswordT.Name = "txtPasswordT";
            this.txtPasswordT.PasswordChar = '*';
            this.txtPasswordT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordT.SelectedText = "";
            this.txtPasswordT.SelectionLength = 0;
            this.txtPasswordT.SelectionStart = 0;
            this.txtPasswordT.ShortcutsEnabled = true;
            this.txtPasswordT.Size = new System.Drawing.Size(154, 23);
            this.txtPasswordT.TabIndex = 13;
            this.txtPasswordT.UseSelectable = true;
            this.txtPasswordT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailT
            // 
            // 
            // 
            // 
            this.txtEmailT.CustomButton.Image = null;
            this.txtEmailT.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtEmailT.CustomButton.Name = "";
            this.txtEmailT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailT.CustomButton.TabIndex = 1;
            this.txtEmailT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailT.CustomButton.UseSelectable = true;
            this.txtEmailT.CustomButton.Visible = false;
            this.txtEmailT.Lines = new string[0];
            this.txtEmailT.Location = new System.Drawing.Point(154, 107);
            this.txtEmailT.MaxLength = 32767;
            this.txtEmailT.Name = "txtEmailT";
            this.txtEmailT.PasswordChar = '\0';
            this.txtEmailT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailT.SelectedText = "";
            this.txtEmailT.SelectionLength = 0;
            this.txtEmailT.SelectionStart = 0;
            this.txtEmailT.ShortcutsEnabled = true;
            this.txtEmailT.Size = new System.Drawing.Size(154, 23);
            this.txtEmailT.TabIndex = 12;
            this.txtEmailT.UseSelectable = true;
            this.txtEmailT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameT
            // 
            // 
            // 
            // 
            this.txtNameT.CustomButton.Image = null;
            this.txtNameT.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtNameT.CustomButton.Name = "";
            this.txtNameT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameT.CustomButton.TabIndex = 1;
            this.txtNameT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameT.CustomButton.UseSelectable = true;
            this.txtNameT.CustomButton.Visible = false;
            this.txtNameT.Lines = new string[0];
            this.txtNameT.Location = new System.Drawing.Point(154, 60);
            this.txtNameT.MaxLength = 32767;
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.PasswordChar = '\0';
            this.txtNameT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameT.SelectedText = "";
            this.txtNameT.SelectionLength = 0;
            this.txtNameT.SelectionStart = 0;
            this.txtNameT.ShortcutsEnabled = true;
            this.txtNameT.Size = new System.Drawing.Size(154, 23);
            this.txtNameT.TabIndex = 11;
            this.txtNameT.UseSelectable = true;
            this.txtNameT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.pnlForgotEmaiil);
            this.metroTabPage1.Controls.Add(this.btnForgotPass);
            this.metroTabPage1.Controls.Add(this.lblLogin);
            this.metroTabPage1.Controls.Add(this.btnSignIN);
            this.metroTabPage1.Controls.Add(this.txtPassSignIN);
            this.metroTabPage1.Controls.Add(this.txtEmailSignIN);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(326, 317);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Autentificare";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // pnlForgotEmaiil
            // 
            this.pnlForgotEmaiil.Controls.Add(this.btnSendEmail);
            this.pnlForgotEmaiil.Controls.Add(this.lblSendEmail);
            this.pnlForgotEmaiil.Controls.Add(this.metroLabel11);
            this.pnlForgotEmaiil.Controls.Add(this.txtForgotEmail);
            this.pnlForgotEmaiil.HorizontalScrollbarBarColor = true;
            this.pnlForgotEmaiil.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlForgotEmaiil.HorizontalScrollbarSize = 10;
            this.pnlForgotEmaiil.Location = new System.Drawing.Point(-4, 176);
            this.pnlForgotEmaiil.Name = "pnlForgotEmaiil";
            this.pnlForgotEmaiil.Size = new System.Drawing.Size(334, 141);
            this.pnlForgotEmaiil.TabIndex = 17;
            this.pnlForgotEmaiil.VerticalScrollbarBarColor = true;
            this.pnlForgotEmaiil.VerticalScrollbarHighlightOnWheel = false;
            this.pnlForgotEmaiil.VerticalScrollbarSize = 10;
            this.pnlForgotEmaiil.Visible = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Location = new System.Drawing.Point(218, 58);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(88, 32);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Recuperează";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // lblSendEmail
            // 
            this.lblSendEmail.AutoSize = true;
            this.lblSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSendEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendEmail.ForeColor = System.Drawing.Color.Red;
            this.lblSendEmail.Location = new System.Drawing.Point(33, 103);
            this.lblSendEmail.Name = "lblSendEmail";
            this.lblSendEmail.Size = new System.Drawing.Size(284, 16);
            this.lblSendEmail.TabIndex = 15;
            this.lblSendEmail.Text = "Adresa de email nu există deja în baza de date.";
            this.lblSendEmail.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(36, 18);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 19);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Email";
            // 
            // txtForgotEmail
            // 
            // 
            // 
            // 
            this.txtForgotEmail.CustomButton.Image = null;
            this.txtForgotEmail.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtForgotEmail.CustomButton.Name = "";
            this.txtForgotEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtForgotEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtForgotEmail.CustomButton.TabIndex = 1;
            this.txtForgotEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtForgotEmail.CustomButton.UseSelectable = true;
            this.txtForgotEmail.CustomButton.Visible = false;
            this.txtForgotEmail.Lines = new string[0];
            this.txtForgotEmail.Location = new System.Drawing.Point(168, 18);
            this.txtForgotEmail.MaxLength = 32767;
            this.txtForgotEmail.Name = "txtForgotEmail";
            this.txtForgotEmail.PasswordChar = '\0';
            this.txtForgotEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtForgotEmail.SelectedText = "";
            this.txtForgotEmail.SelectionLength = 0;
            this.txtForgotEmail.SelectionStart = 0;
            this.txtForgotEmail.ShortcutsEnabled = true;
            this.txtForgotEmail.Size = new System.Drawing.Size(138, 23);
            this.txtForgotEmail.TabIndex = 4;
            this.txtForgotEmail.UseSelectable = true;
            this.txtForgotEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtForgotEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Location = new System.Drawing.Point(44, 138);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(88, 32);
            this.btnForgotPass.TabIndex = 16;
            this.btnForgotPass.Text = "Parolă uitată";
            this.btnForgotPass.UseVisualStyleBackColor = true;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(29, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(284, 16);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Adresa de email nu există deja în baza de date.";
            this.lblLogin.Visible = false;
            // 
            // btnSignIN
            // 
            this.btnSignIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIN.Location = new System.Drawing.Point(214, 138);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.Size = new System.Drawing.Size(88, 32);
            this.btnSignIN.TabIndex = 6;
            this.btnSignIN.Text = "Autentificare";
            this.btnSignIN.UseVisualStyleBackColor = true;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
            // 
            // txtPassSignIN
            // 
            // 
            // 
            // 
            this.txtPassSignIN.CustomButton.Image = null;
            this.txtPassSignIN.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtPassSignIN.CustomButton.Name = "";
            this.txtPassSignIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassSignIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassSignIN.CustomButton.TabIndex = 1;
            this.txtPassSignIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassSignIN.CustomButton.UseSelectable = true;
            this.txtPassSignIN.CustomButton.Visible = false;
            this.txtPassSignIN.Lines = new string[0];
            this.txtPassSignIN.Location = new System.Drawing.Point(164, 91);
            this.txtPassSignIN.MaxLength = 32767;
            this.txtPassSignIN.Name = "txtPassSignIN";
            this.txtPassSignIN.PasswordChar = '*';
            this.txtPassSignIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassSignIN.SelectedText = "";
            this.txtPassSignIN.SelectionLength = 0;
            this.txtPassSignIN.SelectionStart = 0;
            this.txtPassSignIN.ShortcutsEnabled = true;
            this.txtPassSignIN.Size = new System.Drawing.Size(138, 23);
            this.txtPassSignIN.TabIndex = 5;
            this.txtPassSignIN.UseSelectable = true;
            this.txtPassSignIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassSignIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailSignIN
            // 
            // 
            // 
            // 
            this.txtEmailSignIN.CustomButton.Image = null;
            this.txtEmailSignIN.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtEmailSignIN.CustomButton.Name = "";
            this.txtEmailSignIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailSignIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailSignIN.CustomButton.TabIndex = 1;
            this.txtEmailSignIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailSignIN.CustomButton.UseSelectable = true;
            this.txtEmailSignIN.CustomButton.Visible = false;
            this.txtEmailSignIN.Lines = new string[0];
            this.txtEmailSignIN.Location = new System.Drawing.Point(164, 54);
            this.txtEmailSignIN.MaxLength = 32767;
            this.txtEmailSignIN.Name = "txtEmailSignIN";
            this.txtEmailSignIN.PasswordChar = '\0';
            this.txtEmailSignIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailSignIN.SelectedText = "";
            this.txtEmailSignIN.SelectionLength = 0;
            this.txtEmailSignIN.SelectionStart = 0;
            this.txtEmailSignIN.ShortcutsEnabled = true;
            this.txtEmailSignIN.Size = new System.Drawing.Size(138, 23);
            this.txtEmailSignIN.TabIndex = 4;
            this.txtEmailSignIN.UseSelectable = true;
            this.txtEmailSignIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailSignIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(32, 95);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Parola";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(32, 58);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(41, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Email";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lblStudent);
            this.metroTabPage2.Controls.Add(this.btnSignupS);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txtCode_teacher);
            this.metroTabPage2.Controls.Add(this.txtClass);
            this.metroTabPage2.Controls.Add(this.txtPassword);
            this.metroTabPage2.Controls.Add(this.txtEmail);
            this.metroTabPage2.Controls.Add(this.txtName);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(326, 317);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Înregistrare elev";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(21, 16);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(266, 16);
            this.lblStudent.TabIndex = 14;
            this.lblStudent.Text = "Adresa de email există deja în baza de date.";
            this.lblStudent.Visible = false;
            // 
            // btnSignupS
            // 
            this.btnSignupS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupS.Location = new System.Drawing.Point(231, 288);
            this.btnSignupS.Name = "btnSignupS";
            this.btnSignupS.Size = new System.Drawing.Size(86, 25);
            this.btnSignupS.TabIndex = 13;
            this.btnSignupS.Text = "Înregistrare";
            this.btnSignupS.UseVisualStyleBackColor = true;
            this.btnSignupS.Click += new System.EventHandler(this.btnSignupS_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 241);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Cod profesor";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Clasa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Parolă";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Email";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Nume si prenume";
            // 
            // txtCode_teacher
            // 
            // 
            // 
            // 
            this.txtCode_teacher.CustomButton.Image = null;
            this.txtCode_teacher.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtCode_teacher.CustomButton.Name = "";
            this.txtCode_teacher.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode_teacher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode_teacher.CustomButton.TabIndex = 1;
            this.txtCode_teacher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode_teacher.CustomButton.UseSelectable = true;
            this.txtCode_teacher.CustomButton.Visible = false;
            this.txtCode_teacher.Lines = new string[0];
            this.txtCode_teacher.Location = new System.Drawing.Point(163, 241);
            this.txtCode_teacher.MaxLength = 32767;
            this.txtCode_teacher.Name = "txtCode_teacher";
            this.txtCode_teacher.PasswordChar = '\0';
            this.txtCode_teacher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode_teacher.SelectedText = "";
            this.txtCode_teacher.SelectionLength = 0;
            this.txtCode_teacher.SelectionStart = 0;
            this.txtCode_teacher.ShortcutsEnabled = true;
            this.txtCode_teacher.Size = new System.Drawing.Size(154, 23);
            this.txtCode_teacher.TabIndex = 6;
            this.txtCode_teacher.UseSelectable = true;
            this.txtCode_teacher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode_teacher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClass
            // 
            // 
            // 
            // 
            this.txtClass.CustomButton.Image = null;
            this.txtClass.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtClass.CustomButton.Name = "";
            this.txtClass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClass.CustomButton.TabIndex = 1;
            this.txtClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClass.CustomButton.UseSelectable = true;
            this.txtClass.CustomButton.Visible = false;
            this.txtClass.Lines = new string[0];
            this.txtClass.Location = new System.Drawing.Point(163, 190);
            this.txtClass.MaxLength = 32767;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.ShortcutsEnabled = true;
            this.txtClass.Size = new System.Drawing.Size(154, 23);
            this.txtClass.TabIndex = 5;
            this.txtClass.UseSelectable = true;
            this.txtClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(163, 145);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(154, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(163, 99);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(154, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(163, 52);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(154, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAutentifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 421);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAutentifications";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "sUPdo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.pnlForgotEmaiil.ResumeLayout(false);
            this.pnlForgotEmaiil.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCode_teacher;
        private MetroFramework.Controls.MetroTextBox txtClass;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPasswordT;
        private MetroFramework.Controls.MetroTextBox txtEmailT;
        private MetroFramework.Controls.MetroTextBox txtNameT;
        private System.Windows.Forms.Button btnSingUP;
        private System.Windows.Forms.Button btnSignupS;
        private System.Windows.Forms.Button btnSignIN;
        private MetroFramework.Controls.MetroTextBox txtPassSignIN;
        private MetroFramework.Controls.MetroTextBox txtEmailSignIN;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Label lblTeach;
        private MetroFramework.Controls.MetroPanel pnlForgotEmaiil;
        private System.Windows.Forms.Button btnSendEmail;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtForgotEmail;
        private System.Windows.Forms.Label lblSendEmail;
    }
}

