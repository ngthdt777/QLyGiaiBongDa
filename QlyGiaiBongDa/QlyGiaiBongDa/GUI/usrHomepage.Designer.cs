namespace QlyGiaiBongDa.GUI
{
    partial class usrHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrHomepage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btt_team_view = new Guna.UI.WinForms.GunaGradientButton();
            this.btt_team_add = new Guna.UI.WinForms.GunaGradientButton();
            this.btt_team_era = new Guna.UI.WinForms.GunaGradientButton();
            this.btt_team_fix = new Guna.UI.WinForms.GunaGradientButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.cb_Team_slgct = new Guna.UI.WinForms.GunaComboBox();
            this.tb_SanNha = new Guna.UI.WinForms.GunaTextBox();
            this.tb_TenDoi = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaDoi = new Guna.UI.WinForms.GunaTextBox();
            this.lb_team_slg = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_san = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_id = new Guna.UI.WinForms.GunaLabel();
            this.dgv_Home = new Guna.UI.WinForms.GunaDataGridView();
            this.MaDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_team_view
            // 
            this.btt_team_view.AnimationHoverSpeed = 0.07F;
            this.btt_team_view.AnimationSpeed = 0.03F;
            this.btt_team_view.BaseColor1 = System.Drawing.Color.Teal;
            this.btt_team_view.BaseColor2 = System.Drawing.Color.Teal;
            this.btt_team_view.BorderColor = System.Drawing.Color.Black;
            this.btt_team_view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_team_view.FocusedColor = System.Drawing.Color.Empty;
            this.btt_team_view.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_team_view.ForeColor = System.Drawing.Color.Black;
            this.btt_team_view.Image = ((System.Drawing.Image)(resources.GetObject("btt_team_view.Image")));
            this.btt_team_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_view.ImageSize = new System.Drawing.Size(20, 20);
            this.btt_team_view.Location = new System.Drawing.Point(1070, 49);
            this.btt_team_view.Name = "btt_team_view";
            this.btt_team_view.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btt_team_view.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btt_team_view.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_team_view.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_team_view.OnHoverImage = null;
            this.btt_team_view.OnPressedColor = System.Drawing.Color.Black;
            this.btt_team_view.Size = new System.Drawing.Size(161, 49);
            this.btt_team_view.TabIndex = 7;
            this.btt_team_view.Text = "Hiển thị";
            this.btt_team_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_view.Click += new System.EventHandler(this.btt_team_view_Click);
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
            this.btt_team_add.Location = new System.Drawing.Point(1070, 104);
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
            this.btt_team_add.Visible = false;
            this.btt_team_add.Click += new System.EventHandler(this.btt_team_add_Click);
           
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
            this.btt_team_era.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_team_era.ForeColor = System.Drawing.Color.Black;
            this.btt_team_era.Image = ((System.Drawing.Image)(resources.GetObject("btt_team_era.Image")));
            this.btt_team_era.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_era.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_team_era.Location = new System.Drawing.Point(1070, 159);
            this.btt_team_era.Name = "btt_team_era";
            this.btt_team_era.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btt_team_era.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btt_team_era.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_team_era.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_team_era.OnHoverImage = null;
            this.btt_team_era.OnPressedColor = System.Drawing.Color.Black;
            this.btt_team_era.Size = new System.Drawing.Size(161, 49);
            this.btt_team_era.TabIndex = 9;
            this.btt_team_era.Text = "Xóa";
            this.btt_team_era.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_era.Visible = false;
            this.btt_team_era.Click += new System.EventHandler(this.btt_team_era_Click);
            // 
            // btt_team_fix
            // 
            this.btt_team_fix.AnimationHoverSpeed = 0.07F;
            this.btt_team_fix.AnimationSpeed = 0.03F;
            this.btt_team_fix.BaseColor1 = System.Drawing.Color.Teal;
            this.btt_team_fix.BaseColor2 = System.Drawing.Color.Teal;
            this.btt_team_fix.BorderColor = System.Drawing.Color.Black;
            this.btt_team_fix.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_team_fix.FocusedColor = System.Drawing.Color.Empty;
            this.btt_team_fix.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_team_fix.ForeColor = System.Drawing.Color.Black;
            this.btt_team_fix.Image = ((System.Drawing.Image)(resources.GetObject("btt_team_fix.Image")));
            this.btt_team_fix.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_fix.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_team_fix.Location = new System.Drawing.Point(1070, 214);
            this.btt_team_fix.Name = "btt_team_fix";
            this.btt_team_fix.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btt_team_fix.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btt_team_fix.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_team_fix.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_team_fix.OnHoverImage = null;
            this.btt_team_fix.OnPressedColor = System.Drawing.Color.Black;
            this.btt_team_fix.Size = new System.Drawing.Size(161, 49);
            this.btt_team_fix.TabIndex = 10;
            this.btt_team_fix.Text = "Sửa";
            this.btt_team_fix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_team_fix.Visible = false;
            this.btt_team_fix.Click += new System.EventHandler(this.btt_team_fix_Click);
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.cb_Team_slgct);
            this.gb_HSDB.Controls.Add(this.tb_SanNha);
            this.gb_HSDB.Controls.Add(this.btt_team_view);
            this.gb_HSDB.Controls.Add(this.btt_team_fix);
            this.gb_HSDB.Controls.Add(this.tb_TenDoi);
            this.gb_HSDB.Controls.Add(this.btt_team_era);
            this.gb_HSDB.Controls.Add(this.btt_team_add);
            this.gb_HSDB.Controls.Add(this.tb_MaDoi);
            this.gb_HSDB.Controls.Add(this.lb_team_slg);
            this.gb_HSDB.Controls.Add(this.lb_team_san);
            this.gb_HSDB.Controls.Add(this.lb_team_name);
            this.gb_HSDB.Controls.Add(this.lb_team_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.ForeColor = System.Drawing.Color.Black;
            this.gb_HSDB.LineColor = System.Drawing.Color.Teal;
            this.gb_HSDB.LineTop = 34;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 3);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 279);
            this.gb_HSDB.TabIndex = 11;
            this.gb_HSDB.Text = "Thông tin đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cb_Team_slgct
            // 
            this.cb_Team_slgct.BackColor = System.Drawing.Color.Transparent;
            this.cb_Team_slgct.BaseColor = System.Drawing.Color.White;
            this.cb_Team_slgct.BorderColor = System.Drawing.Color.Silver;
            this.cb_Team_slgct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Team_slgct.DropDownHeight = 200;
            this.cb_Team_slgct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Team_slgct.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Team_slgct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Team_slgct.ForeColor = System.Drawing.Color.Black;
            this.cb_Team_slgct.FormattingEnabled = true;
            this.cb_Team_slgct.IntegralHeight = false;
            this.cb_Team_slgct.Items.AddRange(new object[] {
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
            "40"});
            this.cb_Team_slgct.Location = new System.Drawing.Point(329, 163);
            this.cb_Team_slgct.Name = "cb_Team_slgct";
            this.cb_Team_slgct.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_Team_slgct.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_Team_slgct.Size = new System.Drawing.Size(78, 31);
            this.cb_Team_slgct.TabIndex = 11;
            this.cb_Team_slgct.Visible = false;
            // 
            // tb_SanNha
            // 
            this.tb_SanNha.BaseColor = System.Drawing.Color.White;
            this.tb_SanNha.BorderColor = System.Drawing.Color.Silver;
            this.tb_SanNha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SanNha.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_SanNha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_SanNha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_SanNha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_SanNha.Location = new System.Drawing.Point(755, 159);
            this.tb_SanNha.Name = "tb_SanNha";
            this.tb_SanNha.PasswordChar = '\0';
            this.tb_SanNha.SelectedText = "";
            this.tb_SanNha.Size = new System.Drawing.Size(160, 32);
            this.tb_SanNha.TabIndex = 7;
            this.tb_SanNha.Visible = false;
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
            this.tb_TenDoi.Location = new System.Drawing.Point(755, 104);
            this.tb_TenDoi.Name = "tb_TenDoi";
            this.tb_TenDoi.PasswordChar = '\0';
            this.tb_TenDoi.SelectedText = "";
            this.tb_TenDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_TenDoi.TabIndex = 6;
            this.tb_TenDoi.Visible = false;
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
            this.tb_MaDoi.Location = new System.Drawing.Point(329, 104);
            this.tb_MaDoi.Name = "tb_MaDoi";
            this.tb_MaDoi.PasswordChar = '\0';
            this.tb_MaDoi.SelectedText = "";
            this.tb_MaDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_MaDoi.TabIndex = 4;
            this.tb_MaDoi.Visible = false;
            // 
            // lb_team_slg
            // 
            this.lb_team_slg.AutoSize = true;
            this.lb_team_slg.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_slg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_slg.ForeColor = System.Drawing.Color.Black;
            this.lb_team_slg.Location = new System.Drawing.Point(179, 159);
            this.lb_team_slg.Name = "lb_team_slg";
            this.lb_team_slg.Size = new System.Drawing.Size(142, 32);
            this.lb_team_slg.TabIndex = 3;
            this.lb_team_slg.Text = "Số cầu thủ:";
            this.lb_team_slg.Visible = false;
            // 
            // lb_team_san
            // 
            this.lb_team_san.AutoSize = true;
            this.lb_team_san.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_san.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_san.ForeColor = System.Drawing.Color.Black;
            this.lb_team_san.Location = new System.Drawing.Point(620, 159);
            this.lb_team_san.Name = "lb_team_san";
            this.lb_team_san.Size = new System.Drawing.Size(112, 32);
            this.lb_team_san.TabIndex = 2;
            this.lb_team_san.Text = "Sân nhà:";
            this.lb_team_san.Visible = false;
            // 
            // lb_team_name
            // 
            this.lb_team_name.AutoSize = true;
            this.lb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_name.ForeColor = System.Drawing.Color.Black;
            this.lb_team_name.Location = new System.Drawing.Point(620, 104);
            this.lb_team_name.Name = "lb_team_name";
            this.lb_team_name.Size = new System.Drawing.Size(106, 32);
            this.lb_team_name.TabIndex = 1;
            this.lb_team_name.Text = "Tên đội:";
            this.lb_team_name.Visible = false;
            // 
            // lb_team_id
            // 
            this.lb_team_id.AutoSize = true;
            this.lb_team_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_id.ForeColor = System.Drawing.Color.Black;
            this.lb_team_id.Location = new System.Drawing.Point(179, 104);
            this.lb_team_id.Name = "lb_team_id";
            this.lb_team_id.Size = new System.Drawing.Size(102, 32);
            this.lb_team_id.TabIndex = 0;
            this.lb_team_id.Text = "Mã đội:";
            this.lb_team_id.Visible = false;
            // 
            // dgv_Home
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_Home.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Home.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Home.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_Home.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Home.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Home.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Home.ColumnHeadersHeight = 30;
            this.dgv_Home.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoi,
            this.TenDoi,
            this.SoCauThu,
            this.SanNha});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Home.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Home.EnableHeadersVisualStyles = false;
            this.dgv_Home.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Home.Location = new System.Drawing.Point(3, 288);
            this.dgv_Home.Name = "dgv_Home";
            this.dgv_Home.RowHeadersVisible = false;
            this.dgv_Home.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Home.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Home.RowTemplate.Height = 24;
            this.dgv_Home.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Home.Size = new System.Drawing.Size(1248, 406);
            this.dgv_Home.TabIndex = 12;
            this.dgv_Home.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Home.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Home.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Home.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Home.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Home.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Home.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgv_Home.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Home.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Home.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_Home.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Home.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Home.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Home.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Home.ThemeStyle.ReadOnly = false;
            this.dgv_Home.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Home.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Home.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Home.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Home.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Home.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Home.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Home.Visible = false;
            this.dgv_Home.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Home_CellContentClick);
            this.dgv_Home.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Home_CellContentClick);
            // 
            // MaDoi
            // 
            this.MaDoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.FillWeight = 30F;
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            this.MaDoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaDoi.Width = 120;
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.FillWeight = 40F;
            this.TenDoi.HeaderText = "Tên Đội";
            this.TenDoi.Name = "TenDoi";
            this.TenDoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SoCauThu
            // 
            this.SoCauThu.DataPropertyName = "SoCauThu";
            this.SoCauThu.FillWeight = 30F;
            this.SoCauThu.HeaderText = "Số Cầu Thủ";
            this.SoCauThu.Name = "SoCauThu";
            this.SoCauThu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SanNha
            // 
            this.SanNha.DataPropertyName = "SanNha";
            this.SanNha.FillWeight = 30F;
            this.SanNha.HeaderText = "Sân Nhà";
            this.SanNha.Name = "SanNha";
            this.SanNha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usrHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Home);
            this.Controls.Add(this.gb_HSDB);
            this.Name = "usrHomepage";
            this.Size = new System.Drawing.Size(1254, 697);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton btt_team_view;
        private Guna.UI.WinForms.GunaGradientButton btt_team_add;
        private Guna.UI.WinForms.GunaGradientButton btt_team_era;
        private Guna.UI.WinForms.GunaGradientButton btt_team_fix;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        public Guna.UI.WinForms.GunaTextBox tb_SanNha;
        public Guna.UI.WinForms.GunaTextBox tb_TenDoi;
        public Guna.UI.WinForms.GunaTextBox tb_MaDoi;
        private Guna.UI.WinForms.GunaLabel lb_team_slg;
        private Guna.UI.WinForms.GunaLabel lb_team_san;
        private Guna.UI.WinForms.GunaLabel lb_team_name;
        private Guna.UI.WinForms.GunaLabel lb_team_id;
        public Guna.UI.WinForms.GunaDataGridView dgv_Home;
        public Guna.UI.WinForms.GunaComboBox cb_Team_slgct;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanNha;
    }
}
