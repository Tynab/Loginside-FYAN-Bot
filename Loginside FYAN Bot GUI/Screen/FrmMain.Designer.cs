namespace Loginside_FYAN_Bot_GUI.Screen
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCl = new YANF.Control.YANBtn();
            this.pnlIns = new YANF.Control.YANGradPnl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nbDateChgPwd = new YANF.Control.YANNb();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecKey = new YANF.Control.YANTxt();
            this.txtId = new YANF.Control.YANTxt();
            this.txtPwd = new YANF.Control.YANTxt();
            this.txtPwdPrev = new YANF.Control.YANTxt();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOut = new YANF.Control.YANGradPnl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nbOutHour = new YANF.Control.YANNb();
            this.nbOutMin = new YANF.Control.YANNb();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIn = new YANF.Control.YANGradPnl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nbInHour = new YANF.Control.YANNb();
            this.nbInMin = new YANF.Control.YANNb();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAct = new YANF.Control.YANBtn();
            this.btnAdm = new YANF.Control.YANBtn();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlIns.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlIn.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnCl);
            this.pnlMain.Controls.Add(this.pnlIns);
            this.pnlMain.Controls.Add(this.pnlOut);
            this.pnlMain.Controls.Add(this.pnlIn);
            this.pnlMain.Controls.Add(this.btnAct);
            this.pnlMain.Controls.Add(this.btnAdm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 440);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Visible = false;
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.btnCl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCl.BorderRadius = 20;
            this.btnCl.BorderSize = 0;
            this.btnCl.FlatAppearance.BorderSize = 0;
            this.btnCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnCl.ForeColor = System.Drawing.Color.White;
            this.btnCl.Image = global::Loginside_FYAN_Bot_GUI.Properties.Resources.pOff;
            this.btnCl.Location = new System.Drawing.Point(230, 380);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(40, 40);
            this.btnCl.TabIndex = 0;
            this.btnCl.TabStop = false;
            this.tipMain.SetToolTip(this.btnCl, "Đóng");
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Visible = false;
            this.btnCl.Click += new System.EventHandler(this.BtnCl_Click);
            // 
            // pnlIns
            // 
            this.pnlIns.Angle = 45F;
            this.pnlIns.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(99)))));
            this.pnlIns.Controls.Add(this.panel4);
            this.pnlIns.Controls.Add(this.label5);
            this.pnlIns.Location = new System.Drawing.Point(20, 145);
            this.pnlIns.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.pnlIns.Name = "pnlIns";
            this.pnlIns.Padding = new System.Windows.Forms.Padding(1);
            this.pnlIns.Size = new System.Drawing.Size(460, 213);
            this.pnlIns.TabIndex = 3;
            this.pnlIns.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(134)))));
            this.pnlIns.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nbDateChgPwd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSecKey);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.txtPwd);
            this.panel4.Controls.Add(this.txtPwdPrev);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 181);
            this.panel4.TabIndex = 0;
            // 
            // nbDateChgPwd
            // 
            this.nbDateChgPwd.BackColor = System.Drawing.Color.White;
            this.nbDateChgPwd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nbDateChgPwd.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.nbDateChgPwd.BorderRadius = 10;
            this.nbDateChgPwd.BorderSize = 1;
            this.nbDateChgPwd.DecimalPlaces = 0;
            this.nbDateChgPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nbDateChgPwd.ForeColor = System.Drawing.Color.DimGray;
            this.nbDateChgPwd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbDateChgPwd.Location = new System.Drawing.Point(140, 128);
            this.nbDateChgPwd.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.nbDateChgPwd.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nbDateChgPwd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbDateChgPwd.Name = "nbDateChgPwd";
            this.nbDateChgPwd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nbDateChgPwd.Size = new System.Drawing.Size(80, 34);
            this.nbDateChgPwd.TabIndex = 4;
            this.nbDateChgPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbDateChgPwd.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.nbDateChgPwd, "Ngày thay đổi mật khẩu");
            this.nbDateChgPwd.UnderlinedStyle = false;
            this.nbDateChgPwd.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày thay đổi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSecKey
            // 
            this.txtSecKey.BackColor = System.Drawing.Color.White;
            this.txtSecKey.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSecKey.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txtSecKey.BorderRadius = 10;
            this.txtSecKey.BorderSize = 1;
            this.txtSecKey.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSecKey.ForeColor = System.Drawing.Color.DimGray;
            this.txtSecKey.Location = new System.Drawing.Point(20, 74);
            this.txtSecKey.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtSecKey.MaxLength = 32767;
            this.txtSecKey.Multiline = false;
            this.txtSecKey.Name = "txtSecKey";
            this.txtSecKey.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSecKey.PasswordChar = false;
            this.txtSecKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSecKey.PlaceholderText = "Secret Key";
            this.txtSecKey.Size = new System.Drawing.Size(420, 34);
            this.txtSecKey.String = null;
            this.txtSecKey.TabIndex = 3;
            this.txtSecKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.txtSecKey, "Secret key");
            this.txtSecKey.UnderlinedStyle = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 1;
            this.txtId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtId.ForeColor = System.Drawing.Color.DimGray;
            this.txtId.Location = new System.Drawing.Point(20, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "ID";
            this.txtId.Size = new System.Drawing.Size(200, 34);
            this.txtId.String = null;
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.txtId, "ID");
            this.txtId.UnderlinedStyle = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPwd.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txtPwd.BorderRadius = 10;
            this.txtPwd.BorderSize = 1;
            this.txtPwd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPwd.ForeColor = System.Drawing.Color.DimGray;
            this.txtPwd.Location = new System.Drawing.Point(240, 20);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPwd.PasswordChar = true;
            this.txtPwd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPwd.PlaceholderText = "Mật khẩu hiện tại";
            this.txtPwd.Size = new System.Drawing.Size(200, 34);
            this.txtPwd.String = null;
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.txtPwd, "Mật khẩu hiện tại");
            this.txtPwd.UnderlinedStyle = false;
            // 
            // txtPwdPrev
            // 
            this.txtPwdPrev.BackColor = System.Drawing.Color.White;
            this.txtPwdPrev.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPwdPrev.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txtPwdPrev.BorderRadius = 10;
            this.txtPwdPrev.BorderSize = 1;
            this.txtPwdPrev.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPwdPrev.ForeColor = System.Drawing.Color.DimGray;
            this.txtPwdPrev.Location = new System.Drawing.Point(240, 128);
            this.txtPwdPrev.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.txtPwdPrev.MaxLength = 32767;
            this.txtPwdPrev.Multiline = false;
            this.txtPwdPrev.Name = "txtPwdPrev";
            this.txtPwdPrev.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPwdPrev.PasswordChar = true;
            this.txtPwdPrev.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPwdPrev.PlaceholderText = "Mật khẩu dự phòng";
            this.txtPwdPrev.Size = new System.Drawing.Size(200, 34);
            this.txtPwdPrev.String = null;
            this.txtPwdPrev.TabIndex = 5;
            this.txtPwdPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.txtPwdPrev, "Mật khẩu dự phòng");
            this.txtPwdPrev.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(458, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inside";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOut
            // 
            this.pnlOut.Angle = 45F;
            this.pnlOut.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(43)))), ((int)(((byte)(114)))));
            this.pnlOut.Controls.Add(this.panel2);
            this.pnlOut.Controls.Add(this.label1);
            this.pnlOut.Location = new System.Drawing.Point(260, 20);
            this.pnlOut.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Padding = new System.Windows.Forms.Padding(1);
            this.pnlOut.Size = new System.Drawing.Size(220, 105);
            this.pnlOut.TabIndex = 2;
            this.pnlOut.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(44)))), ((int)(((byte)(129)))));
            this.pnlOut.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nbOutHour);
            this.panel2.Controls.Add(this.nbOutMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 73);
            this.panel2.TabIndex = 0;
            // 
            // nbOutHour
            // 
            this.nbOutHour.BackColor = System.Drawing.Color.White;
            this.nbOutHour.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nbOutHour.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.nbOutHour.BorderRadius = 10;
            this.nbOutHour.BorderSize = 1;
            this.nbOutHour.DecimalPlaces = 0;
            this.nbOutHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nbOutHour.ForeColor = System.Drawing.Color.DimGray;
            this.nbOutHour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbOutHour.Location = new System.Drawing.Point(20, 20);
            this.nbOutHour.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.nbOutHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nbOutHour.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbOutHour.Name = "nbOutHour";
            this.nbOutHour.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nbOutHour.Size = new System.Drawing.Size(80, 34);
            this.nbOutHour.TabIndex = 1;
            this.nbOutHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbOutHour.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.nbOutHour, "Giờ check-out");
            this.nbOutHour.UnderlinedStyle = false;
            this.nbOutHour.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nbOutMin
            // 
            this.nbOutMin.BackColor = System.Drawing.Color.White;
            this.nbOutMin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nbOutMin.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.nbOutMin.BorderRadius = 10;
            this.nbOutMin.BorderSize = 1;
            this.nbOutMin.DecimalPlaces = 0;
            this.nbOutMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nbOutMin.ForeColor = System.Drawing.Color.DimGray;
            this.nbOutMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nbOutMin.Location = new System.Drawing.Point(120, 20);
            this.nbOutMin.Margin = new System.Windows.Forms.Padding(20);
            this.nbOutMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nbOutMin.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbOutMin.Name = "nbOutMin";
            this.nbOutMin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nbOutMin.Size = new System.Drawing.Size(80, 34);
            this.nbOutMin.TabIndex = 2;
            this.nbOutMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbOutMin.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.nbOutMin, "Phút check-out");
            this.nbOutMin.UnderlinedStyle = false;
            this.nbOutMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-Out";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlIn
            // 
            this.pnlIn.Angle = 45F;
            this.pnlIn.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(44)))), ((int)(((byte)(125)))));
            this.pnlIn.Controls.Add(this.panel6);
            this.pnlIn.Controls.Add(this.label4);
            this.pnlIn.Location = new System.Drawing.Point(20, 20);
            this.pnlIn.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Padding = new System.Windows.Forms.Padding(1);
            this.pnlIn.Size = new System.Drawing.Size(220, 105);
            this.pnlIn.TabIndex = 1;
            this.pnlIn.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
            this.pnlIn.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.nbInHour);
            this.panel6.Controls.Add(this.nbInMin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 73);
            this.panel6.TabIndex = 0;
            // 
            // nbInHour
            // 
            this.nbInHour.BackColor = System.Drawing.Color.White;
            this.nbInHour.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nbInHour.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.nbInHour.BorderRadius = 10;
            this.nbInHour.BorderSize = 1;
            this.nbInHour.DecimalPlaces = 0;
            this.nbInHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nbInHour.ForeColor = System.Drawing.Color.DimGray;
            this.nbInHour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbInHour.Location = new System.Drawing.Point(20, 20);
            this.nbInHour.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.nbInHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nbInHour.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbInHour.Name = "nbInHour";
            this.nbInHour.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nbInHour.Size = new System.Drawing.Size(80, 34);
            this.nbInHour.TabIndex = 1;
            this.nbInHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbInHour.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.nbInHour, "Giờ check-in");
            this.nbInHour.UnderlinedStyle = false;
            this.nbInHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nbInMin
            // 
            this.nbInMin.BackColor = System.Drawing.Color.White;
            this.nbInMin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nbInMin.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.nbInMin.BorderRadius = 10;
            this.nbInMin.BorderSize = 1;
            this.nbInMin.DecimalPlaces = 0;
            this.nbInMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nbInMin.ForeColor = System.Drawing.Color.DimGray;
            this.nbInMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nbInMin.Location = new System.Drawing.Point(120, 20);
            this.nbInMin.Margin = new System.Windows.Forms.Padding(20);
            this.nbInMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nbInMin.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbInMin.Name = "nbInMin";
            this.nbInMin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nbInMin.Size = new System.Drawing.Size(80, 34);
            this.nbInMin.TabIndex = 2;
            this.nbInMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbInMin.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.nbInMin, "Phút check-in");
            this.nbInMin.UnderlinedStyle = false;
            this.nbInMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(218, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check-In";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.btnAct.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAct.BorderRadius = 20;
            this.btnAct.BorderSize = 0;
            this.btnAct.FlatAppearance.BorderSize = 0;
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAct.ForeColor = System.Drawing.Color.White;
            this.btnAct.Location = new System.Drawing.Point(330, 380);
            this.btnAct.Margin = new System.Windows.Forms.Padding(20);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(150, 40);
            this.btnAct.TabIndex = 0;
            this.btnAct.TabStop = false;
            this.btnAct.Text = "Dừng Bot";
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Visible = false;
            this.btnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(140)))), ((int)(((byte)(210)))));
            this.btnAdm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdm.BorderRadius = 20;
            this.btnAdm.BorderSize = 0;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Location = new System.Drawing.Point(20, 380);
            this.btnAdm.Margin = new System.Windows.Forms.Padding(20);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(150, 40);
            this.btnAdm.TabIndex = 0;
            this.btnAdm.TabStop = false;
            this.btnAdm.Text = "Thiết Lập";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Visible = false;
            this.btnAdm.Click += new System.EventHandler(this.BtnAdm_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginside FYAN Bot GUI";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.pnlMain.ResumeLayout(false);
            this.pnlIns.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlOut.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlIn.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private YANF.Control.YANNb nbInHour;
        private YANF.Control.YANTxt txtId;
        private System.Windows.Forms.ToolTip tipMain;
        private YANF.Control.YANNb nbInMin;
        private YANF.Control.YANBtn btnAct;
        private YANF.Control.YANBtn btnAdm;
        private YANF.Control.YANTxt txtPwdPrev;
        private YANF.Control.YANTxt txtPwd;
        private YANF.Control.YANTxt txtSecKey;
        private YANF.Control.YANGradPnl pnlIn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private YANF.Control.YANGradPnl pnlOut;
        private System.Windows.Forms.Panel panel2;
        private YANF.Control.YANNb nbOutHour;
        private YANF.Control.YANNb nbOutMin;
        private System.Windows.Forms.Label label1;
        private YANF.Control.YANGradPnl pnlIns;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private YANF.Control.YANBtn btnCl;
        private YANF.Control.YANNb nbDateChgPwd;
        private System.Windows.Forms.Label label2;
    }
}