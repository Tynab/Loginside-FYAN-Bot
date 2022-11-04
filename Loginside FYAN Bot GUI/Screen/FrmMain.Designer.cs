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
            this.panel1 = new System.Windows.Forms.Panel();
            this.yanNb1 = new YANF.Control.YANNb();
            this.nbInHour = new YANF.Control.YANNb();
            this.yanBtn2 = new YANF.Control.YANBtn();
            this.yanBtn1 = new YANF.Control.YANBtn();
            this.yanTxt5 = new YANF.Control.YANTxt();
            this.yanTxt4 = new YANF.Control.YANTxt();
            this.yanTxt3 = new YANF.Control.YANTxt();
            this.yanTxt2 = new YANF.Control.YANTxt();
            this.yanTxt1 = new YANF.Control.YANTxt();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.yanTxt6 = new YANF.Control.YANTxt();
            this.yanNb2 = new YANF.Control.YANNb();
            this.yanGradPnl1 = new YANF.Control.YANGradPnl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.yanGradPnl2 = new YANF.Control.YANGradPnl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yanNb3 = new YANF.Control.YANNb();
            this.yanNb4 = new YANF.Control.YANNb();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yanGradPnl3 = new YANF.Control.YANGradPnl();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.yanBtn3 = new YANF.Control.YANBtn();
            this.panel1.SuspendLayout();
            this.yanGradPnl1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.yanGradPnl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.yanGradPnl3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.yanBtn3);
            this.panel1.Controls.Add(this.yanGradPnl3);
            this.panel1.Controls.Add(this.yanGradPnl2);
            this.panel1.Controls.Add(this.yanGradPnl1);
            this.panel1.Controls.Add(this.yanBtn2);
            this.panel1.Controls.Add(this.yanBtn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 545);
            this.panel1.TabIndex = 0;
            // 
            // yanNb1
            // 
            this.yanNb1.BackColor = System.Drawing.Color.White;
            this.yanNb1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanNb1.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanNb1.BorderRadius = 10;
            this.yanNb1.BorderSize = 1;
            this.yanNb1.DecimalPlaces = 0;
            this.yanNb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yanNb1.ForeColor = System.Drawing.Color.DimGray;
            this.yanNb1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yanNb1.Location = new System.Drawing.Point(120, 20);
            this.yanNb1.Margin = new System.Windows.Forms.Padding(20);
            this.yanNb1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.yanNb1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yanNb1.Name = "yanNb1";
            this.yanNb1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanNb1.Size = new System.Drawing.Size(80, 34);
            this.yanNb1.TabIndex = 2;
            this.yanNb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yanNb1.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.yanNb1, "Phút check-in");
            this.yanNb1.UnderlinedStyle = false;
            this.yanNb1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
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
            this.nbInHour.ThousandsSeparator = true;
            this.tipMain.SetToolTip(this.nbInHour, "Giờ check-in");
            this.nbInHour.UnderlinedStyle = false;
            this.nbInHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // yanBtn2
            // 
            this.yanBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.yanBtn2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.yanBtn2.BorderRadius = 20;
            this.yanBtn2.BorderSize = 0;
            this.yanBtn2.FlatAppearance.BorderSize = 0;
            this.yanBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yanBtn2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.yanBtn2.ForeColor = System.Drawing.Color.White;
            this.yanBtn2.Location = new System.Drawing.Point(332, 485);
            this.yanBtn2.Margin = new System.Windows.Forms.Padding(20);
            this.yanBtn2.Name = "yanBtn2";
            this.yanBtn2.Size = new System.Drawing.Size(150, 40);
            this.yanBtn2.TabIndex = 0;
            this.yanBtn2.TabStop = false;
            this.yanBtn2.Text = "Dừng Bot";
            this.yanBtn2.UseVisualStyleBackColor = false;
            // 
            // yanBtn1
            // 
            this.yanBtn1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.yanBtn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.yanBtn1.BorderRadius = 20;
            this.yanBtn1.BorderSize = 0;
            this.yanBtn1.FlatAppearance.BorderSize = 0;
            this.yanBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yanBtn1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.yanBtn1.ForeColor = System.Drawing.Color.White;
            this.yanBtn1.Location = new System.Drawing.Point(20, 485);
            this.yanBtn1.Margin = new System.Windows.Forms.Padding(20);
            this.yanBtn1.Name = "yanBtn1";
            this.yanBtn1.Size = new System.Drawing.Size(150, 40);
            this.yanBtn1.TabIndex = 0;
            this.yanBtn1.TabStop = false;
            this.yanBtn1.Text = "Thiết Lập";
            this.yanBtn1.UseVisualStyleBackColor = false;
            // 
            // yanTxt5
            // 
            this.yanTxt5.BackColor = System.Drawing.Color.White;
            this.yanTxt5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt5.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt5.BorderRadius = 10;
            this.yanTxt5.BorderSize = 1;
            this.yanTxt5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt5.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt5.Location = new System.Drawing.Point(240, 236);
            this.yanTxt5.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.yanTxt5.MaxLength = 32767;
            this.yanTxt5.Multiline = false;
            this.yanTxt5.Name = "yanTxt5";
            this.yanTxt5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt5.PasswordChar = true;
            this.yanTxt5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt5.PlaceholderText = "Mật khẩu dự phòng 3";
            this.yanTxt5.Size = new System.Drawing.Size(200, 34);
            this.yanTxt5.String = null;
            this.yanTxt5.TabIndex = 7;
            this.yanTxt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt5, "Mật khẩu dự phòng 3");
            this.yanTxt5.UnderlinedStyle = false;
            // 
            // yanTxt4
            // 
            this.yanTxt4.BackColor = System.Drawing.Color.White;
            this.yanTxt4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt4.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt4.BorderRadius = 10;
            this.yanTxt4.BorderSize = 1;
            this.yanTxt4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt4.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt4.Location = new System.Drawing.Point(240, 182);
            this.yanTxt4.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.yanTxt4.MaxLength = 32767;
            this.yanTxt4.Multiline = false;
            this.yanTxt4.Name = "yanTxt4";
            this.yanTxt4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt4.PasswordChar = true;
            this.yanTxt4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt4.PlaceholderText = "Mật khẩu dự phòng 2";
            this.yanTxt4.Size = new System.Drawing.Size(200, 34);
            this.yanTxt4.String = null;
            this.yanTxt4.TabIndex = 6;
            this.yanTxt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt4, "Mật khẩu dự phòng 2");
            this.yanTxt4.UnderlinedStyle = false;
            // 
            // yanTxt3
            // 
            this.yanTxt3.BackColor = System.Drawing.Color.White;
            this.yanTxt3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt3.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt3.BorderRadius = 10;
            this.yanTxt3.BorderSize = 1;
            this.yanTxt3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt3.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt3.Location = new System.Drawing.Point(240, 128);
            this.yanTxt3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.yanTxt3.MaxLength = 32767;
            this.yanTxt3.Multiline = false;
            this.yanTxt3.Name = "yanTxt3";
            this.yanTxt3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt3.PasswordChar = true;
            this.yanTxt3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt3.PlaceholderText = "Mật khẩu dự phòng 1";
            this.yanTxt3.Size = new System.Drawing.Size(200, 34);
            this.yanTxt3.String = null;
            this.yanTxt3.TabIndex = 5;
            this.yanTxt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt3, "Mật khẩu dự phòng 1");
            this.yanTxt3.UnderlinedStyle = false;
            // 
            // yanTxt2
            // 
            this.yanTxt2.BackColor = System.Drawing.Color.White;
            this.yanTxt2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt2.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt2.BorderRadius = 10;
            this.yanTxt2.BorderSize = 1;
            this.yanTxt2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt2.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt2.Location = new System.Drawing.Point(240, 20);
            this.yanTxt2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.yanTxt2.MaxLength = 32767;
            this.yanTxt2.Multiline = false;
            this.yanTxt2.Name = "yanTxt2";
            this.yanTxt2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt2.PasswordChar = true;
            this.yanTxt2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt2.PlaceholderText = "Mật khẩu hiện tại";
            this.yanTxt2.Size = new System.Drawing.Size(200, 34);
            this.yanTxt2.String = null;
            this.yanTxt2.TabIndex = 2;
            this.yanTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt2, "Mật khẩu hiện tại");
            this.yanTxt2.UnderlinedStyle = false;
            // 
            // yanTxt1
            // 
            this.yanTxt1.BackColor = System.Drawing.Color.White;
            this.yanTxt1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt1.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt1.BorderRadius = 10;
            this.yanTxt1.BorderSize = 1;
            this.yanTxt1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt1.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt1.Location = new System.Drawing.Point(20, 20);
            this.yanTxt1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.yanTxt1.MaxLength = 32767;
            this.yanTxt1.Multiline = false;
            this.yanTxt1.Name = "yanTxt1";
            this.yanTxt1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt1.PasswordChar = false;
            this.yanTxt1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt1.PlaceholderText = "ID";
            this.yanTxt1.Size = new System.Drawing.Size(200, 34);
            this.yanTxt1.String = null;
            this.yanTxt1.TabIndex = 1;
            this.yanTxt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt1, "ID");
            this.yanTxt1.UnderlinedStyle = false;
            // 
            // yanTxt6
            // 
            this.yanTxt6.BackColor = System.Drawing.Color.White;
            this.yanTxt6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanTxt6.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanTxt6.BorderRadius = 10;
            this.yanTxt6.BorderSize = 1;
            this.yanTxt6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.yanTxt6.ForeColor = System.Drawing.Color.DimGray;
            this.yanTxt6.Location = new System.Drawing.Point(20, 74);
            this.yanTxt6.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.yanTxt6.MaxLength = 32767;
            this.yanTxt6.Multiline = false;
            this.yanTxt6.Name = "yanTxt6";
            this.yanTxt6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanTxt6.PasswordChar = false;
            this.yanTxt6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.yanTxt6.PlaceholderText = "Secret Key";
            this.yanTxt6.Size = new System.Drawing.Size(420, 34);
            this.yanTxt6.String = null;
            this.yanTxt6.TabIndex = 3;
            this.yanTxt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMain.SetToolTip(this.yanTxt6, "Secret key");
            this.yanTxt6.UnderlinedStyle = false;
            // 
            // yanNb2
            // 
            this.yanNb2.BackColor = System.Drawing.Color.White;
            this.yanNb2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanNb2.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanNb2.BorderRadius = 10;
            this.yanNb2.BorderSize = 1;
            this.yanNb2.DecimalPlaces = 0;
            this.yanNb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yanNb2.ForeColor = System.Drawing.Color.DimGray;
            this.yanNb2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yanNb2.Location = new System.Drawing.Point(130, 182);
            this.yanNb2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.yanNb2.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.yanNb2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yanNb2.Name = "yanNb2";
            this.yanNb2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanNb2.Size = new System.Drawing.Size(90, 34);
            this.yanNb2.TabIndex = 4;
            this.yanNb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yanNb2.ThousandsSeparator = true;
            this.tipMain.SetToolTip(this.yanNb2, "Ngày thay đổi mật khẩu");
            this.yanNb2.UnderlinedStyle = false;
            this.yanNb2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // yanGradPnl1
            // 
            this.yanGradPnl1.Angle = 45F;
            this.yanGradPnl1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(44)))), ((int)(((byte)(125)))));
            this.yanGradPnl1.Controls.Add(this.panel6);
            this.yanGradPnl1.Controls.Add(this.label4);
            this.yanGradPnl1.Location = new System.Drawing.Point(20, 20);
            this.yanGradPnl1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.yanGradPnl1.Name = "yanGradPnl1";
            this.yanGradPnl1.Padding = new System.Windows.Forms.Padding(1);
            this.yanGradPnl1.Size = new System.Drawing.Size(220, 105);
            this.yanGradPnl1.TabIndex = 1;
            this.yanGradPnl1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))));
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.nbInHour);
            this.panel6.Controls.Add(this.yanNb1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 73);
            this.panel6.TabIndex = 0;
            // 
            // yanGradPnl2
            // 
            this.yanGradPnl2.Angle = 45F;
            this.yanGradPnl2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(43)))), ((int)(((byte)(114)))));
            this.yanGradPnl2.Controls.Add(this.panel2);
            this.yanGradPnl2.Controls.Add(this.label1);
            this.yanGradPnl2.Location = new System.Drawing.Point(260, 20);
            this.yanGradPnl2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.yanGradPnl2.Name = "yanGradPnl2";
            this.yanGradPnl2.Padding = new System.Windows.Forms.Padding(1);
            this.yanGradPnl2.Size = new System.Drawing.Size(220, 105);
            this.yanGradPnl2.TabIndex = 2;
            this.yanGradPnl2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(44)))), ((int)(((byte)(129)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.yanNb3);
            this.panel2.Controls.Add(this.yanNb4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 73);
            this.panel2.TabIndex = 0;
            // 
            // yanNb3
            // 
            this.yanNb3.BackColor = System.Drawing.Color.White;
            this.yanNb3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanNb3.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanNb3.BorderRadius = 10;
            this.yanNb3.BorderSize = 1;
            this.yanNb3.DecimalPlaces = 0;
            this.yanNb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yanNb3.ForeColor = System.Drawing.Color.DimGray;
            this.yanNb3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yanNb3.Location = new System.Drawing.Point(20, 20);
            this.yanNb3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.yanNb3.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.yanNb3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yanNb3.Name = "yanNb3";
            this.yanNb3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanNb3.Size = new System.Drawing.Size(80, 34);
            this.yanNb3.TabIndex = 1;
            this.yanNb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yanNb3.ThousandsSeparator = true;
            this.tipMain.SetToolTip(this.yanNb3, "Giờ check-out");
            this.yanNb3.UnderlinedStyle = false;
            this.yanNb3.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // yanNb4
            // 
            this.yanNb4.BackColor = System.Drawing.Color.White;
            this.yanNb4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.yanNb4.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.yanNb4.BorderRadius = 10;
            this.yanNb4.BorderSize = 1;
            this.yanNb4.DecimalPlaces = 0;
            this.yanNb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yanNb4.ForeColor = System.Drawing.Color.DimGray;
            this.yanNb4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yanNb4.Location = new System.Drawing.Point(120, 20);
            this.yanNb4.Margin = new System.Windows.Forms.Padding(20);
            this.yanNb4.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.yanNb4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.yanNb4.Name = "yanNb4";
            this.yanNb4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.yanNb4.Size = new System.Drawing.Size(80, 34);
            this.yanNb4.TabIndex = 2;
            this.yanNb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yanNb4.ThousandsSeparator = false;
            this.tipMain.SetToolTip(this.yanNb4, "Phút check-out");
            this.yanNb4.UnderlinedStyle = false;
            this.yanNb4.Value = new decimal(new int[] {
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày thay đổi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yanGradPnl3
            // 
            this.yanGradPnl3.Angle = 45F;
            this.yanGradPnl3.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(42)))), ((int)(((byte)(99)))));
            this.yanGradPnl3.Controls.Add(this.panel4);
            this.yanGradPnl3.Controls.Add(this.label5);
            this.yanGradPnl3.Location = new System.Drawing.Point(20, 145);
            this.yanGradPnl3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.yanGradPnl3.Name = "yanGradPnl3";
            this.yanGradPnl3.Padding = new System.Windows.Forms.Padding(1);
            this.yanGradPnl3.Size = new System.Drawing.Size(460, 321);
            this.yanGradPnl3.TabIndex = 3;
            this.yanGradPnl3.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(134)))));
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
            // panel4
            // 
            this.panel4.Controls.Add(this.yanNb2);
            this.panel4.Controls.Add(this.yanTxt6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.yanTxt1);
            this.panel4.Controls.Add(this.yanTxt2);
            this.panel4.Controls.Add(this.yanTxt3);
            this.panel4.Controls.Add(this.yanTxt4);
            this.panel4.Controls.Add(this.yanTxt5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 289);
            this.panel4.TabIndex = 0;
            // 
            // yanBtn3
            // 
            this.yanBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.yanBtn3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.yanBtn3.BorderRadius = 20;
            this.yanBtn3.BorderSize = 0;
            this.yanBtn3.FlatAppearance.BorderSize = 0;
            this.yanBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yanBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yanBtn3.ForeColor = System.Drawing.Color.White;
            this.yanBtn3.Location = new System.Drawing.Point(230, 485);
            this.yanBtn3.Name = "yanBtn3";
            this.yanBtn3.Size = new System.Drawing.Size(40, 40);
            this.yanBtn3.TabIndex = 0;
            this.yanBtn3.TabStop = false;
            this.tipMain.SetToolTip(this.yanBtn3, "Đóng");
            this.yanBtn3.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginside FYAN Bot GUI";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.yanGradPnl1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.yanGradPnl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.yanGradPnl3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private YANF.Control.YANNb nbInHour;
        private YANF.Control.YANTxt yanTxt1;
        private System.Windows.Forms.ToolTip tipMain;
        private YANF.Control.YANNb yanNb1;
        private YANF.Control.YANBtn yanBtn2;
        private YANF.Control.YANBtn yanBtn1;
        private YANF.Control.YANTxt yanTxt5;
        private YANF.Control.YANTxt yanTxt4;
        private YANF.Control.YANTxt yanTxt3;
        private YANF.Control.YANTxt yanTxt2;
        private YANF.Control.YANNb yanNb2;
        private YANF.Control.YANTxt yanTxt6;
        private YANF.Control.YANGradPnl yanGradPnl1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private YANF.Control.YANGradPnl yanGradPnl2;
        private System.Windows.Forms.Panel panel2;
        private YANF.Control.YANNb yanNb3;
        private YANF.Control.YANNb yanNb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private YANF.Control.YANGradPnl yanGradPnl3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private YANF.Control.YANBtn yanBtn3;
    }
}