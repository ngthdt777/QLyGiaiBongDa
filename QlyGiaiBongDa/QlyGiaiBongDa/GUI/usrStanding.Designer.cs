namespace QlyGiaiBongDa.GUI
{
    partial class usrStanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrStanding));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.dgv_BXH = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_TimKiem = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btn_XuatBaocao = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtp_Bangxephang = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tb_doichunha = new System.Windows.Forms.TextBox();
            this.tb_doikhach = new System.Windows.Forms.TextBox();
            this.tb_tyso = new System.Windows.Forms.TextBox();
            this.tb_mtd = new System.Windows.Forms.TextBox();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BXH)).BeginInit();
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
            this.gunaButton1.Location = new System.Drawing.Point(3, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 70);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Bảng xếp hạng";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.tb_mtd);
            this.gb_HSDB.Controls.Add(this.tb_tyso);
            this.gb_HSDB.Controls.Add(this.tb_doikhach);
            this.gb_HSDB.Controls.Add(this.tb_doichunha);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Controls.Add(this.dtp_Bangxephang);
            this.gb_HSDB.Controls.Add(this.btn_TimKiem);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.ForeColor = System.Drawing.Color.Black;
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 76);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 475);
            this.gb_HSDB.TabIndex = 3;
            this.gb_HSDB.Text = "Thông tin bản xếp hạng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgv_BXH
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_BXH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_BXH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BXH.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_BXH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BXH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BXH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BXH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_BXH.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BXH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_BXH.EnableHeadersVisualStyles = false;
            this.dgv_BXH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH.Location = new System.Drawing.Point(3, 557);
            this.dgv_BXH.Name = "dgv_BXH";
            this.dgv_BXH.RowHeadersVisible = false;
            this.dgv_BXH.RowTemplate.Height = 24;
            this.dgv_BXH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BXH.Size = new System.Drawing.Size(1251, 54);
            this.dgv_BXH.TabIndex = 4;
            this.dgv_BXH.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_BXH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_BXH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_BXH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_BXH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_BXH.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgv_BXH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_BXH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BXH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_BXH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_BXH.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_BXH.ThemeStyle.ReadOnly = false;
            this.dgv_BXH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BXH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_BXH.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_BXH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem.AnimationSpeed = 0.03F;
            this.btn_TimKiem.BaseColor = System.Drawing.Color.White;
            this.btn_TimKiem.BorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TimKiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_TimKiem.Location = new System.Drawing.Point(896, 58);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.OnHoverImage = null;
            this.btn_TimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Size = new System.Drawing.Size(60, 42);
            this.btn_TimKiem.TabIndex = 9;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
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
            this.gunaButton2.Location = new System.Drawing.Point(824, 629);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(179, 42);
            this.gunaButton2.TabIndex = 20;
            this.gunaButton2.Text = "Hoàn tất";
            // 
            // btn_XuatBaocao
            // 
            this.btn_XuatBaocao.AnimationHoverSpeed = 0.07F;
            this.btn_XuatBaocao.AnimationSpeed = 0.03F;
            this.btn_XuatBaocao.BaseColor = System.Drawing.Color.Teal;
            this.btn_XuatBaocao.BorderColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_XuatBaocao.FocusedColor = System.Drawing.Color.Empty;
            this.btn_XuatBaocao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatBaocao.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatBaocao.Image")));
            this.btn_XuatBaocao.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_XuatBaocao.Location = new System.Drawing.Point(1033, 629);
            this.btn_XuatBaocao.Name = "btn_XuatBaocao";
            this.btn_XuatBaocao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XuatBaocao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XuatBaocao.OnHoverImage = null;
            this.btn_XuatBaocao.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.Size = new System.Drawing.Size(208, 42);
            this.btn_XuatBaocao.TabIndex = 21;
            this.btn_XuatBaocao.Text = "Xuất báo cáo";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(331, 58);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(219, 50);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Ngày xếp hạng";
            // 
            // dtp_Bangxephang
            // 
            this.dtp_Bangxephang.BaseColor = System.Drawing.Color.White;
            this.dtp_Bangxephang.BorderColor = System.Drawing.Color.Silver;
            this.dtp_Bangxephang.CustomFormat = null;
            this.dtp_Bangxephang.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Bangxephang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_Bangxephang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bangxephang.ForeColor = System.Drawing.Color.Black;
            this.dtp_Bangxephang.Location = new System.Drawing.Point(600, 67);
            this.dtp_Bangxephang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Bangxephang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Bangxephang.Name = "dtp_Bangxephang";
            this.dtp_Bangxephang.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_Bangxephang.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_Bangxephang.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp_Bangxephang.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_Bangxephang.Size = new System.Drawing.Size(290, 30);
            this.dtp_Bangxephang.TabIndex = 0;
            this.dtp_Bangxephang.Text = "Tuesday, June 9, 2020";
            this.dtp_Bangxephang.Value = new System.DateTime(2020, 6, 9, 0, 5, 1, 781);
            // 
            // tb_doichunha
            // 
            this.tb_doichunha.Location = new System.Drawing.Point(319, 135);
            this.tb_doichunha.Name = "tb_doichunha";
            this.tb_doichunha.Size = new System.Drawing.Size(100, 28);
            this.tb_doichunha.TabIndex = 10;
            // 
            // tb_doikhach
            // 
            this.tb_doikhach.Location = new System.Drawing.Point(532, 135);
            this.tb_doikhach.Name = "tb_doikhach";
            this.tb_doikhach.Size = new System.Drawing.Size(100, 28);
            this.tb_doikhach.TabIndex = 11;
            // 
            // tb_tyso
            // 
            this.tb_tyso.Location = new System.Drawing.Point(733, 135);
            this.tb_tyso.Name = "tb_tyso";
            this.tb_tyso.Size = new System.Drawing.Size(100, 28);
            this.tb_tyso.TabIndex = 12;
            // 
            // tb_mtd
            // 
            this.tb_mtd.Location = new System.Drawing.Point(128, 135);
            this.tb_mtd.Name = "tb_mtd";
            this.tb_mtd.Size = new System.Drawing.Size(100, 28);
            this.tb_mtd.TabIndex = 13;
            this.tb_mtd.TextChanged += new System.EventHandler(this.tb_mtd_TextChanged);
            // 
            // usrStanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XuatBaocao);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.dgv_BXH);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Name = "usrStanding";
            this.Size = new System.Drawing.Size(1254, 697);
            this.Load += new System.EventHandler(this.usrStanding_Load);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BXH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaDataGridView dgv_BXH;
        private Guna.UI.WinForms.GunaButton btn_TimKiem;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton btn_XuatBaocao;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_Bangxephang;
        public System.Windows.Forms.TextBox tb_mtd;
        public System.Windows.Forms.TextBox tb_doichunha;
        public System.Windows.Forms.TextBox tb_tyso;
        public System.Windows.Forms.TextBox tb_doikhach;
    }
}
