﻿namespace QlyGiaiBongDa.GUI
{
    partial class usrRulesChange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrRulesChange));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.tb_RC_countForeign = new MetroFramework.Controls.MetroTextBox();
            this.nm_formax = new Guna.UI.WinForms.GunaNumeric();
            this.nm_slgmax = new Guna.UI.WinForms.GunaNumeric();
            this.nm_slgmin = new Guna.UI.WinForms.GunaNumeric();
            this.nm_tuoimin = new Guna.UI.WinForms.GunaNumeric();
            this.nm_tuoimax = new Guna.UI.WinForms.GunaNumeric();
            this.btt_RC_Default = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btt_RC_Done_1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_Reload = new Guna.UI.WinForms.GunaButton();
            this.tb_LoaiBan = new Guna.UI.WinForms.GunaTextBox();
            this.btn_XoaBan = new Guna.UI.WinForms.GunaButton();
            this.btn_ThemBan = new Guna.UI.WinForms.GunaButton();
            this.dgv_LoaiBanThang = new Guna.UI.WinForms.GunaDataGridView();
            this.LoaiBanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_maxtimescore = new Guna.UI.WinForms.GunaNumeric();
            this.btt_RC_Done_2 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gb_HSDB.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiBanThang)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Teal;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaButton1.Location = new System.Drawing.Point(3, 0);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 74);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Thay đổi quy định";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.tb_RC_countForeign);
            this.gb_HSDB.Controls.Add(this.nm_formax);
            this.gb_HSDB.Controls.Add(this.nm_slgmax);
            this.gb_HSDB.Controls.Add(this.nm_slgmin);
            this.gb_HSDB.Controls.Add(this.nm_tuoimin);
            this.gb_HSDB.Controls.Add(this.nm_tuoimax);
            this.gb_HSDB.Controls.Add(this.btt_RC_Default);
            this.gb_HSDB.Controls.Add(this.gunaLabel10);
            this.gb_HSDB.Controls.Add(this.gunaLabel9);
            this.gb_HSDB.Controls.Add(this.gunaLabel8);
            this.gb_HSDB.Controls.Add(this.gunaLabel7);
            this.gb_HSDB.Controls.Add(this.gunaLabel6);
            this.gb_HSDB.Controls.Add(this.btt_RC_Done_1);
            this.gb_HSDB.Controls.Add(this.gunaLabel4);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 80);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 236);
            this.gb_HSDB.TabIndex = 3;
            this.gb_HSDB.Text = "Quy định tiếp nhận hồ sơ đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(1099, 37);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(118, 28);
            this.lb_Guide.TabIndex = 45;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
            // 
            // tb_RC_countForeign
            // 
            this.tb_RC_countForeign.Location = new System.Drawing.Point(3, 252);
            this.tb_RC_countForeign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_RC_countForeign.Name = "tb_RC_countForeign";
            this.tb_RC_countForeign.Size = new System.Drawing.Size(11, 23);
            this.tb_RC_countForeign.TabIndex = 44;
            this.tb_RC_countForeign.Text = "metroTextBox1";
            this.tb_RC_countForeign.Visible = false;
            // 
            // nm_formax
            // 
            this.nm_formax.BaseColor = System.Drawing.Color.White;
            this.nm_formax.BorderColor = System.Drawing.Color.Silver;
            this.nm_formax.ButtonColor = System.Drawing.Color.Teal;
            this.nm_formax.ButtonForeColor = System.Drawing.Color.White;
            this.nm_formax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_formax.ForeColor = System.Drawing.Color.Black;
            this.nm_formax.Location = new System.Drawing.Point(731, 165);
            this.nm_formax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_formax.Maximum = ((long)(9999999));
            this.nm_formax.Minimum = ((long)(5));
            this.nm_formax.Name = "nm_formax";
            this.nm_formax.Size = new System.Drawing.Size(72, 30);
            this.nm_formax.TabIndex = 40;
            this.nm_formax.Text = "gunaNumeric5";
            this.nm_formax.Value = ((long)(5));
            // 
            // nm_slgmax
            // 
            this.nm_slgmax.BaseColor = System.Drawing.Color.White;
            this.nm_slgmax.BorderColor = System.Drawing.Color.Silver;
            this.nm_slgmax.ButtonColor = System.Drawing.Color.Teal;
            this.nm_slgmax.ButtonForeColor = System.Drawing.Color.White;
            this.nm_slgmax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_slgmax.ForeColor = System.Drawing.Color.Black;
            this.nm_slgmax.Location = new System.Drawing.Point(821, 110);
            this.nm_slgmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_slgmax.Maximum = ((long)(9999999));
            this.nm_slgmax.Minimum = ((long)(15));
            this.nm_slgmax.Name = "nm_slgmax";
            this.nm_slgmax.Size = new System.Drawing.Size(75, 30);
            this.nm_slgmax.TabIndex = 39;
            this.nm_slgmax.Text = "gunaNumeric4";
            this.nm_slgmax.Value = ((long)(15));
            // 
            // nm_slgmin
            // 
            this.nm_slgmin.BaseColor = System.Drawing.Color.White;
            this.nm_slgmin.BorderColor = System.Drawing.Color.Silver;
            this.nm_slgmin.ButtonColor = System.Drawing.Color.Teal;
            this.nm_slgmin.ButtonForeColor = System.Drawing.Color.White;
            this.nm_slgmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_slgmin.ForeColor = System.Drawing.Color.Black;
            this.nm_slgmin.Location = new System.Drawing.Point(648, 110);
            this.nm_slgmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_slgmin.Maximum = ((long)(9999999));
            this.nm_slgmin.Minimum = ((long)(11));
            this.nm_slgmin.Name = "nm_slgmin";
            this.nm_slgmin.Size = new System.Drawing.Size(72, 30);
            this.nm_slgmin.TabIndex = 38;
            this.nm_slgmin.Text = "gunaNumeric3";
            this.nm_slgmin.Value = ((long)(11));
            // 
            // nm_tuoimin
            // 
            this.nm_tuoimin.BaseColor = System.Drawing.Color.White;
            this.nm_tuoimin.BorderColor = System.Drawing.Color.Silver;
            this.nm_tuoimin.ButtonColor = System.Drawing.Color.Teal;
            this.nm_tuoimin.ButtonForeColor = System.Drawing.Color.White;
            this.nm_tuoimin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_tuoimin.ForeColor = System.Drawing.Color.Black;
            this.nm_tuoimin.Location = new System.Drawing.Point(648, 54);
            this.nm_tuoimin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_tuoimin.Maximum = ((long)(9999999));
            this.nm_tuoimin.Minimum = ((long)(16));
            this.nm_tuoimin.Name = "nm_tuoimin";
            this.nm_tuoimin.Size = new System.Drawing.Size(72, 30);
            this.nm_tuoimin.TabIndex = 36;
            this.nm_tuoimin.Text = "gunaNumeric1";
            this.nm_tuoimin.Value = ((long)(16));
            // 
            // nm_tuoimax
            // 
            this.nm_tuoimax.BaseColor = System.Drawing.Color.White;
            this.nm_tuoimax.BorderColor = System.Drawing.Color.Silver;
            this.nm_tuoimax.ButtonColor = System.Drawing.Color.Teal;
            this.nm_tuoimax.ButtonForeColor = System.Drawing.Color.White;
            this.nm_tuoimax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_tuoimax.ForeColor = System.Drawing.Color.Black;
            this.nm_tuoimax.Location = new System.Drawing.Point(821, 54);
            this.nm_tuoimax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_tuoimax.Maximum = ((long)(9999999));
            this.nm_tuoimax.Minimum = ((long)(40));
            this.nm_tuoimax.Name = "nm_tuoimax";
            this.nm_tuoimax.Size = new System.Drawing.Size(75, 30);
            this.nm_tuoimax.TabIndex = 37;
            this.nm_tuoimax.Text = "gunaNumeric2";
            this.nm_tuoimax.Value = ((long)(40));
            // 
            // btt_RC_Default
            // 
            this.btt_RC_Default.AnimationHoverSpeed = 0.07F;
            this.btt_RC_Default.AnimationSpeed = 0.03F;
            this.btt_RC_Default.BaseColor = System.Drawing.Color.Teal;
            this.btt_RC_Default.BorderColor = System.Drawing.Color.Black;
            this.btt_RC_Default.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_RC_Default.FocusedColor = System.Drawing.Color.Empty;
            this.btt_RC_Default.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_RC_Default.ForeColor = System.Drawing.Color.Black;
            this.btt_RC_Default.Image = ((System.Drawing.Image)(resources.GetObject("btt_RC_Default.Image")));
            this.btt_RC_Default.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_RC_Default.Location = new System.Drawing.Point(1045, 126);
            this.btt_RC_Default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_RC_Default.Name = "btt_RC_Default";
            this.btt_RC_Default.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_RC_Default.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_RC_Default.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_RC_Default.OnHoverImage = null;
            this.btt_RC_Default.OnPressedColor = System.Drawing.Color.Black;
            this.btt_RC_Default.Size = new System.Drawing.Size(179, 42);
            this.btt_RC_Default.TabIndex = 32;
            this.btt_RC_Default.Text = "Mặc định";
            this.btt_RC_Default.Click += new System.EventHandler(this.btt_RC_Default_Click);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(735, 52);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(58, 32);
            this.gunaLabel10.TabIndex = 31;
            this.gunaLabel10.Text = "đến";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(735, 108);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(58, 32);
            this.gunaLabel9.TabIndex = 30;
            this.gunaLabel9.Text = "đến";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(587, 108);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(40, 32);
            this.gunaLabel8.TabIndex = 29;
            this.gunaLabel8.Text = "từ";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(587, 54);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(40, 32);
            this.gunaLabel7.TabIndex = 28;
            this.gunaLabel7.Text = "từ";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(360, 165);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(345, 32);
            this.gunaLabel6.TabIndex = 22;
            this.gunaLabel6.Text = "Số cầu thủ nước ngoài tối đa";
            // 
            // btt_RC_Done_1
            // 
            this.btt_RC_Done_1.AnimationHoverSpeed = 0.07F;
            this.btt_RC_Done_1.AnimationSpeed = 0.03F;
            this.btt_RC_Done_1.BaseColor = System.Drawing.Color.Teal;
            this.btt_RC_Done_1.BorderColor = System.Drawing.Color.Black;
            this.btt_RC_Done_1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_RC_Done_1.FocusedColor = System.Drawing.Color.Empty;
            this.btt_RC_Done_1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_RC_Done_1.ForeColor = System.Drawing.Color.Black;
            this.btt_RC_Done_1.Image = ((System.Drawing.Image)(resources.GetObject("btt_RC_Done_1.Image")));
            this.btt_RC_Done_1.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_RC_Done_1.Location = new System.Drawing.Point(1045, 180);
            this.btt_RC_Done_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_RC_Done_1.Name = "btt_RC_Done_1";
            this.btt_RC_Done_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_RC_Done_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_RC_Done_1.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_RC_Done_1.OnHoverImage = null;
            this.btt_RC_Done_1.OnPressedColor = System.Drawing.Color.Black;
            this.btt_RC_Done_1.Size = new System.Drawing.Size(179, 42);
            this.btt_RC_Done_1.TabIndex = 20;
            this.btt_RC_Done_1.Text = "Hoàn tất";
            this.btt_RC_Done_1.Click += new System.EventHandler(this.btt_RC_Done_1_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(360, 110);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(210, 32);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Số lượng cầu thủ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(360, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(193, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Độ tuổi cầu thủ";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btn_Reload);
            this.gunaGroupBox1.Controls.Add(this.tb_LoaiBan);
            this.gunaGroupBox1.Controls.Add(this.btn_XoaBan);
            this.gunaGroupBox1.Controls.Add(this.btn_ThemBan);
            this.gunaGroupBox1.Controls.Add(this.dgv_LoaiBanThang);
            this.gunaGroupBox1.Controls.Add(this.nm_maxtimescore);
            this.gunaGroupBox1.Controls.Add(this.btt_RC_Done_2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 320);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1248, 357);
            this.gunaGroupBox1.TabIndex = 4;
            this.gunaGroupBox1.Text = "Quy định bàn thắng-Xếp hạng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reload.AnimationHoverSpeed = 0.07F;
            this.btn_Reload.AnimationSpeed = 0.03F;
            this.btn_Reload.BaseColor = System.Drawing.Color.Teal;
            this.btn_Reload.BorderColor = System.Drawing.Color.Black;
            this.btn_Reload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Reload.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Reload.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.Color.Black;
            this.btn_Reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reload.Image")));
            this.btn_Reload.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Reload.Location = new System.Drawing.Point(740, 303);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Reload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Reload.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Reload.OnHoverImage = null;
            this.btn_Reload.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Reload.Size = new System.Drawing.Size(51, 39);
            this.btn_Reload.TabIndex = 49;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // tb_LoaiBan
            // 
            this.tb_LoaiBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LoaiBan.BaseColor = System.Drawing.Color.White;
            this.tb_LoaiBan.BorderColor = System.Drawing.Color.Silver;
            this.tb_LoaiBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LoaiBan.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_LoaiBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_LoaiBan.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_LoaiBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LoaiBan.ForeColor = System.Drawing.Color.Black;
            this.tb_LoaiBan.Location = new System.Drawing.Point(455, 120);
            this.tb_LoaiBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LoaiBan.Name = "tb_LoaiBan";
            this.tb_LoaiBan.PasswordChar = '\0';
            this.tb_LoaiBan.SelectedText = "";
            this.tb_LoaiBan.Size = new System.Drawing.Size(199, 48);
            this.tb_LoaiBan.TabIndex = 48;
            this.tb_LoaiBan.Text = "Loại bàn thắng";
            // 
            // btn_XoaBan
            // 
            this.btn_XoaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XoaBan.AnimationHoverSpeed = 0.07F;
            this.btn_XoaBan.AnimationSpeed = 0.03F;
            this.btn_XoaBan.BaseColor = System.Drawing.Color.Teal;
            this.btn_XoaBan.BorderColor = System.Drawing.Color.Black;
            this.btn_XoaBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_XoaBan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_XoaBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaBan.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaBan.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaBan.Image")));
            this.btn_XoaBan.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_XoaBan.Location = new System.Drawing.Point(740, 258);
            this.btn_XoaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaBan.Name = "btn_XoaBan";
            this.btn_XoaBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XoaBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XoaBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XoaBan.OnHoverImage = null;
            this.btn_XoaBan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XoaBan.Size = new System.Drawing.Size(51, 43);
            this.btn_XoaBan.TabIndex = 47;
            this.btn_XoaBan.Click += new System.EventHandler(this.btn_XoaBan_Click);
            // 
            // btn_ThemBan
            // 
            this.btn_ThemBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemBan.AnimationHoverSpeed = 0.07F;
            this.btn_ThemBan.AnimationSpeed = 0.03F;
            this.btn_ThemBan.BaseColor = System.Drawing.Color.Teal;
            this.btn_ThemBan.BorderColor = System.Drawing.Color.Black;
            this.btn_ThemBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ThemBan.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ThemBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemBan.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemBan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemBan.Image")));
            this.btn_ThemBan.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_ThemBan.Location = new System.Drawing.Point(740, 215);
            this.btn_ThemBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemBan.Name = "btn_ThemBan";
            this.btn_ThemBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ThemBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ThemBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ThemBan.OnHoverImage = null;
            this.btn_ThemBan.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ThemBan.Size = new System.Drawing.Size(51, 39);
            this.btn_ThemBan.TabIndex = 46;
            this.btn_ThemBan.Click += new System.EventHandler(this.btn_ThemBan_Click);
            // 
            // dgv_LoaiBanThang
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LoaiBanThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LoaiBanThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiBanThang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_LoaiBanThang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiBanThang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_LoaiBanThang.ColumnHeadersHeight = 26;
            this.dgv_LoaiBanThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiBanThang});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LoaiBanThang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_LoaiBanThang.EnableHeadersVisualStyles = false;
            this.dgv_LoaiBanThang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiBanThang.Location = new System.Drawing.Point(397, 214);
            this.dgv_LoaiBanThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiBanThang.Name = "dgv_LoaiBanThang";
            this.dgv_LoaiBanThang.RowHeadersVisible = false;
            this.dgv_LoaiBanThang.RowTemplate.Height = 24;
            this.dgv_LoaiBanThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiBanThang.Size = new System.Drawing.Size(323, 132);
            this.dgv_LoaiBanThang.TabIndex = 45;
            this.dgv_LoaiBanThang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_LoaiBanThang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_LoaiBanThang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiBanThang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_LoaiBanThang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiBanThang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_LoaiBanThang.ThemeStyle.HeaderStyle.Height = 26;
            this.dgv_LoaiBanThang.ThemeStyle.ReadOnly = false;
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiBanThang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_LoaiBanThang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiBanThang_CellContentClick);
            // 
            // LoaiBanThang
            // 
            this.LoaiBanThang.DataPropertyName = "LoaiBanThang";
            this.LoaiBanThang.HeaderText = "Loại Bàn Thắng";
            this.LoaiBanThang.Name = "LoaiBanThang";
            // 
            // nm_maxtimescore
            // 
            this.nm_maxtimescore.BaseColor = System.Drawing.Color.White;
            this.nm_maxtimescore.BorderColor = System.Drawing.Color.Silver;
            this.nm_maxtimescore.ButtonColor = System.Drawing.Color.Teal;
            this.nm_maxtimescore.ButtonForeColor = System.Drawing.Color.White;
            this.nm_maxtimescore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_maxtimescore.ForeColor = System.Drawing.Color.Black;
            this.nm_maxtimescore.Location = new System.Drawing.Point(731, 41);
            this.nm_maxtimescore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nm_maxtimescore.Maximum = ((long)(9999999));
            this.nm_maxtimescore.Minimum = ((long)(90));
            this.nm_maxtimescore.Name = "nm_maxtimescore";
            this.nm_maxtimescore.Size = new System.Drawing.Size(77, 30);
            this.nm_maxtimescore.TabIndex = 41;
            this.nm_maxtimescore.Text = "gunaNumeric6";
            this.nm_maxtimescore.Value = ((long)(90));
            // 
            // btt_RC_Done_2
            // 
            this.btt_RC_Done_2.AnimationHoverSpeed = 0.07F;
            this.btt_RC_Done_2.AnimationSpeed = 0.03F;
            this.btt_RC_Done_2.BaseColor = System.Drawing.Color.Teal;
            this.btt_RC_Done_2.BorderColor = System.Drawing.Color.Black;
            this.btt_RC_Done_2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_RC_Done_2.FocusedColor = System.Drawing.Color.Empty;
            this.btt_RC_Done_2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_RC_Done_2.ForeColor = System.Drawing.Color.Black;
            this.btt_RC_Done_2.Image = ((System.Drawing.Image)(resources.GetObject("btt_RC_Done_2.Image")));
            this.btt_RC_Done_2.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_RC_Done_2.Location = new System.Drawing.Point(1045, 304);
            this.btt_RC_Done_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_RC_Done_2.Name = "btt_RC_Done_2";
            this.btt_RC_Done_2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_RC_Done_2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_RC_Done_2.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_RC_Done_2.OnHoverImage = null;
            this.btt_RC_Done_2.OnPressedColor = System.Drawing.Color.Black;
            this.btt_RC_Done_2.Size = new System.Drawing.Size(179, 42);
            this.btt_RC_Done_2.TabIndex = 20;
            this.btt_RC_Done_2.Text = "Hoàn tất";
            this.btt_RC_Done_2.Click += new System.EventHandler(this.btt_RC_Done_2_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(400, 179);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(304, 32);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Danh sách loại bàn thắng";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(391, 41);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(295, 32);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Thời điểm ghi bàn tối đa";
            // 
            // usrRulesChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usrRulesChange";
            this.Size = new System.Drawing.Size(1253, 679);
            this.Load += new System.EventHandler(this.usrRulesChange_Load_1);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiBanThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaButton btt_RC_Done_1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaButton btt_RC_Done_2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton btt_RC_Default;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaNumeric nm_formax;
        public Guna.UI.WinForms.GunaNumeric nm_slgmax;
        public Guna.UI.WinForms.GunaNumeric nm_slgmin;
        public Guna.UI.WinForms.GunaNumeric nm_tuoimin;
        public Guna.UI.WinForms.GunaNumeric nm_tuoimax;
        public Guna.UI.WinForms.GunaNumeric nm_maxtimescore;
        public MetroFramework.Controls.MetroTextBox tb_RC_countForeign;
        private Guna.UI.WinForms.GunaButton btn_XoaBan;
        private Guna.UI.WinForms.GunaButton btn_ThemBan;
        public Guna.UI.WinForms.GunaDataGridView dgv_LoaiBanThang;
        public Guna.UI.WinForms.GunaTextBox tb_LoaiBan;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBanThang;
        public Guna.UI.WinForms.GunaButton btn_Reload;
    }
}
