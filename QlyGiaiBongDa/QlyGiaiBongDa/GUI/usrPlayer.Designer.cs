namespace QlyGiaiBongDa.GUI
{
    partial class usrPlayer
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaLabel lb_player_id;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrPlayer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.cb_LoaiCT = new Guna.UI.WinForms.GunaComboBox();
            this.cbb_team_name = new Guna.UI.WinForms.GunaComboBox();
            this.tb_thetrang = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.tb_tuoimax = new Guna.UI.WinForms.GunaTextBox();
            this.tb_tuoimin = new Guna.UI.WinForms.GunaTextBox();
            this.tb_tgian = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new Guna.UI.WinForms.GunaButton();
            this.tb_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaCT = new Guna.UI.WinForms.GunaTextBox();
            this.lb_player_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_player_type = new Guna.UI.WinForms.GunaLabel();
            this.lb_player_team = new Guna.UI.WinForms.GunaLabel();
            this.dgv_TCCT = new Guna.UI.WinForms.GunaDataGridView();
            this.MaCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.cb_sobanthang = new System.Windows.Forms.ComboBox();
            lb_player_id = new Guna.UI.WinForms.GunaLabel();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCCT)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_player_id
            // 
            lb_player_id.AutoSize = true;
            lb_player_id.BackColor = System.Drawing.Color.Transparent;
            lb_player_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_player_id.ForeColor = System.Drawing.Color.Black;
            lb_player_id.Location = new System.Drawing.Point(96, 46);
            lb_player_id.Name = "lb_player_id";
            lb_player_id.Size = new System.Drawing.Size(150, 32);
            lb_player_id.TabIndex = 0;
            lb_player_id.Text = "Mã cầu thủ:";
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
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(3, 2);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 74);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Tra cứu cầu thủ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.cb_sobanthang);
            this.gb_HSDB.Controls.Add(this.cb_LoaiCT);
            this.gb_HSDB.Controls.Add(this.cbb_team_name);
            this.gb_HSDB.Controls.Add(this.tb_thetrang);
            this.gb_HSDB.Controls.Add(this.label6);
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.tb_tuoimax);
            this.gb_HSDB.Controls.Add(this.tb_tuoimin);
            this.gb_HSDB.Controls.Add(this.tb_tgian);
            this.gb_HSDB.Controls.Add(this.label5);
            this.gb_HSDB.Controls.Add(this.label4);
            this.gb_HSDB.Controls.Add(this.label3);
            this.gb_HSDB.Controls.Add(this.label2);
            this.gb_HSDB.Controls.Add(this.label1);
            this.gb_HSDB.Controls.Add(this.btn_TimKiem);
            this.gb_HSDB.Controls.Add(this.tb_HoTen);
            this.gb_HSDB.Controls.Add(this.tb_MaCT);
            this.gb_HSDB.Controls.Add(this.lb_player_name);
            this.gb_HSDB.Controls.Add(this.lb_player_type);
            this.gb_HSDB.Controls.Add(this.lb_player_team);
            this.gb_HSDB.Controls.Add(lb_player_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(1, 80);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 256);
            this.gb_HSDB.TabIndex = 2;
            this.gb_HSDB.Text = "Thông tin tìm kiếm";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cb_LoaiCT
            // 
            this.cb_LoaiCT.BackColor = System.Drawing.Color.Transparent;
            this.cb_LoaiCT.BaseColor = System.Drawing.Color.White;
            this.cb_LoaiCT.BorderColor = System.Drawing.Color.Silver;
            this.cb_LoaiCT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LoaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiCT.FocusedColor = System.Drawing.Color.Empty;
            this.cb_LoaiCT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LoaiCT.ForeColor = System.Drawing.Color.Black;
            this.cb_LoaiCT.FormattingEnabled = true;
            this.cb_LoaiCT.Location = new System.Drawing.Point(257, 158);
            this.cb_LoaiCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_LoaiCT.Name = "cb_LoaiCT";
            this.cb_LoaiCT.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_LoaiCT.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_LoaiCT.Size = new System.Drawing.Size(183, 33);
            this.cb_LoaiCT.TabIndex = 26;
            this.cb_LoaiCT.DropDown += new System.EventHandler(this.cb_LoaiCT_DropDown);
            // 
            // cbb_team_name
            // 
            this.cbb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.cbb_team_name.BaseColor = System.Drawing.Color.White;
            this.cbb_team_name.BorderColor = System.Drawing.Color.Silver;
            this.cbb_team_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_team_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_team_name.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_team_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_team_name.ForeColor = System.Drawing.Color.Black;
            this.cbb_team_name.FormattingEnabled = true;
            this.cbb_team_name.Location = new System.Drawing.Point(257, 202);
            this.cbb_team_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_team_name.Name = "cbb_team_name";
            this.cbb_team_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_team_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_team_name.Size = new System.Drawing.Size(183, 32);
            this.cbb_team_name.TabIndex = 25;
            this.cbb_team_name.DropDown += new System.EventHandler(this.cbb_team_name_DropDown);
            // 
            // tb_thetrang
            // 
            this.tb_thetrang.BaseColor = System.Drawing.Color.White;
            this.tb_thetrang.BorderColor = System.Drawing.Color.Silver;
            this.tb_thetrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_thetrang.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_thetrang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_thetrang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_thetrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_thetrang.ForeColor = System.Drawing.Color.Black;
            this.tb_thetrang.Location = new System.Drawing.Point(768, 202);
            this.tb_thetrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_thetrang.Name = "tb_thetrang";
            this.tb_thetrang.PasswordChar = '\0';
            this.tb_thetrang.SelectedText = "";
            this.tb_thetrang.Size = new System.Drawing.Size(155, 37);
            this.tb_thetrang.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(596, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thể trạng: ";
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(1116, 32);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(118, 28);
            this.lb_Guide.TabIndex = 22;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
            // 
            // tb_tuoimax
            // 
            this.tb_tuoimax.BaseColor = System.Drawing.Color.White;
            this.tb_tuoimax.BorderColor = System.Drawing.Color.Silver;
            this.tb_tuoimax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tuoimax.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tuoimax.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tuoimax.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tuoimax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tuoimax.ForeColor = System.Drawing.Color.Black;
            this.tb_tuoimax.Location = new System.Drawing.Point(924, 46);
            this.tb_tuoimax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tuoimax.Name = "tb_tuoimax";
            this.tb_tuoimax.PasswordChar = '\0';
            this.tb_tuoimax.SelectedText = "";
            this.tb_tuoimax.Size = new System.Drawing.Size(49, 37);
            this.tb_tuoimax.TabIndex = 21;
            this.tb_tuoimax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tuoimax_KeyPress);
            // 
            // tb_tuoimin
            // 
            this.tb_tuoimin.BaseColor = System.Drawing.Color.White;
            this.tb_tuoimin.BorderColor = System.Drawing.Color.Silver;
            this.tb_tuoimin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tuoimin.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tuoimin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tuoimin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tuoimin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tuoimin.ForeColor = System.Drawing.Color.Black;
            this.tb_tuoimin.Location = new System.Drawing.Point(768, 46);
            this.tb_tuoimin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tuoimin.Name = "tb_tuoimin";
            this.tb_tuoimin.PasswordChar = '\0';
            this.tb_tuoimin.SelectedText = "";
            this.tb_tuoimin.Size = new System.Drawing.Size(49, 37);
            this.tb_tuoimin.TabIndex = 20;
            this.tb_tuoimin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tuoimin_KeyPress);
            // 
            // tb_tgian
            // 
            this.tb_tgian.BaseColor = System.Drawing.Color.Gainsboro;
            this.tb_tgian.BorderColor = System.Drawing.Color.Silver;
            this.tb_tgian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tgian.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tgian.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tgian.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tgian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tgian.ForeColor = System.Drawing.Color.Black;
            this.tb_tgian.Location = new System.Drawing.Point(819, 153);
            this.tb_tgian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tgian.Name = "tb_tgian";
            this.tb_tgian.PasswordChar = '\0';
            this.tb_tgian.SelectedText = "";
            this.tb_tgian.Size = new System.Drawing.Size(155, 37);
            this.tb_tgian.TabIndex = 18;
            this.tb_tgian.Text = "<Thi Dau ? nam>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(841, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(703, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(596, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời gian thi đấu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(596, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số bàn thắng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(596, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Độ tuổi";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem.AnimationSpeed = 0.03F;
            this.btn_TimKiem.BaseColor = System.Drawing.Color.Teal;
            this.btn_TimKiem.BorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_TimKiem.Location = new System.Drawing.Point(1055, 204);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.OnHoverImage = null;
            this.btn_TimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Size = new System.Drawing.Size(179, 42);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.BaseColor = System.Drawing.Color.White;
            this.tb_HoTen.BorderColor = System.Drawing.Color.Silver;
            this.tb_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_HoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_HoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_HoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.ForeColor = System.Drawing.Color.Black;
            this.tb_HoTen.Location = new System.Drawing.Point(257, 98);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.PasswordChar = '\0';
            this.tb_HoTen.SelectedText = "";
            this.tb_HoTen.Size = new System.Drawing.Size(183, 37);
            this.tb_HoTen.TabIndex = 5;
            // 
            // tb_MaCT
            // 
            this.tb_MaCT.BaseColor = System.Drawing.Color.White;
            this.tb_MaCT.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaCT.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaCT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaCT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_MaCT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaCT.ForeColor = System.Drawing.Color.Black;
            this.tb_MaCT.Location = new System.Drawing.Point(257, 46);
            this.tb_MaCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaCT.Name = "tb_MaCT";
            this.tb_MaCT.PasswordChar = '\0';
            this.tb_MaCT.SelectedText = "";
            this.tb_MaCT.Size = new System.Drawing.Size(183, 37);
            this.tb_MaCT.TabIndex = 4;
            // 
            // lb_player_name
            // 
            this.lb_player_name.AutoSize = true;
            this.lb_player_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_name.ForeColor = System.Drawing.Color.Black;
            this.lb_player_name.Location = new System.Drawing.Point(96, 98);
            this.lb_player_name.Name = "lb_player_name";
            this.lb_player_name.Size = new System.Drawing.Size(132, 32);
            this.lb_player_name.TabIndex = 3;
            this.lb_player_name.Text = "Họ và tên:";
            // 
            // lb_player_type
            // 
            this.lb_player_type.AutoSize = true;
            this.lb_player_type.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_type.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_type.ForeColor = System.Drawing.Color.Black;
            this.lb_player_type.Location = new System.Drawing.Point(96, 153);
            this.lb_player_type.Name = "lb_player_type";
            this.lb_player_type.Size = new System.Drawing.Size(161, 32);
            this.lb_player_type.TabIndex = 2;
            this.lb_player_type.Text = "Loại cầu thủ:";
            // 
            // lb_player_team
            // 
            this.lb_player_team.AutoSize = true;
            this.lb_player_team.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_team.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_team.ForeColor = System.Drawing.Color.Black;
            this.lb_player_team.Location = new System.Drawing.Point(96, 204);
            this.lb_player_team.Name = "lb_player_team";
            this.lb_player_team.Size = new System.Drawing.Size(129, 32);
            this.lb_player_team.TabIndex = 1;
            this.lb_player_team.Text = "Đội bóng:";
            // 
            // dgv_TCCT
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgv_TCCT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_TCCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TCCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TCCT.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_TCCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TCCT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TCCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_TCCT.ColumnHeadersHeight = 30;
            this.dgv_TCCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauThu,
            this.TenCauThu,
            this.LoaiCauThu,
            this.ThoiGianThiDau,
            this.TenDoi});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TCCT.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_TCCT.EnableHeadersVisualStyles = false;
            this.dgv_TCCT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.Location = new System.Drawing.Point(3, 340);
            this.dgv_TCCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TCCT.Name = "dgv_TCCT";
            this.dgv_TCCT.RowHeadersVisible = false;
            this.dgv_TCCT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_TCCT.RowTemplate.Height = 24;
            this.dgv_TCCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TCCT.Size = new System.Drawing.Size(1249, 309);
            this.dgv_TCCT.TabIndex = 3;
            this.dgv_TCCT.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_TCCT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TCCT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TCCT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TCCT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TCCT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TCCT.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgv_TCCT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TCCT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_TCCT.ThemeStyle.ReadOnly = false;
            this.dgv_TCCT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TCCT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TCCT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TCCT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TCCT.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_TCCT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaCauThu
            // 
            this.MaCauThu.DataPropertyName = "MaCauThu";
            this.MaCauThu.HeaderText = "Mã Cầu Thủ";
            this.MaCauThu.Name = "MaCauThu";
            // 
            // TenCauThu
            // 
            this.TenCauThu.DataPropertyName = "TenCauThu";
            this.TenCauThu.HeaderText = "Tên Cầu Thủ";
            this.TenCauThu.Name = "TenCauThu";
            // 
            // LoaiCauThu
            // 
            this.LoaiCauThu.DataPropertyName = "LoaiCauThu";
            this.LoaiCauThu.HeaderText = "Loại Cầu Thủ";
            this.LoaiCauThu.Name = "LoaiCauThu";
            // 
            // ThoiGianThiDau
            // 
            this.ThoiGianThiDau.DataPropertyName = "ThoiGianThiDau";
            this.ThoiGianThiDau.HeaderText = "Thời gian thi đấu";
            this.ThoiGianThiDau.Name = "ThoiGianThiDau";
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.HeaderText = "Tên Đội";
            this.TenDoi.Name = "TenDoi";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // cb_sobanthang
            // 
            this.cb_sobanthang.DropDownHeight = 100;
            this.cb_sobanthang.FormattingEnabled = true;
            this.cb_sobanthang.IntegralHeight = false;
            this.cb_sobanthang.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cb_sobanthang.Location = new System.Drawing.Point(768, 99);
            this.cb_sobanthang.MaxDropDownItems = 5;
            this.cb_sobanthang.Name = "cb_sobanthang";
            this.cb_sobanthang.Size = new System.Drawing.Size(72, 36);
            this.cb_sobanthang.TabIndex = 28;
            // 
            // usrPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_TCCT);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usrPlayer";
            this.Size = new System.Drawing.Size(1253, 697);
            this.Load += new System.EventHandler(this.usrPlayer_Load_1);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaButton btn_TimKiem;
        private Guna.UI.WinForms.GunaLabel lb_player_name;
        private Guna.UI.WinForms.GunaLabel lb_player_type;
        private Guna.UI.WinForms.GunaLabel lb_player_team;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox tb_HoTen;
        public Guna.UI.WinForms.GunaTextBox tb_MaCT;
        public Guna.UI.WinForms.GunaTextBox tb_tgian;
        public Guna.UI.WinForms.GunaTextBox tb_tuoimax;
        public Guna.UI.WinForms.GunaTextBox tb_tuoimin;
        public Guna.UI.WinForms.GunaDataGridView dgv_TCCT;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        public Guna.UI.WinForms.GunaTextBox tb_thetrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianThiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        public Guna.UI.WinForms.GunaComboBox cbb_team_name;
        public Guna.UI.WinForms.GunaComboBox cb_LoaiCT;
        public System.Windows.Forms.ComboBox cb_sobanthang;
    }
}
