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
            Guna.UI.WinForms.GunaLabel lb_player_id;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrPlayer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.tb_GhiChu = new Guna.UI.WinForms.GunaTextBox();
            this.cb_LoaiSoSanh = new Guna.UI.WinForms.GunaComboBox();
            this.nmc_BanThang = new Guna.UI.WinForms.GunaNumeric();
            this.nmc_TuoiMax = new Guna.UI.WinForms.GunaNumeric();
            this.nmc_TuoiMin = new Guna.UI.WinForms.GunaNumeric();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new Guna.UI.WinForms.GunaButton();
            this.cb_DoiBong = new Guna.UI.WinForms.GunaComboBox();
            this.cb_LoaiCT = new Guna.UI.WinForms.GunaComboBox();
            this.tb_HoTen = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaCT = new Guna.UI.WinForms.GunaTextBox();
            this.lb_player_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_player_type = new Guna.UI.WinForms.GunaLabel();
            this.lb_player_team = new Guna.UI.WinForms.GunaLabel();
            this.dgv_TCCT = new Guna.UI.WinForms.GunaDataGridView();
            lb_player_id = new Guna.UI.WinForms.GunaLabel();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCCT)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_player_id
            // 
            lb_player_id.AutoSize = true;
            lb_player_id.BackColor = System.Drawing.Color.Transparent;
            lb_player_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_player_id.ForeColor = System.Drawing.Color.Black;
            lb_player_id.Location = new System.Drawing.Point(141, 37);
            lb_player_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_player_id.Name = "lb_player_id";
            lb_player_id.Size = new System.Drawing.Size(111, 25);
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
            this.gunaButton1.Location = new System.Drawing.Point(2, 2);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(936, 60);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Tra cứu cầu thủ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.gunaButton2);
            this.gb_HSDB.Controls.Add(this.tb_GhiChu);
            this.gb_HSDB.Controls.Add(this.cb_LoaiSoSanh);
            this.gb_HSDB.Controls.Add(this.nmc_BanThang);
            this.gb_HSDB.Controls.Add(this.nmc_TuoiMax);
            this.gb_HSDB.Controls.Add(this.nmc_TuoiMin);
            this.gb_HSDB.Controls.Add(this.label5);
            this.gb_HSDB.Controls.Add(this.label4);
            this.gb_HSDB.Controls.Add(this.label3);
            this.gb_HSDB.Controls.Add(this.label2);
            this.gb_HSDB.Controls.Add(this.label1);
            this.gb_HSDB.Controls.Add(this.btn_TimKiem);
            this.gb_HSDB.Controls.Add(this.cb_DoiBong);
            this.gb_HSDB.Controls.Add(this.cb_LoaiCT);
            this.gb_HSDB.Controls.Add(this.tb_HoTen);
            this.gb_HSDB.Controls.Add(this.tb_MaCT);
            this.gb_HSDB.Controls.Add(this.lb_player_name);
            this.gb_HSDB.Controls.Add(this.lb_player_type);
            this.gb_HSDB.Controls.Add(this.lb_player_team);
            this.gb_HSDB.Controls.Add(lb_player_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(1, 65);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(936, 266);
            this.gb_HSDB.TabIndex = 2;
            this.gb_HSDB.Text = "Thông tin tìm kiếm";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Teal;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton2.Location = new System.Drawing.Point(800, 210);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(134, 34);
            this.gunaButton2.TabIndex = 19;
            this.gunaButton2.Text = "Hoàn tất";
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.BaseColor = System.Drawing.Color.White;
            this.tb_GhiChu.BorderColor = System.Drawing.Color.Silver;
            this.tb_GhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GhiChu.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_GhiChu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_GhiChu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_GhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_GhiChu.Location = new System.Drawing.Point(628, 164);
            this.tb_GhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.PasswordChar = '\0';
            this.tb_GhiChu.SelectedText = "";
            this.tb_GhiChu.Size = new System.Drawing.Size(181, 30);
            this.tb_GhiChu.TabIndex = 18;
            // 
            // cb_LoaiSoSanh
            // 
            this.cb_LoaiSoSanh.BackColor = System.Drawing.Color.Transparent;
            this.cb_LoaiSoSanh.BaseColor = System.Drawing.Color.White;
            this.cb_LoaiSoSanh.BorderColor = System.Drawing.Color.Silver;
            this.cb_LoaiSoSanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LoaiSoSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiSoSanh.FocusedColor = System.Drawing.Color.Empty;
            this.cb_LoaiSoSanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_LoaiSoSanh.ForeColor = System.Drawing.Color.Black;
            this.cb_LoaiSoSanh.FormattingEnabled = true;
            this.cb_LoaiSoSanh.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "="});
            this.cb_LoaiSoSanh.Location = new System.Drawing.Point(662, 128);
            this.cb_LoaiSoSanh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_LoaiSoSanh.Name = "cb_LoaiSoSanh";
            this.cb_LoaiSoSanh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_LoaiSoSanh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_LoaiSoSanh.Size = new System.Drawing.Size(87, 26);
            this.cb_LoaiSoSanh.TabIndex = 17;
            // 
            // nmc_BanThang
            // 
            this.nmc_BanThang.BaseColor = System.Drawing.Color.White;
            this.nmc_BanThang.BorderColor = System.Drawing.Color.Silver;
            this.nmc_BanThang.ButtonColor = System.Drawing.Color.Gray;
            this.nmc_BanThang.ButtonForeColor = System.Drawing.Color.White;
            this.nmc_BanThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmc_BanThang.ForeColor = System.Drawing.Color.Black;
            this.nmc_BanThang.Location = new System.Drawing.Point(752, 128);
            this.nmc_BanThang.Margin = new System.Windows.Forms.Padding(2);
            this.nmc_BanThang.Maximum = ((long)(9999999));
            this.nmc_BanThang.Minimum = ((long)(0));
            this.nmc_BanThang.Name = "nmc_BanThang";
            this.nmc_BanThang.Size = new System.Drawing.Size(56, 30);
            this.nmc_BanThang.TabIndex = 16;
            this.nmc_BanThang.Text = "gunaNumeric3";
            this.nmc_BanThang.Value = ((long)(0));
            // 
            // nmc_TuoiMax
            // 
            this.nmc_TuoiMax.BaseColor = System.Drawing.Color.White;
            this.nmc_TuoiMax.BorderColor = System.Drawing.Color.Silver;
            this.nmc_TuoiMax.ButtonColor = System.Drawing.Color.Gray;
            this.nmc_TuoiMax.ButtonForeColor = System.Drawing.Color.White;
            this.nmc_TuoiMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmc_TuoiMax.ForeColor = System.Drawing.Color.Black;
            this.nmc_TuoiMax.Location = new System.Drawing.Point(752, 85);
            this.nmc_TuoiMax.Margin = new System.Windows.Forms.Padding(2);
            this.nmc_TuoiMax.Maximum = ((long)(9999999));
            this.nmc_TuoiMax.Minimum = ((long)(0));
            this.nmc_TuoiMax.Name = "nmc_TuoiMax";
            this.nmc_TuoiMax.Size = new System.Drawing.Size(56, 30);
            this.nmc_TuoiMax.TabIndex = 15;
            this.nmc_TuoiMax.Text = "gunaNumeric2";
            this.nmc_TuoiMax.Value = ((long)(0));
            // 
            // nmc_TuoiMin
            // 
            this.nmc_TuoiMin.BaseColor = System.Drawing.Color.White;
            this.nmc_TuoiMin.BorderColor = System.Drawing.Color.Silver;
            this.nmc_TuoiMin.ButtonColor = System.Drawing.Color.Gray;
            this.nmc_TuoiMin.ButtonForeColor = System.Drawing.Color.White;
            this.nmc_TuoiMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmc_TuoiMin.ForeColor = System.Drawing.Color.Black;
            this.nmc_TuoiMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nmc_TuoiMin.Location = new System.Drawing.Point(637, 86);
            this.nmc_TuoiMin.Margin = new System.Windows.Forms.Padding(2);
            this.nmc_TuoiMin.Maximum = ((long)(9999999));
            this.nmc_TuoiMin.Minimum = ((long)(0));
            this.nmc_TuoiMin.Name = "nmc_TuoiMin";
            this.nmc_TuoiMin.Size = new System.Drawing.Size(56, 30);
            this.nmc_TuoiMin.TabIndex = 14;
            this.nmc_TuoiMin.Text = "gunaNumeric1";
            this.nmc_TuoiMin.Value = ((long)(0));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(705, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(607, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(530, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(530, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số bàn thắng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(530, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(646, 210);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.OnHoverImage = null;
            this.btn_TimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Size = new System.Drawing.Size(134, 34);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cb_DoiBong
            // 
            this.cb_DoiBong.BackColor = System.Drawing.Color.Transparent;
            this.cb_DoiBong.BaseColor = System.Drawing.Color.White;
            this.cb_DoiBong.BorderColor = System.Drawing.Color.Silver;
            this.cb_DoiBong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_DoiBong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DoiBong.FocusedColor = System.Drawing.Color.Empty;
            this.cb_DoiBong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_DoiBong.ForeColor = System.Drawing.Color.Black;
            this.cb_DoiBong.FormattingEnabled = true;
            this.cb_DoiBong.Location = new System.Drawing.Point(262, 169);
            this.cb_DoiBong.Margin = new System.Windows.Forms.Padding(2);
            this.cb_DoiBong.Name = "cb_DoiBong";
            this.cb_DoiBong.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_DoiBong.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_DoiBong.Size = new System.Drawing.Size(121, 26);
            this.cb_DoiBong.TabIndex = 7;
            this.cb_DoiBong.SelectionChangeCommitted += new System.EventHandler(this.cb_DoiBong_SelectionChangeCommitted);
            // 
            // cb_LoaiCT
            // 
            this.cb_LoaiCT.BackColor = System.Drawing.Color.Transparent;
            this.cb_LoaiCT.BaseColor = System.Drawing.Color.White;
            this.cb_LoaiCT.BorderColor = System.Drawing.Color.Silver;
            this.cb_LoaiCT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_LoaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiCT.FocusedColor = System.Drawing.Color.Empty;
            this.cb_LoaiCT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_LoaiCT.ForeColor = System.Drawing.Color.Black;
            this.cb_LoaiCT.FormattingEnabled = true;
            this.cb_LoaiCT.Items.AddRange(new object[] {
            "Tất cả các loại",
            "Trong nước",
            "Nước ngoài"});
            this.cb_LoaiCT.Location = new System.Drawing.Point(262, 124);
            this.cb_LoaiCT.Margin = new System.Windows.Forms.Padding(2);
            this.cb_LoaiCT.Name = "cb_LoaiCT";
            this.cb_LoaiCT.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_LoaiCT.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_LoaiCT.Size = new System.Drawing.Size(121, 26);
            this.cb_LoaiCT.TabIndex = 6;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.BaseColor = System.Drawing.Color.White;
            this.tb_HoTen.BorderColor = System.Drawing.Color.Silver;
            this.tb_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_HoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_HoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_HoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_HoTen.Location = new System.Drawing.Point(262, 80);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.PasswordChar = '\0';
            this.tb_HoTen.SelectedText = "";
            this.tb_HoTen.Size = new System.Drawing.Size(120, 30);
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
            this.tb_MaCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_MaCT.Location = new System.Drawing.Point(262, 37);
            this.tb_MaCT.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MaCT.Name = "tb_MaCT";
            this.tb_MaCT.PasswordChar = '\0';
            this.tb_MaCT.SelectedText = "";
            this.tb_MaCT.Size = new System.Drawing.Size(120, 30);
            this.tb_MaCT.TabIndex = 4;
            // 
            // lb_player_name
            // 
            this.lb_player_name.AutoSize = true;
            this.lb_player_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_name.ForeColor = System.Drawing.Color.Black;
            this.lb_player_name.Location = new System.Drawing.Point(141, 80);
            this.lb_player_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_player_name.Name = "lb_player_name";
            this.lb_player_name.Size = new System.Drawing.Size(96, 25);
            this.lb_player_name.TabIndex = 3;
            this.lb_player_name.Text = "Họ và tên:";
            // 
            // lb_player_type
            // 
            this.lb_player_type.AutoSize = true;
            this.lb_player_type.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_type.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_type.ForeColor = System.Drawing.Color.Black;
            this.lb_player_type.Location = new System.Drawing.Point(141, 124);
            this.lb_player_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_player_type.Name = "lb_player_type";
            this.lb_player_type.Size = new System.Drawing.Size(119, 25);
            this.lb_player_type.TabIndex = 2;
            this.lb_player_type.Text = "Loại cầu thủ:";
            // 
            // lb_player_team
            // 
            this.lb_player_team.AutoSize = true;
            this.lb_player_team.BackColor = System.Drawing.Color.Transparent;
            this.lb_player_team.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_player_team.ForeColor = System.Drawing.Color.Black;
            this.lb_player_team.Location = new System.Drawing.Point(141, 166);
            this.lb_player_team.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_player_team.Name = "lb_player_team";
            this.lb_player_team.Size = new System.Drawing.Size(94, 25);
            this.lb_player_team.TabIndex = 1;
            this.lb_player_team.Text = "Đội bóng:";
            // 
            // dgv_TCCT
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_TCCT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TCCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TCCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TCCT.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_TCCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TCCT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TCCT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TCCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TCCT.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TCCT.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TCCT.EnableHeadersVisualStyles = false;
            this.dgv_TCCT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.Location = new System.Drawing.Point(2, 336);
            this.dgv_TCCT.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TCCT.Name = "dgv_TCCT";
            this.dgv_TCCT.RowHeadersVisible = false;
            this.dgv_TCCT.RowTemplate.Height = 24;
            this.dgv_TCCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TCCT.Size = new System.Drawing.Size(936, 228);
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
            this.dgv_TCCT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TCCT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TCCT.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_TCCT.ThemeStyle.ReadOnly = false;
            this.dgv_TCCT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TCCT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TCCT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TCCT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TCCT.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_TCCT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TCCT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // usrPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_TCCT);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "usrPlayer";
            this.Size = new System.Drawing.Size(940, 566);
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
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaNumeric nmc_BanThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgv_TCCT;
        public Guna.UI.WinForms.GunaComboBox cb_DoiBong;
        public Guna.UI.WinForms.GunaComboBox cb_LoaiCT;
        public Guna.UI.WinForms.GunaTextBox tb_HoTen;
        public Guna.UI.WinForms.GunaTextBox tb_MaCT;
        public Guna.UI.WinForms.GunaTextBox tb_GhiChu;
        public Guna.UI.WinForms.GunaComboBox cb_LoaiSoSanh;
        public Guna.UI.WinForms.GunaNumeric nmc_TuoiMax;
        public Guna.UI.WinForms.GunaNumeric nmc_TuoiMin;
    }
}
