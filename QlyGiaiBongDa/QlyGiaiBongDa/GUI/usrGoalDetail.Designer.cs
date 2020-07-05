namespace QlyGiaiBongDa.GUI
{
    partial class usrGoalDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrGoalDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tb_MaTranDau = new Guna.UI.WinForms.GunaTextBox();
            this.tb_ThoiDiem = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaLoaiBanThang = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaCauThu = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaBanThang = new Guna.UI.WinForms.GunaTextBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.dgv_CTBT = new Guna.UI.WinForms.GunaDataGridView();
            this.MaBanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiBanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTranDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btt_Them = new Guna.UI.WinForms.GunaButton();
            this.Btt_xoa = new Guna.UI.WinForms.GunaButton();
            this.Btt_sua = new Guna.UI.WinForms.GunaButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTBT)).BeginInit();
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
            this.gunaButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaButton1.Location = new System.Drawing.Point(0, 3);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 72);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Chi tiết bàn thắng";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.cb1);
            this.gb_HSDB.Controls.Add(this.tb_MaTranDau);
            this.gb_HSDB.Controls.Add(this.tb_ThoiDiem);
            this.gb_HSDB.Controls.Add(this.tb_MaLoaiBanThang);
            this.gb_HSDB.Controls.Add(this.tb_MaCauThu);
            this.gb_HSDB.Controls.Add(this.tb_MaBanThang);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 81);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 194);
            this.gb_HSDB.TabIndex = 5;
            this.gb_HSDB.Text = "Chi tiết bàn thắng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(743, 59);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(216, 30);
            this.cb1.TabIndex = 5;
            // 
            // tb_MaTranDau
            // 
            this.tb_MaTranDau.BackColor = System.Drawing.Color.Black;
            this.tb_MaTranDau.BaseColor = System.Drawing.Color.White;
            this.tb_MaTranDau.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaTranDau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaTranDau.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaTranDau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaTranDau.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaTranDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaTranDau.ForeColor = System.Drawing.Color.Black;
            this.tb_MaTranDau.Location = new System.Drawing.Point(743, 125);
            this.tb_MaTranDau.Name = "tb_MaTranDau";
            this.tb_MaTranDau.PasswordChar = '\0';
            this.tb_MaTranDau.SelectedText = "";
            this.tb_MaTranDau.Size = new System.Drawing.Size(216, 47);
            this.tb_MaTranDau.TabIndex = 4;
            this.tb_MaTranDau.Text = "Mã Trận Đấu";
            // 
            // tb_ThoiDiem
            // 
            this.tb_ThoiDiem.BackColor = System.Drawing.Color.Black;
            this.tb_ThoiDiem.BaseColor = System.Drawing.Color.White;
            this.tb_ThoiDiem.BorderColor = System.Drawing.Color.Silver;
            this.tb_ThoiDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ThoiDiem.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_ThoiDiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_ThoiDiem.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_ThoiDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThoiDiem.ForeColor = System.Drawing.Color.Black;
            this.tb_ThoiDiem.Location = new System.Drawing.Point(507, 125);
            this.tb_ThoiDiem.Name = "tb_ThoiDiem";
            this.tb_ThoiDiem.PasswordChar = '\0';
            this.tb_ThoiDiem.SelectedText = "";
            this.tb_ThoiDiem.Size = new System.Drawing.Size(216, 47);
            this.tb_ThoiDiem.TabIndex = 3;
            this.tb_ThoiDiem.Text = "Thời điểm";
            // 
            // tb_MaLoaiBanThang
            // 
            this.tb_MaLoaiBanThang.BackColor = System.Drawing.Color.Black;
            this.tb_MaLoaiBanThang.BaseColor = System.Drawing.Color.White;
            this.tb_MaLoaiBanThang.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaLoaiBanThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaLoaiBanThang.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaLoaiBanThang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaLoaiBanThang.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaLoaiBanThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaLoaiBanThang.ForeColor = System.Drawing.Color.Black;
            this.tb_MaLoaiBanThang.Location = new System.Drawing.Point(507, 59);
            this.tb_MaLoaiBanThang.Name = "tb_MaLoaiBanThang";
            this.tb_MaLoaiBanThang.PasswordChar = '\0';
            this.tb_MaLoaiBanThang.SelectedText = "";
            this.tb_MaLoaiBanThang.Size = new System.Drawing.Size(216, 47);
            this.tb_MaLoaiBanThang.TabIndex = 2;
            this.tb_MaLoaiBanThang.Text = "Loại bàn thắng";
            // 
            // tb_MaCauThu
            // 
            this.tb_MaCauThu.BackColor = System.Drawing.Color.Black;
            this.tb_MaCauThu.BaseColor = System.Drawing.Color.White;
            this.tb_MaCauThu.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaCauThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaCauThu.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaCauThu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaCauThu.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaCauThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaCauThu.ForeColor = System.Drawing.Color.Black;
            this.tb_MaCauThu.Location = new System.Drawing.Point(206, 125);
            this.tb_MaCauThu.Name = "tb_MaCauThu";
            this.tb_MaCauThu.PasswordChar = '\0';
            this.tb_MaCauThu.SelectedText = "";
            this.tb_MaCauThu.Size = new System.Drawing.Size(216, 47);
            this.tb_MaCauThu.TabIndex = 1;
            this.tb_MaCauThu.Text = "Mã Cầu Thủ";
            // 
            // tb_MaBanThang
            // 
            this.tb_MaBanThang.BackColor = System.Drawing.Color.Black;
            this.tb_MaBanThang.BaseColor = System.Drawing.Color.White;
            this.tb_MaBanThang.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaBanThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaBanThang.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaBanThang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaBanThang.FocusedForeColor = System.Drawing.Color.Black;
            this.tb_MaBanThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaBanThang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_MaBanThang.Location = new System.Drawing.Point(206, 59);
            this.tb_MaBanThang.Name = "tb_MaBanThang";
            this.tb_MaBanThang.PasswordChar = '\0';
            this.tb_MaBanThang.SelectedText = "";
            this.tb_MaBanThang.Size = new System.Drawing.Size(216, 47);
            this.tb_MaBanThang.TabIndex = 0;
            this.tb_MaBanThang.Text = "Mã bàn thắng";
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv_CTBT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_CTBT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CTBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CTBT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTBT.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CTBT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_CTBT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CTBT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CTBT.ColumnHeadersHeight = 35;
            this.dgv_CTBT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBanThang,
            this.MaCauThu,
            this.MaLoaiBanThang,
            this.ThoiDiem,
            this.MaTranDau});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CTBT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CTBT.EnableHeadersVisualStyles = false;
            this.dgv_CTBT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CTBT.Location = new System.Drawing.Point(-3, 281);
            this.dgv_CTBT.Name = "dgv_CTBT";
            this.dgv_CTBT.RowHeadersVisible = false;
            this.dgv_CTBT.RowTemplate.Height = 24;
            this.dgv_CTBT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CTBT.Size = new System.Drawing.Size(1251, 312);
            this.dgv_CTBT.TabIndex = 11;
            this.dgv_CTBT.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_CTBT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CTBT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_CTBT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_CTBT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_CTBT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_CTBT.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CTBT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CTBT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_CTBT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_CTBT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_CTBT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_CTBT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_CTBT.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_CTBT.ThemeStyle.ReadOnly = false;
            this.dgv_CTBT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CTBT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_CTBT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_CTBT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_CTBT.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_CTBT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CTBT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_CTBT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTBT_CellContentClick);
            // 
            // MaBanThang
            // 
            this.MaBanThang.DataPropertyName = "MaBanThang";
            this.MaBanThang.FillWeight = 40F;
            this.MaBanThang.HeaderText = "Mã Bàn Thắng";
            this.MaBanThang.Name = "MaBanThang";
            // 
            // MaCauThu
            // 
            this.MaCauThu.DataPropertyName = "MaCauThu";
            this.MaCauThu.FillWeight = 50F;
            this.MaCauThu.HeaderText = "Mã Cầu Thủ";
            this.MaCauThu.Name = "MaCauThu";
            // 
            // MaLoaiBanThang
            // 
            this.MaLoaiBanThang.DataPropertyName = "MaLoaiBanThang";
            this.MaLoaiBanThang.FillWeight = 40F;
            this.MaLoaiBanThang.HeaderText = "Loại Bàn Thắng";
            this.MaLoaiBanThang.Name = "MaLoaiBanThang";
            // 
            // ThoiDiem
            // 
            this.ThoiDiem.DataPropertyName = "ThoiDiem";
            this.ThoiDiem.HeaderText = "Thời Điểm";
            this.ThoiDiem.Name = "ThoiDiem";
            // 
            // MaTranDau
            // 
            this.MaTranDau.DataPropertyName = "MaTranDau";
            this.MaTranDau.HeaderText = "Mã Trận Đấu";
            this.MaTranDau.Name = "MaTranDau";
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
            this.btt_Them.Location = new System.Drawing.Point(698, 609);
            this.btt_Them.Name = "btt_Them";
            this.btt_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Them.OnHoverImage = null;
            this.btt_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Them.Size = new System.Drawing.Size(169, 52);
            this.btt_Them.TabIndex = 12;
            this.btt_Them.Text = "Thêm";
            this.btt_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Them.Click += new System.EventHandler(this.btt_Them_Click);
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
            this.Btt_xoa.Location = new System.Drawing.Point(886, 609);
            this.Btt_xoa.Name = "Btt_xoa";
            this.Btt_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_xoa.OnHoverImage = null;
            this.Btt_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_xoa.Size = new System.Drawing.Size(169, 52);
            this.Btt_xoa.TabIndex = 13;
            this.Btt_xoa.Text = "Xoá";
            this.Btt_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_xoa.Click += new System.EventHandler(this.Btt_xoa_Click);
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
            this.Btt_sua.Location = new System.Drawing.Point(1070, 609);
            this.Btt_sua.Name = "Btt_sua";
            this.Btt_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btt_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btt_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.Btt_sua.OnHoverImage = null;
            this.Btt_sua.OnPressedColor = System.Drawing.Color.Black;
            this.Btt_sua.Size = new System.Drawing.Size(169, 52);
            this.Btt_sua.TabIndex = 14;
            this.Btt_sua.Text = "Sửa";
            this.Btt_sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btt_sua.Click += new System.EventHandler(this.Btt_sua_Click);
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(1121, 37);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(115, 25);
            this.lb_Guide.TabIndex = 24;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
            // 
            // usrGoalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btt_sua);
            this.Controls.Add(this.Btt_xoa);
            this.Controls.Add(this.btt_Them);
            this.Controls.Add(this.dgv_CTBT);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Name = "usrGoalDetail";
            this.Size = new System.Drawing.Size(1254, 697);
            this.Load += new System.EventHandler(this.usrGoalDetail_Load_1);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        public Guna.UI.WinForms.GunaDataGridView dgv_CTBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiBanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTranDau;
        public Guna.UI.WinForms.GunaTextBox tb_MaTranDau;
        public Guna.UI.WinForms.GunaTextBox tb_ThoiDiem;
        public Guna.UI.WinForms.GunaTextBox tb_MaCauThu;
        public Guna.UI.WinForms.GunaTextBox tb_MaBanThang;
        public Guna.UI.WinForms.GunaButton btt_Them;
        public Guna.UI.WinForms.GunaButton Btt_xoa;
        public Guna.UI.WinForms.GunaButton Btt_sua;
        public Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public Guna.UI.WinForms.GunaTextBox tb_MaLoaiBanThang;
        public System.Windows.Forms.ComboBox cb1;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
    }
}
