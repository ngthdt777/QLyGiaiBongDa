namespace QlyGiaiBongDa.GUI
{
    partial class usrTeamList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrTeamList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_hsdb = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.tb_hsdb_thetrang = new Guna.UI.WinForms.GunaTextBox();
            this.lb_hsdb_thetrang = new Guna.UI.WinForms.GunaLabel();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.lb_hsdb_sctnq = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_soctngoaiquoc = new Guna.UI.WinForms.GunaLabel();
            this.cb_hsdb_loaict = new Guna.UI.WinForms.GunaComboBox();
            this.dtp_cauthu_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.btt_back = new Guna.UI.WinForms.GunaButton();
            this.cbb_team_name = new Guna.UI.WinForms.GunaComboBox();
            this.tb_hsdb_tgiantd = new Guna.UI.WinForms.GunaTextBox();
            this.lb_hsdb_tgiantd = new Guna.UI.WinForms.GunaLabel();
            this.tb_hsdb_tenct = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hsdb_mact = new Guna.UI.WinForms.GunaTextBox();
            this.lb_hsdb_loaict = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_ngsinh = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_Tenct = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_mact = new Guna.UI.WinForms.GunaLabel();
            this.btt_Team_View = new Guna.UI.WinForms.GunaButton();
            this.tb_MaDoi = new Guna.UI.WinForms.GunaTextBox();
            this.lb_team_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_id = new Guna.UI.WinForms.GunaLabel();
            this.dgv_HSDB = new Guna.UI.WinForms.GunaDataGridView();
            this.MaCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btt_xoa = new Guna.UI.WinForms.GunaButton();
            this.btt_Them = new Guna.UI.WinForms.GunaButton();
            this.Btt_sua = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_hsdb
            // 
            this.lb_hsdb.AnimationHoverSpeed = 0.07F;
            this.lb_hsdb.AnimationSpeed = 0.03F;
            this.lb_hsdb.BaseColor = System.Drawing.Color.Teal;
            this.lb_hsdb.BorderColor = System.Drawing.Color.Black;
            this.lb_hsdb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lb_hsdb.FocusedColor = System.Drawing.Color.Empty;
            this.lb_hsdb.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb.ForeColor = System.Drawing.Color.White;
            this.lb_hsdb.Image = ((System.Drawing.Image)(resources.GetObject("lb_hsdb.Image")));
            this.lb_hsdb.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_hsdb.ImageSize = new System.Drawing.Size(40, 40);
            this.lb_hsdb.Location = new System.Drawing.Point(2, 0);
            this.lb_hsdb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_hsdb.Name = "lb_hsdb";
            this.lb_hsdb.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.lb_hsdb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lb_hsdb.OnHoverForeColor = System.Drawing.Color.White;
            this.lb_hsdb.OnHoverImage = null;
            this.lb_hsdb.OnPressedColor = System.Drawing.Color.Black;
            this.lb_hsdb.Size = new System.Drawing.Size(936, 61);
            this.lb_hsdb.TabIndex = 0;
            this.lb_hsdb.Text = "Hồ sơ đội bóng";
            this.lb_hsdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.tb_hsdb_thetrang);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_thetrang);
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_sctnq);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_soctngoaiquoc);
            this.gb_HSDB.Controls.Add(this.cb_hsdb_loaict);
            this.gb_HSDB.Controls.Add(this.dtp_cauthu_ngsinh);
            this.gb_HSDB.Controls.Add(this.btt_back);
            this.gb_HSDB.Controls.Add(this.cbb_team_name);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_tgiantd);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_tgiantd);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_tenct);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_mact);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_loaict);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_ngsinh);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_Tenct);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_mact);
            this.gb_HSDB.Controls.Add(this.btt_Team_View);
            this.gb_HSDB.Controls.Add(this.tb_MaDoi);
            this.gb_HSDB.Controls.Add(this.lb_team_name);
            this.gb_HSDB.Controls.Add(this.lb_team_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(2, 66);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(936, 225);
            this.gb_HSDB.TabIndex = 1;
            this.gb_HSDB.Text = "Thông tin đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // tb_hsdb_thetrang
            // 
            this.tb_hsdb_thetrang.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_thetrang.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_thetrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_thetrang.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_thetrang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_thetrang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hsdb_thetrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hsdb_thetrang.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_thetrang.Location = new System.Drawing.Point(586, 184);
            this.tb_hsdb_thetrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_hsdb_thetrang.Name = "tb_hsdb_thetrang";
            this.tb_hsdb_thetrang.PasswordChar = '\0';
            this.tb_hsdb_thetrang.SelectedText = "";
            this.tb_hsdb_thetrang.Size = new System.Drawing.Size(120, 26);
            this.tb_hsdb_thetrang.TabIndex = 26;
            this.tb_hsdb_thetrang.Visible = false;
            // 
            // lb_hsdb_thetrang
            // 
            this.lb_hsdb_thetrang.AutoSize = true;
            this.lb_hsdb_thetrang.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_thetrang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_thetrang.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_thetrang.Location = new System.Drawing.Point(464, 184);
            this.lb_hsdb_thetrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_thetrang.Name = "lb_hsdb_thetrang";
            this.lb_hsdb_thetrang.Size = new System.Drawing.Size(103, 25);
            this.lb_hsdb_thetrang.TabIndex = 25;
            this.lb_hsdb_thetrang.Text = "Thể trạng:";
            this.lb_hsdb_thetrang.Visible = false;
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(838, 30);
            this.lb_Guide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(96, 21);
            this.lb_Guide.TabIndex = 24;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
            // 
            // lb_hsdb_sctnq
            // 
            this.lb_hsdb_sctnq.AutoSize = true;
            this.lb_hsdb_sctnq.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_sctnq.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_sctnq.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_sctnq.Location = new System.Drawing.Point(334, 184);
            this.lb_hsdb_sctnq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_sctnq.Name = "lb_hsdb_sctnq";
            this.lb_hsdb_sctnq.Size = new System.Drawing.Size(0, 25);
            this.lb_hsdb_sctnq.TabIndex = 23;
            this.lb_hsdb_sctnq.Visible = false;
            // 
            // lb_hsdb_soctngoaiquoc
            // 
            this.lb_hsdb_soctngoaiquoc.AutoSize = true;
            this.lb_hsdb_soctngoaiquoc.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_soctngoaiquoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_soctngoaiquoc.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_soctngoaiquoc.Location = new System.Drawing.Point(128, 184);
            this.lb_hsdb_soctngoaiquoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_soctngoaiquoc.Name = "lb_hsdb_soctngoaiquoc";
            this.lb_hsdb_soctngoaiquoc.Size = new System.Drawing.Size(217, 25);
            this.lb_hsdb_soctngoaiquoc.TabIndex = 22;
            this.lb_hsdb_soctngoaiquoc.Text = "Số cầu thủ ngoại quốc:";
            this.lb_hsdb_soctngoaiquoc.Visible = false;
            // 
            // cb_hsdb_loaict
            // 
            this.cb_hsdb_loaict.BackColor = System.Drawing.Color.Transparent;
            this.cb_hsdb_loaict.BaseColor = System.Drawing.Color.White;
            this.cb_hsdb_loaict.BorderColor = System.Drawing.Color.Silver;
            this.cb_hsdb_loaict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_hsdb_loaict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hsdb_loaict.FocusedColor = System.Drawing.Color.Empty;
            this.cb_hsdb_loaict.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hsdb_loaict.ForeColor = System.Drawing.Color.Black;
            this.cb_hsdb_loaict.FormattingEnabled = true;
            this.cb_hsdb_loaict.Items.AddRange(new object[] {
            "TrongNuoc",
            "NgoaiNuoc"});
            this.cb_hsdb_loaict.Location = new System.Drawing.Point(586, 139);
            this.cb_hsdb_loaict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_hsdb_loaict.Name = "cb_hsdb_loaict";
            this.cb_hsdb_loaict.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_hsdb_loaict.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_hsdb_loaict.Size = new System.Drawing.Size(121, 28);
            this.cb_hsdb_loaict.TabIndex = 21;
            this.cb_hsdb_loaict.Visible = false;
            // 
            // dtp_cauthu_ngsinh
            // 
            this.dtp_cauthu_ngsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_cauthu_ngsinh.Location = new System.Drawing.Point(586, 92);
            this.dtp_cauthu_ngsinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_cauthu_ngsinh.Name = "dtp_cauthu_ngsinh";
            this.dtp_cauthu_ngsinh.Size = new System.Drawing.Size(121, 24);
            this.dtp_cauthu_ngsinh.TabIndex = 20;
            this.dtp_cauthu_ngsinh.Visible = false;
            // 
            // btt_back
            // 
            this.btt_back.AnimationHoverSpeed = 0.07F;
            this.btt_back.AnimationSpeed = 0.03F;
            this.btt_back.BaseColor = System.Drawing.Color.Teal;
            this.btt_back.BorderColor = System.Drawing.Color.Black;
            this.btt_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_back.FocusedColor = System.Drawing.Color.Empty;
            this.btt_back.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_back.ForeColor = System.Drawing.Color.Black;
            this.btt_back.Image = ((System.Drawing.Image)(resources.GetObject("btt_back.Image")));
            this.btt_back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_back.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_back.Location = new System.Drawing.Point(798, 112);
            this.btt_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btt_back.Name = "btt_back";
            this.btt_back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_back.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_back.OnHoverImage = null;
            this.btt_back.OnPressedColor = System.Drawing.Color.Black;
            this.btt_back.Size = new System.Drawing.Size(127, 42);
            this.btt_back.TabIndex = 19;
            this.btt_back.Text = "Quay lại ";
            this.btt_back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_back.Visible = false;
            this.btt_back.Click += new System.EventHandler(this.btt_back_Click);
            // 
            // cbb_team_name
            // 
            this.cbb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.cbb_team_name.BaseColor = System.Drawing.Color.White;
            this.cbb_team_name.BorderColor = System.Drawing.Color.Silver;
            this.cbb_team_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_team_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_team_name.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_team_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_team_name.ForeColor = System.Drawing.Color.Black;
            this.cbb_team_name.FormattingEnabled = true;
            this.cbb_team_name.Location = new System.Drawing.Point(400, 43);
            this.cbb_team_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_team_name.Name = "cbb_team_name";
            this.cbb_team_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_team_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_team_name.Size = new System.Drawing.Size(164, 27);
            this.cbb_team_name.TabIndex = 18;
            // 
            // tb_hsdb_tgiantd
            // 
            this.tb_hsdb_tgiantd.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tgiantd.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_tgiantd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_tgiantd.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tgiantd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_tgiantd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hsdb_tgiantd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hsdb_tgiantd.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_tgiantd.Location = new System.Drawing.Point(586, 45);
            this.tb_hsdb_tgiantd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_hsdb_tgiantd.Name = "tb_hsdb_tgiantd";
            this.tb_hsdb_tgiantd.PasswordChar = '\0';
            this.tb_hsdb_tgiantd.SelectedText = "";
            this.tb_hsdb_tgiantd.Size = new System.Drawing.Size(120, 26);
            this.tb_hsdb_tgiantd.TabIndex = 17;
            this.tb_hsdb_tgiantd.Visible = false;
            // 
            // lb_hsdb_tgiantd
            // 
            this.lb_hsdb_tgiantd.AutoSize = true;
            this.lb_hsdb_tgiantd.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_tgiantd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_tgiantd.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_tgiantd.Location = new System.Drawing.Point(420, 45);
            this.lb_hsdb_tgiantd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_tgiantd.Name = "lb_hsdb_tgiantd";
            this.lb_hsdb_tgiantd.Size = new System.Drawing.Size(167, 25);
            this.lb_hsdb_tgiantd.TabIndex = 16;
            this.lb_hsdb_tgiantd.Text = "Thời gian thi đấu:";
            this.lb_hsdb_tgiantd.Visible = false;
            // 
            // tb_hsdb_tenct
            // 
            this.tb_hsdb_tenct.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tenct.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_tenct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_tenct.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tenct.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_tenct.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_tenct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hsdb_tenct.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_tenct.Location = new System.Drawing.Point(245, 138);
            this.tb_hsdb_tenct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_hsdb_tenct.Name = "tb_hsdb_tenct";
            this.tb_hsdb_tenct.PasswordChar = '\0';
            this.tb_hsdb_tenct.SelectedText = "";
            this.tb_hsdb_tenct.Size = new System.Drawing.Size(120, 26);
            this.tb_hsdb_tenct.TabIndex = 13;
            this.tb_hsdb_tenct.Visible = false;
            // 
            // tb_hsdb_mact
            // 
            this.tb_hsdb_mact.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_mact.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_mact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_mact.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_mact.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_mact.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_mact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hsdb_mact.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_mact.Location = new System.Drawing.Point(245, 90);
            this.tb_hsdb_mact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_hsdb_mact.Name = "tb_hsdb_mact";
            this.tb_hsdb_mact.PasswordChar = '\0';
            this.tb_hsdb_mact.SelectedText = "";
            this.tb_hsdb_mact.Size = new System.Drawing.Size(120, 26);
            this.tb_hsdb_mact.TabIndex = 12;
            this.tb_hsdb_mact.Visible = false;
            // 
            // lb_hsdb_loaict
            // 
            this.lb_hsdb_loaict.AutoSize = true;
            this.lb_hsdb_loaict.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_loaict.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_loaict.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_loaict.Location = new System.Drawing.Point(464, 138);
            this.lb_hsdb_loaict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_loaict.Name = "lb_hsdb_loaict";
            this.lb_hsdb_loaict.Size = new System.Drawing.Size(125, 25);
            this.lb_hsdb_loaict.TabIndex = 11;
            this.lb_hsdb_loaict.Text = "Loại cầu thủ:";
            this.lb_hsdb_loaict.Visible = false;
            // 
            // lb_hsdb_ngsinh
            // 
            this.lb_hsdb_ngsinh.AutoSize = true;
            this.lb_hsdb_ngsinh.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_ngsinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_ngsinh.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_ngsinh.Location = new System.Drawing.Point(464, 90);
            this.lb_hsdb_ngsinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_ngsinh.Name = "lb_hsdb_ngsinh";
            this.lb_hsdb_ngsinh.Size = new System.Drawing.Size(105, 25);
            this.lb_hsdb_ngsinh.TabIndex = 10;
            this.lb_hsdb_ngsinh.Text = "Ngày sinh:";
            this.lb_hsdb_ngsinh.Visible = false;
            // 
            // lb_hsdb_Tenct
            // 
            this.lb_hsdb_Tenct.AutoSize = true;
            this.lb_hsdb_Tenct.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_Tenct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_Tenct.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_Tenct.Location = new System.Drawing.Point(125, 138);
            this.lb_hsdb_Tenct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_Tenct.Name = "lb_hsdb_Tenct";
            this.lb_hsdb_Tenct.Size = new System.Drawing.Size(119, 25);
            this.lb_hsdb_Tenct.TabIndex = 9;
            this.lb_hsdb_Tenct.Text = "Tên cầu thủ:";
            this.lb_hsdb_Tenct.Visible = false;
            // 
            // lb_hsdb_mact
            // 
            this.lb_hsdb_mact.AutoSize = true;
            this.lb_hsdb_mact.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_mact.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_mact.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_mact.Location = new System.Drawing.Point(128, 90);
            this.lb_hsdb_mact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hsdb_mact.Name = "lb_hsdb_mact";
            this.lb_hsdb_mact.Size = new System.Drawing.Size(116, 25);
            this.lb_hsdb_mact.TabIndex = 8;
            this.lb_hsdb_mact.Text = "Mã cầu thủ:";
            this.lb_hsdb_mact.Visible = false;
            // 
            // btt_Team_View
            // 
            this.btt_Team_View.AnimationHoverSpeed = 0.07F;
            this.btt_Team_View.AnimationSpeed = 0.03F;
            this.btt_Team_View.BaseColor = System.Drawing.Color.Teal;
            this.btt_Team_View.BorderColor = System.Drawing.Color.Black;
            this.btt_Team_View.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Team_View.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Team_View.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Team_View.ForeColor = System.Drawing.Color.Black;
            this.btt_Team_View.Image = ((System.Drawing.Image)(resources.GetObject("btt_Team_View.Image")));
            this.btt_Team_View.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Team_View.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_Team_View.Location = new System.Drawing.Point(798, 159);
            this.btt_Team_View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btt_Team_View.Name = "btt_Team_View";
            this.btt_Team_View.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Team_View.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Team_View.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Team_View.OnHoverImage = null;
            this.btt_Team_View.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Team_View.Size = new System.Drawing.Size(127, 42);
            this.btt_Team_View.TabIndex = 7;
            this.btt_Team_View.Text = "Hiển Thị";
            this.btt_Team_View.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Team_View.Click += new System.EventHandler(this.btt_Team_View_Click);
            // 
            // tb_MaDoi
            // 
            this.tb_MaDoi.BaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaDoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaDoi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaDoi.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaDoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaDoi.ForeColor = System.Drawing.Color.Black;
            this.tb_MaDoi.Location = new System.Drawing.Point(245, 42);
            this.tb_MaDoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MaDoi.Name = "tb_MaDoi";
            this.tb_MaDoi.PasswordChar = '\0';
            this.tb_MaDoi.SelectedText = "";
            this.tb_MaDoi.Size = new System.Drawing.Size(120, 26);
            this.tb_MaDoi.TabIndex = 1;
            this.tb_MaDoi.Visible = false;
            // 
            // lb_team_name
            // 
            this.lb_team_name.AutoSize = true;
            this.lb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_name.ForeColor = System.Drawing.Color.Black;
            this.lb_team_name.Location = new System.Drawing.Point(316, 43);
            this.lb_team_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_team_name.Name = "lb_team_name";
            this.lb_team_name.Size = new System.Drawing.Size(82, 25);
            this.lb_team_name.TabIndex = 1;
            this.lb_team_name.Text = "Tên đội:";
            // 
            // lb_team_id
            // 
            this.lb_team_id.AutoSize = true;
            this.lb_team_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_id.ForeColor = System.Drawing.Color.Black;
            this.lb_team_id.Location = new System.Drawing.Point(128, 45);
            this.lb_team_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_team_id.Name = "lb_team_id";
            this.lb_team_id.Size = new System.Drawing.Size(79, 25);
            this.lb_team_id.TabIndex = 0;
            this.lb_team_id.Text = "Mã đội:";
            this.lb_team_id.Visible = false;
            // 
            // dgv_HSDB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HSDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HSDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HSDB.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HSDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_HSDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HSDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HSDB.ColumnHeadersHeight = 30;
            this.dgv_HSDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauThu,
            this.TenCauThu,
            this.NgaySinh,
            this.LoaiCauThu,
            this.ThoiGianThiDau,
            this.TinhTrang,
            this.MaDoi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HSDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HSDB.EnableHeadersVisualStyles = false;
            this.dgv_HSDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.Location = new System.Drawing.Point(0, 296);
            this.dgv_HSDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_HSDB.Name = "dgv_HSDB";
            this.dgv_HSDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_HSDB.RowHeadersVisible = false;
            this.dgv_HSDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_HSDB.RowTemplate.Height = 24;
            this.dgv_HSDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HSDB.Size = new System.Drawing.Size(938, 184);
            this.dgv_HSDB.TabIndex = 3;
            this.dgv_HSDB.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HSDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_HSDB.ThemeStyle.ReadOnly = false;
            this.dgv_HSDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HSDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HSDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_HSDB.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_HSDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_HSDB.Visible = false;
            this.dgv_HSDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HSDB_CellContentClick);
            // 
            // MaCauThu
            // 
            this.MaCauThu.DataPropertyName = "MaCauThu";
            this.MaCauThu.FillWeight = 40F;
            this.MaCauThu.HeaderText = "Mã Cầu Thủ";
            this.MaCauThu.Name = "MaCauThu";
            this.MaCauThu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenCauThu
            // 
            this.TenCauThu.DataPropertyName = "TenCauThu";
            this.TenCauThu.FillWeight = 60F;
            this.TenCauThu.HeaderText = "Tên Cầu Thủ";
            this.TenCauThu.Name = "TenCauThu";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 40F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // LoaiCauThu
            // 
            this.LoaiCauThu.DataPropertyName = "LoaiCauThu";
            this.LoaiCauThu.FillWeight = 40F;
            this.LoaiCauThu.HeaderText = "Tên Loại Cầu Thủ";
            this.LoaiCauThu.Name = "LoaiCauThu";
            // 
            // ThoiGianThiDau
            // 
            this.ThoiGianThiDau.DataPropertyName = "ThoiGianThiDau";
            this.ThoiGianThiDau.FillWeight = 40F;
            this.ThoiGianThiDau.HeaderText = "Thời Gian Thi Đấu";
            this.ThoiGianThiDau.Name = "ThoiGianThiDau";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 40F;
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.FillWeight = 20F;
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            // 
            // Btt_xoa
            // 
            this.Btt_xoa.AnimationHoverSpeed = 0.07F;
            this.Btt_xoa.AnimationSpeed = 0.03F;
            this.Btt_xoa.BaseColor = System.Drawing.Color.Teal;
            this.Btt_xoa.BorderColor = System.Drawing.Color.Black;
            this.Btt_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btt_xoa.FocusedColor = System.Drawing.Color.Empty;
            this.Btt_xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_xoa.ForeColor = System.Drawing.Color.Black;
            this.Btt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("Btt_xoa.Image")));
            this.Btt_xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_xoa.ImageSize = new System.Drawing.Size(25, 25);
            this.Btt_xoa.Location = new System.Drawing.Point(655, 498);
            this.Btt_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btt_xoa.Name = "Btt_xoa";
            this.Btt_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_xoa.OnHoverImage = null;
            this.Btt_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_xoa.Size = new System.Drawing.Size(127, 42);
            this.Btt_xoa.TabIndex = 4;
            this.Btt_xoa.Text = "Xoá";
            this.Btt_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_xoa.Visible = false;
            this.Btt_xoa.Click += new System.EventHandler(this.Btt_xoa_Click);
            // 
            // btt_Them
            // 
            this.btt_Them.AnimationHoverSpeed = 0.07F;
            this.btt_Them.AnimationSpeed = 0.03F;
            this.btt_Them.BaseColor = System.Drawing.Color.Teal;
            this.btt_Them.BorderColor = System.Drawing.Color.Black;
            this.btt_Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Them.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Them.ForeColor = System.Drawing.Color.Black;
            this.btt_Them.Image = ((System.Drawing.Image)(resources.GetObject("btt_Them.Image")));
            this.btt_Them.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Them.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_Them.Location = new System.Drawing.Point(506, 498);
            this.btt_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Them.OnHoverImage = null;
            this.btt_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Them.Size = new System.Drawing.Size(127, 42);
            this.btt_Them.TabIndex = 5;
            this.btt_Them.Text = "Thêm";
            this.btt_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Them.Visible = false;
            this.btt_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Btt_sua
            // 
            this.Btt_sua.AnimationHoverSpeed = 0.07F;
            this.Btt_sua.AnimationSpeed = 0.03F;
            this.Btt_sua.BaseColor = System.Drawing.Color.Teal;
            this.Btt_sua.BorderColor = System.Drawing.Color.Black;
            this.Btt_sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btt_sua.FocusedColor = System.Drawing.Color.Empty;
            this.Btt_sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_sua.ForeColor = System.Drawing.Color.Black;
            this.Btt_sua.Image = ((System.Drawing.Image)(resources.GetObject("Btt_sua.Image")));
            this.Btt_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_sua.ImageSize = new System.Drawing.Size(25, 25);
            this.Btt_sua.Location = new System.Drawing.Point(800, 498);
            this.Btt_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btt_sua.Name = "Btt_sua";
            this.Btt_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_sua.OnHoverImage = null;
            this.Btt_sua.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_sua.Size = new System.Drawing.Size(127, 42);
            this.Btt_sua.TabIndex = 6;
            this.Btt_sua.Text = "Sửa";
            this.Btt_sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_sua.Visible = false;
            this.Btt_sua.Click += new System.EventHandler(this.Btt_sua_Click);
            // 
            // usrTeamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btt_sua);
            this.Controls.Add(this.btt_Them);
            this.Controls.Add(this.Btt_xoa);
            this.Controls.Add(this.dgv_HSDB);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.lb_hsdb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "usrTeamList";
            this.Size = new System.Drawing.Size(940, 552);
            this.Load += new System.EventHandler(this.usrTeam_Load);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton lb_hsdb;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaLabel lb_team_name;
        private Guna.UI.WinForms.GunaLabel lb_team_id;
        private Guna.UI.WinForms.GunaButton Btt_xoa;
        private Guna.UI.WinForms.GunaButton btt_Them;
        private Guna.UI.WinForms.GunaButton Btt_sua;
        public Guna.UI.WinForms.GunaTextBox tb_MaDoi;
        public Guna.UI.WinForms.GunaDataGridView dgv_HSDB;
        private Guna.UI.WinForms.GunaButton btt_Team_View;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_loaict;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_ngsinh;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_Tenct;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_mact;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_tenct;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_mact;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_tgiantd;
        public Guna.UI.WinForms.GunaComboBox cbb_team_name;
        private Guna.UI.WinForms.GunaButton btt_back;
        public System.Windows.Forms.DateTimePicker dtp_cauthu_ngsinh;
        public Guna.UI.WinForms.GunaComboBox cb_hsdb_loaict;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_soctngoaiquoc;
        public Guna.UI.WinForms.GunaLabel lb_hsdb_sctnq;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianThiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoi;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_thetrang;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_thetrang;
        public Guna.UI.WinForms.GunaLabel lb_hsdb_tgiantd;
    }
}
