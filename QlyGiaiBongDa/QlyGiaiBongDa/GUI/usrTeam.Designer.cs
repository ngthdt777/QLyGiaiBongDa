namespace QlyGiaiBongDa.GUI
{
    partial class usrTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrTeam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_hsdb = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.btt_Team_View = new Guna.UI.WinForms.GunaButton();
            this.tb_TenDoi = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaDoi = new Guna.UI.WinForms.GunaTextBox();
            this.lb_team_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_id = new Guna.UI.WinForms.GunaLabel();
            this.dgv_HSDB = new Guna.UI.WinForms.GunaDataGridView();
            this.Btt_xoa = new Guna.UI.WinForms.GunaButton();
            this.btt_Them = new Guna.UI.WinForms.GunaButton();
            this.Btt_sua = new Guna.UI.WinForms.GunaButton();
            this.lb_hsdb_mact = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_Tenct = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_ngsinh = new Guna.UI.WinForms.GunaLabel();
            this.lb_hsdb_loaict = new Guna.UI.WinForms.GunaLabel();
            this.tb_hsdb_mact = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hsdb_tenct = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hsdb_ngsinh = new Guna.UI.WinForms.GunaTextBox();
            this.tb_hsdb_loaict = new Guna.UI.WinForms.GunaTextBox();
            this.MaCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_hsdb_ghichu = new Guna.UI.WinForms.GunaLabel();
            this.tb_hsdb_ghichu = new Guna.UI.WinForms.GunaTextBox();
            this.btt_hsdb_capnhat = new Guna.UI.WinForms.GunaButton();
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
            this.lb_hsdb.Location = new System.Drawing.Point(3, 0);
            this.lb_hsdb.Name = "lb_hsdb";
            this.lb_hsdb.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.lb_hsdb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lb_hsdb.OnHoverForeColor = System.Drawing.Color.White;
            this.lb_hsdb.OnHoverImage = null;
            this.lb_hsdb.OnPressedColor = System.Drawing.Color.Black;
            this.lb_hsdb.Size = new System.Drawing.Size(1248, 101);
            this.lb_hsdb.TabIndex = 0;
            this.lb_hsdb.Text = "Hồ sơ đội bóng";
            this.lb_hsdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.btt_hsdb_capnhat);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_ghichu);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_ghichu);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_loaict);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_ngsinh);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_tenct);
            this.gb_HSDB.Controls.Add(this.tb_hsdb_mact);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_loaict);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_ngsinh);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_Tenct);
            this.gb_HSDB.Controls.Add(this.lb_hsdb_mact);
            this.gb_HSDB.Controls.Add(this.btt_Team_View);
            this.gb_HSDB.Controls.Add(this.tb_TenDoi);
            this.gb_HSDB.Controls.Add(this.tb_MaDoi);
            this.gb_HSDB.Controls.Add(this.lb_team_name);
            this.gb_HSDB.Controls.Add(this.lb_team_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 107);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 251);
            this.gb_HSDB.TabIndex = 1;
            this.gb_HSDB.Text = "Thông tin đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
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
            this.btt_Team_View.Location = new System.Drawing.Point(1064, 196);
            this.btt_Team_View.Name = "btt_Team_View";
            this.btt_Team_View.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Team_View.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Team_View.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Team_View.OnHoverImage = null;
            this.btt_Team_View.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Team_View.Size = new System.Drawing.Size(169, 52);
            this.btt_Team_View.TabIndex = 7;
            this.btt_Team_View.Text = "Hiển Thị";
            this.btt_Team_View.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Team_View.Click += new System.EventHandler(this.btt_Team_View_Click);
            // 
            // tb_TenDoi
            // 
            this.tb_TenDoi.BaseColor = System.Drawing.Color.White;
            this.tb_TenDoi.BorderColor = System.Drawing.Color.Silver;
            this.tb_TenDoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TenDoi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_TenDoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_TenDoi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_TenDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_TenDoi.Location = new System.Drawing.Point(782, 52);
            this.tb_TenDoi.Name = "tb_TenDoi";
            this.tb_TenDoi.PasswordChar = '\0';
            this.tb_TenDoi.SelectedText = "";
            this.tb_TenDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_TenDoi.TabIndex = 6;
            // 
            // tb_MaDoi
            // 
            this.tb_MaDoi.BaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaDoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaDoi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaDoi.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_MaDoi.ForeColor = System.Drawing.Color.Black;
            this.tb_MaDoi.Location = new System.Drawing.Point(327, 52);
            this.tb_MaDoi.Name = "tb_MaDoi";
            this.tb_MaDoi.PasswordChar = '\0';
            this.tb_MaDoi.SelectedText = "";
            this.tb_MaDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_MaDoi.TabIndex = 4;
            // 
            // lb_team_name
            // 
            this.lb_team_name.AutoSize = true;
            this.lb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_name.ForeColor = System.Drawing.Color.Black;
            this.lb_team_name.Location = new System.Drawing.Point(619, 52);
            this.lb_team_name.Name = "lb_team_name";
            this.lb_team_name.Size = new System.Drawing.Size(99, 32);
            this.lb_team_name.TabIndex = 1;
            this.lb_team_name.Text = "Tên đội:";
            // 
            // lb_team_id
            // 
            this.lb_team_id.AutoSize = true;
            this.lb_team_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_id.ForeColor = System.Drawing.Color.Black;
            this.lb_team_id.Location = new System.Drawing.Point(177, 52);
            this.lb_team_id.Name = "lb_team_id";
            this.lb_team_id.Size = new System.Drawing.Size(95, 32);
            this.lb_team_id.TabIndex = 0;
            this.lb_team_id.Text = "Mã đội:";
            // 
            // dgv_HSDB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HSDB.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.TenLoaiCauThu});
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
            this.dgv_HSDB.Location = new System.Drawing.Point(0, 364);
            this.dgv_HSDB.Name = "dgv_HSDB";
            this.dgv_HSDB.RowHeadersVisible = false;
            this.dgv_HSDB.RowTemplate.Height = 24;
            this.dgv_HSDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HSDB.Size = new System.Drawing.Size(1251, 243);
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
            this.dgv_HSDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HSDB_CellClick);
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
            this.Btt_xoa.Location = new System.Drawing.Point(866, 613);
            this.Btt_xoa.Name = "Btt_xoa";
            this.Btt_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_xoa.OnHoverImage = null;
            this.Btt_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_xoa.Size = new System.Drawing.Size(169, 52);
            this.Btt_xoa.TabIndex = 4;
            this.Btt_xoa.Text = "Xoá";
            this.Btt_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_xoa.Visible = false;
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
            this.btt_Them.Location = new System.Drawing.Point(661, 613);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Them.OnHoverImage = null;
            this.btt_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Them.Size = new System.Drawing.Size(169, 52);
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
            this.Btt_sua.Location = new System.Drawing.Point(1067, 613);
            this.Btt_sua.Name = "Btt_sua";
            this.Btt_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_sua.OnHoverImage = null;
            this.Btt_sua.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_sua.Size = new System.Drawing.Size(169, 52);
            this.Btt_sua.TabIndex = 6;
            this.Btt_sua.Text = "Sửa";
            this.Btt_sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_sua.Visible = false;
            // 
            // lb_hsdb_mact
            // 
            this.lb_hsdb_mact.AutoSize = true;
            this.lb_hsdb_mact.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_mact.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_mact.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_mact.Location = new System.Drawing.Point(177, 111);
            this.lb_hsdb_mact.Name = "lb_hsdb_mact";
            this.lb_hsdb_mact.Size = new System.Drawing.Size(141, 32);
            this.lb_hsdb_mact.TabIndex = 8;
            this.lb_hsdb_mact.Text = "Mã cầu thủ:";
            this.lb_hsdb_mact.Visible = false;
            // 
            // lb_hsdb_Tenct
            // 
            this.lb_hsdb_Tenct.AutoSize = true;
            this.lb_hsdb_Tenct.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_Tenct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_Tenct.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_Tenct.Location = new System.Drawing.Point(177, 170);
            this.lb_hsdb_Tenct.Name = "lb_hsdb_Tenct";
            this.lb_hsdb_Tenct.Size = new System.Drawing.Size(145, 32);
            this.lb_hsdb_Tenct.TabIndex = 9;
            this.lb_hsdb_Tenct.Text = "Tên cầu thủ:";
            this.lb_hsdb_Tenct.Visible = false;
            // 
            // lb_hsdb_ngsinh
            // 
            this.lb_hsdb_ngsinh.AutoSize = true;
            this.lb_hsdb_ngsinh.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_ngsinh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_ngsinh.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_ngsinh.Location = new System.Drawing.Point(619, 111);
            this.lb_hsdb_ngsinh.Name = "lb_hsdb_ngsinh";
            this.lb_hsdb_ngsinh.Size = new System.Drawing.Size(127, 32);
            this.lb_hsdb_ngsinh.TabIndex = 10;
            this.lb_hsdb_ngsinh.Text = "Ngày sinh:";
            this.lb_hsdb_ngsinh.Visible = false;
            // 
            // lb_hsdb_loaict
            // 
            this.lb_hsdb_loaict.AutoSize = true;
            this.lb_hsdb_loaict.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_loaict.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_loaict.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_loaict.Location = new System.Drawing.Point(619, 170);
            this.lb_hsdb_loaict.Name = "lb_hsdb_loaict";
            this.lb_hsdb_loaict.Size = new System.Drawing.Size(150, 32);
            this.lb_hsdb_loaict.TabIndex = 11;
            this.lb_hsdb_loaict.Text = "Loại cầu thủ:";
            this.lb_hsdb_loaict.Visible = false;
            // 
            // tb_hsdb_mact
            // 
            this.tb_hsdb_mact.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_mact.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_mact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_mact.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_mact.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_mact.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_mact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hsdb_mact.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_mact.Location = new System.Drawing.Point(327, 111);
            this.tb_hsdb_mact.Name = "tb_hsdb_mact";
            this.tb_hsdb_mact.PasswordChar = '\0';
            this.tb_hsdb_mact.SelectedText = "";
            this.tb_hsdb_mact.Size = new System.Drawing.Size(160, 32);
            this.tb_hsdb_mact.TabIndex = 12;
            this.tb_hsdb_mact.Visible = false;
            // 
            // tb_hsdb_tenct
            // 
            this.tb_hsdb_tenct.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tenct.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_tenct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_tenct.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_tenct.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_tenct.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_tenct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hsdb_tenct.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_tenct.Location = new System.Drawing.Point(327, 170);
            this.tb_hsdb_tenct.Name = "tb_hsdb_tenct";
            this.tb_hsdb_tenct.PasswordChar = '\0';
            this.tb_hsdb_tenct.SelectedText = "";
            this.tb_hsdb_tenct.Size = new System.Drawing.Size(160, 32);
            this.tb_hsdb_tenct.TabIndex = 13;
            this.tb_hsdb_tenct.Visible = false;
            // 
            // tb_hsdb_ngsinh
            // 
            this.tb_hsdb_ngsinh.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_ngsinh.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_ngsinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_ngsinh.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_ngsinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_ngsinh.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_ngsinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hsdb_ngsinh.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_ngsinh.Location = new System.Drawing.Point(782, 111);
            this.tb_hsdb_ngsinh.Name = "tb_hsdb_ngsinh";
            this.tb_hsdb_ngsinh.PasswordChar = '\0';
            this.tb_hsdb_ngsinh.SelectedText = "";
            this.tb_hsdb_ngsinh.Size = new System.Drawing.Size(160, 32);
            this.tb_hsdb_ngsinh.TabIndex = 14;
            this.tb_hsdb_ngsinh.Visible = false;
            // 
            // tb_hsdb_loaict
            // 
            this.tb_hsdb_loaict.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_loaict.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_loaict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_loaict.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_loaict.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_loaict.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_loaict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hsdb_loaict.ForeColor = System.Drawing.Color.Black;
            this.tb_hsdb_loaict.Location = new System.Drawing.Point(782, 170);
            this.tb_hsdb_loaict.Name = "tb_hsdb_loaict";
            this.tb_hsdb_loaict.PasswordChar = '\0';
            this.tb_hsdb_loaict.SelectedText = "";
            this.tb_hsdb_loaict.Size = new System.Drawing.Size(160, 32);
            this.tb_hsdb_loaict.TabIndex = 15;
            this.tb_hsdb_loaict.Visible = false;
            // 
            // MaCauThu
            // 
            this.MaCauThu.DataPropertyName = "MaCauThu";
            this.MaCauThu.FillWeight = 5F;
            this.MaCauThu.HeaderText = "Mã Cầu Thủ";
            this.MaCauThu.Name = "MaCauThu";
            this.MaCauThu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenCauThu
            // 
            this.TenCauThu.DataPropertyName = "TenCauThu";
            this.TenCauThu.FillWeight = 20F;
            this.TenCauThu.HeaderText = "Tên Cầu Thủ";
            this.TenCauThu.Name = "TenCauThu";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 7F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenLoaiCauThu
            // 
            this.TenLoaiCauThu.DataPropertyName = "TenLoaiCauThu";
            this.TenLoaiCauThu.FillWeight = 5F;
            this.TenLoaiCauThu.HeaderText = "Tên Loại Cầu Thủ";
            this.TenLoaiCauThu.Name = "TenLoaiCauThu";
            // 
            // lb_hsdb_ghichu
            // 
            this.lb_hsdb_ghichu.AutoSize = true;
            this.lb_hsdb_ghichu.BackColor = System.Drawing.Color.Transparent;
            this.lb_hsdb_ghichu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hsdb_ghichu.ForeColor = System.Drawing.Color.Black;
            this.lb_hsdb_ghichu.Location = new System.Drawing.Point(619, 52);
            this.lb_hsdb_ghichu.Name = "lb_hsdb_ghichu";
            this.lb_hsdb_ghichu.Size = new System.Drawing.Size(102, 32);
            this.lb_hsdb_ghichu.TabIndex = 16;
            this.lb_hsdb_ghichu.Text = "Ghi chú:";
            this.lb_hsdb_ghichu.Visible = false;
            // 
            // tb_hsdb_ghichu
            // 
            this.tb_hsdb_ghichu.BaseColor = System.Drawing.Color.White;
            this.tb_hsdb_ghichu.BorderColor = System.Drawing.Color.Silver;
            this.tb_hsdb_ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_hsdb_ghichu.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_hsdb_ghichu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_hsdb_ghichu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_hsdb_ghichu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_hsdb_ghichu.Location = new System.Drawing.Point(782, 52);
            this.tb_hsdb_ghichu.Name = "tb_hsdb_ghichu";
            this.tb_hsdb_ghichu.PasswordChar = '\0';
            this.tb_hsdb_ghichu.SelectedText = "";
            this.tb_hsdb_ghichu.Size = new System.Drawing.Size(160, 32);
            this.tb_hsdb_ghichu.TabIndex = 17;
            this.tb_hsdb_ghichu.Visible = false;
            // 
            // btt_hsdb_capnhat
            // 
            this.btt_hsdb_capnhat.AnimationHoverSpeed = 0.07F;
            this.btt_hsdb_capnhat.AnimationSpeed = 0.03F;
            this.btt_hsdb_capnhat.BaseColor = System.Drawing.Color.Teal;
            this.btt_hsdb_capnhat.BorderColor = System.Drawing.Color.Black;
            this.btt_hsdb_capnhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_hsdb_capnhat.FocusedColor = System.Drawing.Color.Empty;
            this.btt_hsdb_capnhat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_hsdb_capnhat.ForeColor = System.Drawing.Color.Black;
            this.btt_hsdb_capnhat.Image = ((System.Drawing.Image)(resources.GetObject("btt_hsdb_capnhat.Image")));
            this.btt_hsdb_capnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_hsdb_capnhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_hsdb_capnhat.Location = new System.Drawing.Point(1064, 138);
            this.btt_hsdb_capnhat.Name = "btt_hsdb_capnhat";
            this.btt_hsdb_capnhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_hsdb_capnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_hsdb_capnhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_hsdb_capnhat.OnHoverImage = null;
            this.btt_hsdb_capnhat.OnPressedColor = System.Drawing.Color.Black;
            this.btt_hsdb_capnhat.Size = new System.Drawing.Size(169, 52);
            this.btt_hsdb_capnhat.TabIndex = 18;
            this.btt_hsdb_capnhat.Text = "Cập nhật";
            this.btt_hsdb_capnhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_hsdb_capnhat.Visible = false;
            this.btt_hsdb_capnhat.Click += new System.EventHandler(this.btt_hsdb_capnhat_Click);
            // 
            // usrTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btt_sua);
            this.Controls.Add(this.btt_Them);
            this.Controls.Add(this.Btt_xoa);
            this.Controls.Add(this.dgv_HSDB);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.lb_hsdb);
            this.Name = "usrTeam";
            this.Size = new System.Drawing.Size(1254, 679);
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
        public Guna.UI.WinForms.GunaTextBox tb_TenDoi;
        public Guna.UI.WinForms.GunaTextBox tb_MaDoi;
        public Guna.UI.WinForms.GunaDataGridView dgv_HSDB;
        private Guna.UI.WinForms.GunaButton btt_Team_View;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_loaict;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_ngsinh;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_Tenct;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_mact;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_loaict;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_ngsinh;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_tenct;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_mact;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCauThu;
        private Guna.UI.WinForms.GunaButton btt_hsdb_capnhat;
        public Guna.UI.WinForms.GunaTextBox tb_hsdb_ghichu;
        private Guna.UI.WinForms.GunaLabel lb_hsdb_ghichu;
    }
}
