namespace QlyGiaiBongDa.GUI
{
    partial class usrCreateMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrCreateMatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_creatematch = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.cb_VongDau = new System.Windows.Forms.ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_timkiem = new Guna.UI.WinForms.GunaButton();
            this.vONGDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_TLTD = new Guna.UI.WinForms.GunaDataGridView();
            this.MaTranDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiChuNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioThiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanThiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TySo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANTHANGDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANTHANGKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PhatSinh = new Guna.UI.WinForms.GunaButton();
            this.btt_team_era = new Guna.UI.WinForms.GunaGradientButton();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vONGDAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TLTD)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_creatematch
            // 
            this.lb_creatematch.AnimationHoverSpeed = 0.07F;
            this.lb_creatematch.AnimationSpeed = 0.03F;
            this.lb_creatematch.BaseColor = System.Drawing.Color.Teal;
            this.lb_creatematch.BorderColor = System.Drawing.Color.Black;
            this.lb_creatematch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lb_creatematch.FocusedColor = System.Drawing.Color.Empty;
            this.lb_creatematch.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_creatematch.ForeColor = System.Drawing.Color.White;
            this.lb_creatematch.Image = ((System.Drawing.Image)(resources.GetObject("lb_creatematch.Image")));
            this.lb_creatematch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lb_creatematch.ImageSize = new System.Drawing.Size(40, 40);
            this.lb_creatematch.Location = new System.Drawing.Point(3, 3);
            this.lb_creatematch.Name = "lb_creatematch";
            this.lb_creatematch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.lb_creatematch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lb_creatematch.OnHoverForeColor = System.Drawing.Color.White;
            this.lb_creatematch.OnHoverImage = null;
            this.lb_creatematch.OnPressedColor = System.Drawing.Color.Black;
            this.lb_creatematch.Size = new System.Drawing.Size(1248, 68);
            this.lb_creatematch.TabIndex = 2;
            this.lb_creatematch.Text = "Danh Sách Trận Đấu";
            this.lb_creatematch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.cb_VongDau);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Controls.Add(this.btn_timkiem);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 77);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 138);
            this.gb_HSDB.TabIndex = 3;
            this.gb_HSDB.Text = "Chọn vòng thi đấu";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(1113, 39);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(115, 25);
            this.lb_Guide.TabIndex = 24;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
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
            this.cb_VongDau.Location = new System.Drawing.Point(589, 59);
            this.cb_VongDau.Name = "cb_VongDau";
            this.cb_VongDau.Size = new System.Drawing.Size(162, 33);
            this.cb_VongDau.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(388, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(161, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Vòng thi đấu";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.AnimationHoverSpeed = 0.07F;
            this.btn_timkiem.AnimationSpeed = 0.03F;
            this.btn_timkiem.BaseColor = System.Drawing.Color.Transparent;
            this.btn_timkiem.BorderColor = System.Drawing.Color.Black;
            this.btn_timkiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timkiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timkiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_timkiem.Location = new System.Drawing.Point(757, 55);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_timkiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timkiem.OnHoverImage = null;
            this.btn_timkiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timkiem.Size = new System.Drawing.Size(42, 37);
            this.btn_timkiem.TabIndex = 20;
            this.btn_timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // vONGDAUBindingSource
            // 
            this.vONGDAUBindingSource.DataMember = "VONGDAU";
            // 
            // dgv_TLTD
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TLTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TLTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TLTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TLTD.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_TLTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_TLTD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TLTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TLTD.ColumnHeadersHeight = 30;
            this.dgv_TLTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTranDau,
            this.DoiChuNha,
            this.DoiKhach,
            this.NgayThiDau,
            this.GioThiDau,
            this.SanThiDau,
            this.TySo,
            this.BANTHANGDN,
            this.BANTHANGKH});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TLTD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TLTD.EnableHeadersVisualStyles = false;
            this.dgv_TLTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.Location = new System.Drawing.Point(3, 221);
            this.dgv_TLTD.Name = "dgv_TLTD";
            this.dgv_TLTD.RowHeadersVisible = false;
            this.dgv_TLTD.RowTemplate.Height = 24;
            this.dgv_TLTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TLTD.Size = new System.Drawing.Size(1248, 366);
            this.dgv_TLTD.TabIndex = 21;
            this.dgv_TLTD.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_TLTD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TLTD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TLTD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TLTD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TLTD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TLTD.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgv_TLTD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TLTD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_TLTD.ThemeStyle.ReadOnly = false;
            this.dgv_TLTD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TLTD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TLTD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TLTD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TLTD.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_TLTD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TLTD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TLTD_CellClick);
            this.dgv_TLTD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TLTD_CellContentClick);
            // 
            // MaTranDau
            // 
            this.MaTranDau.DataPropertyName = "MaTranDau";
            this.MaTranDau.FillWeight = 50F;
            this.MaTranDau.HeaderText = "Mã Trận ";
            this.MaTranDau.Name = "MaTranDau";
            // 
            // DoiChuNha
            // 
            this.DoiChuNha.DataPropertyName = "DoiChuNha";
            this.DoiChuNha.FillWeight = 70F;
            this.DoiChuNha.HeaderText = "Đội Nhà";
            this.DoiChuNha.Name = "DoiChuNha";
            // 
            // DoiKhach
            // 
            this.DoiKhach.DataPropertyName = "DoiKhach";
            this.DoiKhach.FillWeight = 70F;
            this.DoiKhach.HeaderText = "Đội khách";
            this.DoiKhach.Name = "DoiKhach";
            // 
            // NgayThiDau
            // 
            this.NgayThiDau.DataPropertyName = "NgayThiDau";
            this.NgayThiDau.FillWeight = 70F;
            this.NgayThiDau.HeaderText = "Ngày Thi Đấu";
            this.NgayThiDau.Name = "NgayThiDau";
            // 
            // GioThiDau
            // 
            this.GioThiDau.DataPropertyName = "GioThiDau";
            this.GioThiDau.FillWeight = 60F;
            this.GioThiDau.HeaderText = "Giờ Thi Đấu";
            this.GioThiDau.Name = "GioThiDau";
            // 
            // SanThiDau
            // 
            this.SanThiDau.DataPropertyName = "SanThiDau";
            this.SanThiDau.FillWeight = 60F;
            this.SanThiDau.HeaderText = "Sân Thi Đấu";
            this.SanThiDau.Name = "SanThiDau";
            // 
            // TySo
            // 
            this.TySo.DataPropertyName = "TySo";
            this.TySo.FillWeight = 40F;
            this.TySo.HeaderText = "Tỷ Số";
            this.TySo.Name = "TySo";
            // 
            // BANTHANGDN
            // 
            this.BANTHANGDN.DataPropertyName = "BANTHANGDN";
            this.BANTHANGDN.FillWeight = 40F;
            this.BANTHANGDN.HeaderText = "Bàn thắng";
            this.BANTHANGDN.Name = "BANTHANGDN";
            // 
            // BANTHANGKH
            // 
            this.BANTHANGKH.DataPropertyName = "BANTHANGKH";
            this.BANTHANGKH.FillWeight = 40F;
            this.BANTHANGKH.HeaderText = "Bàn Thua";
            this.BANTHANGKH.Name = "BANTHANGKH";
            // 
            // btn_PhatSinh
            // 
            this.btn_PhatSinh.AnimationHoverSpeed = 0.07F;
            this.btn_PhatSinh.AnimationSpeed = 0.03F;
            this.btn_PhatSinh.BaseColor = System.Drawing.Color.Teal;
            this.btn_PhatSinh.BorderColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_PhatSinh.FocusedColor = System.Drawing.Color.Empty;
            this.btn_PhatSinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhatSinh.ForeColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhatSinh.Image")));
            this.btn_PhatSinh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_PhatSinh.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_PhatSinh.Location = new System.Drawing.Point(960, 611);
            this.btn_PhatSinh.Name = "btn_PhatSinh";
            this.btn_PhatSinh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_PhatSinh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PhatSinh.OnHoverImage = null;
            this.btn_PhatSinh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.Size = new System.Drawing.Size(271, 57);
            this.btn_PhatSinh.TabIndex = 22;
            this.btn_PhatSinh.Text = "Phát sinh trận đấu";
            this.btn_PhatSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_PhatSinh.Click += new System.EventHandler(this.btn_PhatSinh_Click);
            // 
            // btt_team_era
            // 
            this.btt_team_era.AnimationHoverSpeed = 0.07F;
            this.btt_team_era.AnimationSpeed = 0.03F;
            this.btt_team_era.BaseColor1 = System.Drawing.Color.Teal;
            this.btt_team_era.BaseColor2 = System.Drawing.Color.Teal;
            this.btt_team_era.BorderColor = System.Drawing.Color.Black;
            this.btt_team_era.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_team_era.FocusedColor = System.Drawing.Color.Empty;
            this.btt_team_era.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_team_era.ForeColor = System.Drawing.Color.Black;
            this.btt_team_era.Image = ((System.Drawing.Image)(resources.GetObject("btt_team_era.Image")));
            this.btt_team_era.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_era.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_team_era.Location = new System.Drawing.Point(806, 611);
            this.btt_team_era.Name = "btt_team_era";
            this.btt_team_era.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btt_team_era.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btt_team_era.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_team_era.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_team_era.OnHoverImage = null;
            this.btt_team_era.OnPressedColor = System.Drawing.Color.Black;
            this.btt_team_era.Size = new System.Drawing.Size(126, 57);
            this.btt_team_era.TabIndex = 23;
            this.btt_team_era.Text = "Xóa";
            this.btt_team_era.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_era.Click += new System.EventHandler(this.btt_team_era_Click);
            // 
            // usrCreateMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btt_team_era);
            this.Controls.Add(this.btn_PhatSinh);
            this.Controls.Add(this.dgv_TLTD);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.lb_creatematch);
            this.Name = "usrCreateMatch";
            this.Size = new System.Drawing.Size(1254, 697);
            this.Load += new System.EventHandler(this.usrCreateMatch_Load);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vONGDAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TLTD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton lb_creatematch;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btn_PhatSinh;
        public System.Windows.Forms.BindingSource vONGDAUBindingSource;
      
        public System.Windows.Forms.ComboBox cb_VongDau;
        private Guna.UI.WinForms.GunaGradientButton btt_team_era;
        public Guna.UI.WinForms.GunaDataGridView dgv_TLTD;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTranDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiChuNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioThiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanThiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TySo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANTHANGDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANTHANGKH;
        public Guna.UI.WinForms.GunaButton btn_timkiem;
    }
}
