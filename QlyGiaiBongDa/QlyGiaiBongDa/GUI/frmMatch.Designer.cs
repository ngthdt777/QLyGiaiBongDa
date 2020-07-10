namespace QlyGiaiBongDa.GUI
{
    partial class frmMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatch));
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.tb_match_tiso = new Guna.UI.WinForms.GunaTextBox();
            this.lb_match_tiso = new Guna.UI.WinForms.GunaLabel();
            this.cb_VongDau = new System.Windows.Forms.ComboBox();
            this.tb_GioThiDau = new Guna.UI.WinForms.GunaTextBox();
            this.lb_match_giotd = new Guna.UI.WinForms.GunaLabel();
            this.btt_exit = new Guna.UI.WinForms.GunaControlBox();
            this.lb_match_vongdau = new Guna.UI.WinForms.GunaLabel();
            this.dtp_match = new System.Windows.Forms.DateTimePicker();
            this.lb_match_date = new Guna.UI.WinForms.GunaLabel();
            this.tb_match_court = new Guna.UI.WinForms.GunaTextBox();
            this.tb_match_id = new Guna.UI.WinForms.GunaTextBox();
            this.lb_match_home = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_san = new Guna.UI.WinForms.GunaLabel();
            this.lb_match_guest = new Guna.UI.WinForms.GunaLabel();
            this.lb_match_id = new Guna.UI.WinForms.GunaLabel();
            this.btt_team_add = new Guna.UI.WinForms.GunaGradientButton();
            this.tb_BanthangNha = new Guna.UI.WinForms.GunaTextBox();
            this.Tb_BanThangKh = new Guna.UI.WinForms.GunaTextBox();
            this.cb_doinha = new Guna.UI.WinForms.GunaComboBox();
            this.cb_doikhach = new Guna.UI.WinForms.GunaComboBox();
            this.gb_HSDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.cb_doikhach);
            this.gb_HSDB.Controls.Add(this.cb_doinha);
            this.gb_HSDB.Controls.Add(this.Tb_BanThangKh);
            this.gb_HSDB.Controls.Add(this.tb_BanthangNha);
            this.gb_HSDB.Controls.Add(this.tb_match_tiso);
            this.gb_HSDB.Controls.Add(this.lb_match_tiso);
            this.gb_HSDB.Controls.Add(this.cb_VongDau);
            this.gb_HSDB.Controls.Add(this.tb_GioThiDau);
            this.gb_HSDB.Controls.Add(this.lb_match_giotd);
            this.gb_HSDB.Controls.Add(this.btt_exit);
            this.gb_HSDB.Controls.Add(this.lb_match_vongdau);
            this.gb_HSDB.Controls.Add(this.dtp_match);
            this.gb_HSDB.Controls.Add(this.lb_match_date);
            this.gb_HSDB.Controls.Add(this.tb_match_court);
            this.gb_HSDB.Controls.Add(this.tb_match_id);
            this.gb_HSDB.Controls.Add(this.lb_match_home);
            this.gb_HSDB.Controls.Add(this.lb_team_san);
            this.gb_HSDB.Controls.Add(this.lb_match_guest);
            this.gb_HSDB.Controls.Add(this.lb_match_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.ForeColor = System.Drawing.Color.Black;
            this.gb_HSDB.LineColor = System.Drawing.Color.Teal;
            this.gb_HSDB.LineTop = 36;
            this.gb_HSDB.Location = new System.Drawing.Point(0, 0);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(927, 315);
            this.gb_HSDB.TabIndex = 12;
            this.gb_HSDB.Text = "Thông tin đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // tb_match_tiso
            // 
            this.tb_match_tiso.BaseColor = System.Drawing.Color.White;
            this.tb_match_tiso.BorderColor = System.Drawing.Color.Silver;
            this.tb_match_tiso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_match_tiso.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_match_tiso.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_match_tiso.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_match_tiso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_match_tiso.Location = new System.Drawing.Point(475, 242);
            this.tb_match_tiso.Name = "tb_match_tiso";
            this.tb_match_tiso.PasswordChar = '\0';
            this.tb_match_tiso.SelectedText = "";
            this.tb_match_tiso.Size = new System.Drawing.Size(160, 32);
            this.tb_match_tiso.TabIndex = 26;
            // 
            // lb_match_tiso
            // 
            this.lb_match_tiso.AutoSize = true;
            this.lb_match_tiso.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_tiso.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_tiso.ForeColor = System.Drawing.Color.Black;
            this.lb_match_tiso.Location = new System.Drawing.Point(378, 242);
            this.lb_match_tiso.Name = "lb_match_tiso";
            this.lb_match_tiso.Size = new System.Drawing.Size(82, 32);
            this.lb_match_tiso.TabIndex = 25;
            this.lb_match_tiso.Text = "Tỷ số:";
            // 
            // cb_VongDau
            // 
            this.cb_VongDau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_VongDau.ForeColor = System.Drawing.Color.Black;
            this.cb_VongDau.FormattingEnabled = true;
            this.cb_VongDau.Items.AddRange(new object[] {
            "VB",
            "Vong16",
            "TuKet",
            "BanKet",
            "ChungKet"});
            this.cb_VongDau.Location = new System.Drawing.Point(616, 181);
            this.cb_VongDau.Name = "cb_VongDau";
            this.cb_VongDau.Size = new System.Drawing.Size(162, 33);
            this.cb_VongDau.TabIndex = 24;
            // 
            // tb_GioThiDau
            // 
            this.tb_GioThiDau.BaseColor = System.Drawing.Color.White;
            this.tb_GioThiDau.BorderColor = System.Drawing.Color.Silver;
            this.tb_GioThiDau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GioThiDau.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_GioThiDau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_GioThiDau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_GioThiDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_GioThiDau.Location = new System.Drawing.Point(618, 66);
            this.tb_GioThiDau.Name = "tb_GioThiDau";
            this.tb_GioThiDau.PasswordChar = '\0';
            this.tb_GioThiDau.SelectedText = "";
            this.tb_GioThiDau.Size = new System.Drawing.Size(160, 32);
            this.tb_GioThiDau.TabIndex = 23;
            // 
            // lb_match_giotd
            // 
            this.lb_match_giotd.AutoSize = true;
            this.lb_match_giotd.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_giotd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_giotd.ForeColor = System.Drawing.Color.Black;
            this.lb_match_giotd.Location = new System.Drawing.Point(454, 66);
            this.lb_match_giotd.Name = "lb_match_giotd";
            this.lb_match_giotd.Size = new System.Drawing.Size(148, 32);
            this.lb_match_giotd.TabIndex = 22;
            this.lb_match_giotd.Text = "Giờ thi đấu:";
            // 
            // btt_exit
            // 
            this.btt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_exit.AnimationHoverSpeed = 0.07F;
            this.btt_exit.AnimationSpeed = 0.03F;
            this.btt_exit.BackColor = System.Drawing.Color.SpringGreen;
            this.btt_exit.IconColor = System.Drawing.Color.Crimson;
            this.btt_exit.IconSize = 25F;
            this.btt_exit.Location = new System.Drawing.Point(863, 3);
            this.btt_exit.Name = "btt_exit";
            this.btt_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btt_exit.OnHoverIconColor = System.Drawing.Color.White;
            this.btt_exit.OnPressedColor = System.Drawing.Color.Black;
            this.btt_exit.Size = new System.Drawing.Size(55, 35);
            this.btt_exit.TabIndex = 21;
            // 
            // lb_match_vongdau
            // 
            this.lb_match_vongdau.AutoSize = true;
            this.lb_match_vongdau.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_vongdau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_vongdau.ForeColor = System.Drawing.Color.Black;
            this.lb_match_vongdau.Location = new System.Drawing.Point(454, 179);
            this.lb_match_vongdau.Name = "lb_match_vongdau";
            this.lb_match_vongdau.Size = new System.Drawing.Size(131, 32);
            this.lb_match_vongdau.TabIndex = 10;
            this.lb_match_vongdau.Text = "Vòng đấu:";
            // 
            // dtp_match
            // 
            this.dtp_match.Location = new System.Drawing.Point(190, 243);
            this.dtp_match.Name = "dtp_match";
            this.dtp_match.Size = new System.Drawing.Size(160, 31);
            this.dtp_match.TabIndex = 9;
            // 
            // lb_match_date
            // 
            this.lb_match_date.AutoSize = true;
            this.lb_match_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_date.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_date.ForeColor = System.Drawing.Color.Black;
            this.lb_match_date.Location = new System.Drawing.Point(22, 242);
            this.lb_match_date.Name = "lb_match_date";
            this.lb_match_date.Size = new System.Drawing.Size(169, 32);
            this.lb_match_date.TabIndex = 8;
            this.lb_match_date.Text = "Ngày thi đấu:";
            // 
            // tb_match_court
            // 
            this.tb_match_court.BaseColor = System.Drawing.Color.White;
            this.tb_match_court.BorderColor = System.Drawing.Color.Silver;
            this.tb_match_court.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_match_court.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_match_court.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_match_court.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_match_court.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_match_court.Location = new System.Drawing.Point(618, 121);
            this.tb_match_court.Name = "tb_match_court";
            this.tb_match_court.PasswordChar = '\0';
            this.tb_match_court.SelectedText = "";
            this.tb_match_court.Size = new System.Drawing.Size(160, 32);
            this.tb_match_court.TabIndex = 7;
            // 
            // tb_match_id
            // 
            this.tb_match_id.BaseColor = System.Drawing.Color.White;
            this.tb_match_id.BorderColor = System.Drawing.Color.Silver;
            this.tb_match_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_match_id.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_match_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_match_id.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_match_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_match_id.ForeColor = System.Drawing.Color.Black;
            this.tb_match_id.Location = new System.Drawing.Point(190, 66);
            this.tb_match_id.Name = "tb_match_id";
            this.tb_match_id.PasswordChar = '\0';
            this.tb_match_id.SelectedText = "";
            this.tb_match_id.Size = new System.Drawing.Size(160, 32);
            this.tb_match_id.TabIndex = 4;
            // 
            // lb_match_home
            // 
            this.lb_match_home.AutoSize = true;
            this.lb_match_home.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_home.ForeColor = System.Drawing.Color.Black;
            this.lb_match_home.Location = new System.Drawing.Point(25, 121);
            this.lb_match_home.Name = "lb_match_home";
            this.lb_match_home.Size = new System.Drawing.Size(159, 32);
            this.lb_match_home.TabIndex = 3;
            this.lb_match_home.Text = "Đội chủ nhà:";
            // 
            // lb_team_san
            // 
            this.lb_team_san.AutoSize = true;
            this.lb_team_san.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_san.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_san.ForeColor = System.Drawing.Color.Black;
            this.lb_team_san.Location = new System.Drawing.Point(454, 121);
            this.lb_team_san.Name = "lb_team_san";
            this.lb_team_san.Size = new System.Drawing.Size(150, 32);
            this.lb_team_san.TabIndex = 2;
            this.lb_team_san.Text = "Sân thi đấu:";
            // 
            // lb_match_guest
            // 
            this.lb_match_guest.AutoSize = true;
            this.lb_match_guest.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_guest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_guest.ForeColor = System.Drawing.Color.Black;
            this.lb_match_guest.Location = new System.Drawing.Point(22, 179);
            this.lb_match_guest.Name = "lb_match_guest";
            this.lb_match_guest.Size = new System.Drawing.Size(135, 32);
            this.lb_match_guest.TabIndex = 1;
            this.lb_match_guest.Text = "Đội khách:";
            // 
            // lb_match_id
            // 
            this.lb_match_id.AutoSize = true;
            this.lb_match_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_match_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_match_id.ForeColor = System.Drawing.Color.Black;
            this.lb_match_id.Location = new System.Drawing.Point(22, 66);
            this.lb_match_id.Name = "lb_match_id";
            this.lb_match_id.Size = new System.Drawing.Size(162, 32);
            this.lb_match_id.TabIndex = 0;
            this.lb_match_id.Text = "Mã trận đấu:";
            // 
            // btt_team_add
            // 
            this.btt_team_add.AnimationHoverSpeed = 0.07F;
            this.btt_team_add.AnimationSpeed = 0.03F;
            this.btt_team_add.BaseColor1 = System.Drawing.Color.Teal;
            this.btt_team_add.BaseColor2 = System.Drawing.Color.Teal;
            this.btt_team_add.BorderColor = System.Drawing.Color.Black;
            this.btt_team_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_team_add.FocusedColor = System.Drawing.Color.Empty;
            this.btt_team_add.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_team_add.ForeColor = System.Drawing.Color.Black;
            this.btt_team_add.Image = ((System.Drawing.Image)(resources.GetObject("btt_team_add.Image")));
            this.btt_team_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_add.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_team_add.Location = new System.Drawing.Point(738, 321);
            this.btt_team_add.Name = "btt_team_add";
            this.btt_team_add.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btt_team_add.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btt_team_add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_team_add.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_team_add.OnHoverImage = null;
            this.btt_team_add.OnPressedColor = System.Drawing.Color.Black;
            this.btt_team_add.Size = new System.Drawing.Size(161, 49);
            this.btt_team_add.TabIndex = 8;
            this.btt_team_add.Text = "Thêm ";
            this.btt_team_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_add.Click += new System.EventHandler(this.btt_team_add_Click);
            // 
            // tb_BanthangNha
            // 
            this.tb_BanthangNha.BaseColor = System.Drawing.Color.White;
            this.tb_BanthangNha.BorderColor = System.Drawing.Color.Silver;
            this.tb_BanthangNha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BanthangNha.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_BanthangNha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_BanthangNha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_BanthangNha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_BanthangNha.Location = new System.Drawing.Point(651, 242);
            this.tb_BanthangNha.Name = "tb_BanthangNha";
            this.tb_BanthangNha.PasswordChar = '\0';
            this.tb_BanthangNha.SelectedText = "";
            this.tb_BanthangNha.Size = new System.Drawing.Size(51, 32);
            this.tb_BanthangNha.TabIndex = 27;
            // 
            // Tb_BanThangKh
            // 
            this.Tb_BanThangKh.BaseColor = System.Drawing.Color.White;
            this.Tb_BanThangKh.BorderColor = System.Drawing.Color.Silver;
            this.Tb_BanThangKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_BanThangKh.FocusedBaseColor = System.Drawing.Color.White;
            this.Tb_BanThangKh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Tb_BanThangKh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Tb_BanThangKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tb_BanThangKh.Location = new System.Drawing.Point(727, 243);
            this.Tb_BanThangKh.Name = "Tb_BanThangKh";
            this.Tb_BanThangKh.PasswordChar = '\0';
            this.Tb_BanThangKh.SelectedText = "";
            this.Tb_BanThangKh.Size = new System.Drawing.Size(51, 32);
            this.Tb_BanThangKh.TabIndex = 28;
            // 
            // cb_doinha
            // 
            this.cb_doinha.BackColor = System.Drawing.Color.Transparent;
            this.cb_doinha.BaseColor = System.Drawing.Color.White;
            this.cb_doinha.BorderColor = System.Drawing.Color.Silver;
            this.cb_doinha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_doinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doinha.FocusedColor = System.Drawing.Color.Empty;
            this.cb_doinha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_doinha.ForeColor = System.Drawing.Color.Black;
            this.cb_doinha.FormattingEnabled = true;
            this.cb_doinha.Location = new System.Drawing.Point(190, 123);
            this.cb_doinha.Name = "cb_doinha";
            this.cb_doinha.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_doinha.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_doinha.Size = new System.Drawing.Size(217, 32);
            this.cb_doinha.TabIndex = 29;
            // 
            // cb_doikhach
            // 
            this.cb_doikhach.BackColor = System.Drawing.Color.Transparent;
            this.cb_doikhach.BaseColor = System.Drawing.Color.White;
            this.cb_doikhach.BorderColor = System.Drawing.Color.Silver;
            this.cb_doikhach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_doikhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doikhach.FocusedColor = System.Drawing.Color.Empty;
            this.cb_doikhach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_doikhach.ForeColor = System.Drawing.Color.Black;
            this.cb_doikhach.FormattingEnabled = true;
            this.cb_doikhach.Location = new System.Drawing.Point(190, 182);
            this.cb_doikhach.Name = "cb_doikhach";
            this.cb_doikhach.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_doikhach.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_doikhach.Size = new System.Drawing.Size(217, 32);
            this.cb_doikhach.TabIndex = 30;
            // 
            // frmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 393);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.btt_team_add);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatch";
            this.Load += new System.EventHandler(this.frmMatch_Load);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        public Guna.UI.WinForms.GunaTextBox tb_match_court;
        private Guna.UI.WinForms.GunaGradientButton btt_team_add;
        public Guna.UI.WinForms.GunaTextBox tb_match_id;
        private Guna.UI.WinForms.GunaLabel lb_match_home;
        private Guna.UI.WinForms.GunaLabel lb_match_guest;
        private Guna.UI.WinForms.GunaLabel lb_match_id;
        private Guna.UI.WinForms.GunaLabel lb_match_date;
        public Guna.UI.WinForms.GunaLabel lb_team_san;
        public System.Windows.Forms.DateTimePicker dtp_match;
        public Guna.UI.WinForms.GunaLabel lb_match_vongdau;
        private Guna.UI.WinForms.GunaControlBox btt_exit;
        public Guna.UI.WinForms.GunaTextBox tb_GioThiDau;
        public Guna.UI.WinForms.GunaLabel lb_match_giotd;
        public System.Windows.Forms.ComboBox cb_VongDau;
        public Guna.UI.WinForms.GunaTextBox tb_match_tiso;
        public Guna.UI.WinForms.GunaLabel lb_match_tiso;
        public Guna.UI.WinForms.GunaTextBox Tb_BanThangKh;
        public Guna.UI.WinForms.GunaTextBox tb_BanthangNha;
        public Guna.UI.WinForms.GunaComboBox cb_doikhach;
        public Guna.UI.WinForms.GunaComboBox cb_doinha;
    }
}