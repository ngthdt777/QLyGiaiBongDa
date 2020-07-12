namespace QlyGiaiBongDa.GUI
{
    partial class usrPlayerGoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrPlayerGoal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dgv_BXH_playergoal = new Guna.UI.WinForms.GunaDataGridView();
            this.TenCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_XuatBaocao = new Guna.UI.WinForms.GunaButton();
            this.btn_TimKiem = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.cb2 = new Guna.UI.WinForms.GunaComboBox();
            this.lb_Guide = new Guna.UI.WinForms.GunaLinkLabel();
            this.btn_TaiLai = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BXH_playergoal)).BeginInit();
            this.gb_HSDB.SuspendLayout();
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
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(936, 58);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Danh sách cầu thủ ghi bàn";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_BXH_playergoal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BXH_playergoal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BXH_playergoal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BXH_playergoal.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_BXH_playergoal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BXH_playergoal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BXH_playergoal.ColumnHeadersHeight = 35;
            this.dgv_BXH_playergoal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenCauThu,
            this.TenDoi,
            this.LoaiCauThu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BXH_playergoal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BXH_playergoal.EnableHeadersVisualStyles = false;
            this.dgv_BXH_playergoal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH_playergoal.Location = new System.Drawing.Point(0, 214);
            this.dgv_BXH_playergoal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_BXH_playergoal.Name = "dgv_BXH_playergoal";
            this.dgv_BXH_playergoal.RowHeadersVisible = false;
            this.dgv_BXH_playergoal.RowTemplate.Height = 24;
            this.dgv_BXH_playergoal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BXH_playergoal.Size = new System.Drawing.Size(938, 287);
            this.dgv_BXH_playergoal.TabIndex = 10;
            this.dgv_BXH_playergoal.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_BXH_playergoal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_BXH_playergoal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_BXH_playergoal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_BXH_playergoal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_BXH_playergoal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_BXH_playergoal.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_BXH_playergoal.ThemeStyle.ReadOnly = false;
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH_playergoal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenCauThu
            // 
            this.TenCauThu.DataPropertyName = "TenCauThu";
            this.TenCauThu.FillWeight = 40F;
            this.TenCauThu.HeaderText = "Tên Cầu Thủ";
            this.TenCauThu.Name = "TenCauThu";
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.FillWeight = 50F;
            this.TenDoi.HeaderText = "Tên Đội";
            this.TenDoi.Name = "TenDoi";
            // 
            // LoaiCauThu
            // 
            this.LoaiCauThu.DataPropertyName = "LoaiCauThu";
            this.LoaiCauThu.FillWeight = 40F;
            this.LoaiCauThu.HeaderText = "Loại Cầu Thủ";
            this.LoaiCauThu.Name = "LoaiCauThu";
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
            this.btn_XuatBaocao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_XuatBaocao.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_XuatBaocao.Location = new System.Drawing.Point(772, 515);
            this.btn_XuatBaocao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XuatBaocao.Name = "btn_XuatBaocao";
            this.btn_XuatBaocao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_XuatBaocao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_XuatBaocao.OnHoverImage = null;
            this.btn_XuatBaocao.OnPressedColor = System.Drawing.Color.Black;
            this.btn_XuatBaocao.Size = new System.Drawing.Size(156, 34);
            this.btn_XuatBaocao.TabIndex = 22;
            this.btn_XuatBaocao.Text = "Chi tiết ";
            this.btn_XuatBaocao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_XuatBaocao.Click += new System.EventHandler(this.btn_XuatBaocao_Click);
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
            this.btn_TimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TimKiem.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_TimKiem.Location = new System.Drawing.Point(430, 515);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.OnHoverImage = null;
            this.btn_TimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Size = new System.Drawing.Size(134, 34);
            this.btn_TimKiem.TabIndex = 10;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(278, 52);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 41);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Vòng Đấu:";
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.cb2);
            this.gb_HSDB.Controls.Add(this.lb_Guide);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(2, 84);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(936, 124);
            this.gb_HSDB.TabIndex = 4;
            this.gb_HSDB.Text = "Danh sách cầu thủ ghi bàn";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cb2
            // 
            this.cb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb2.BackColor = System.Drawing.Color.Black;
            this.cb2.BaseColor = System.Drawing.Color.White;
            this.cb2.BorderColor = System.Drawing.Color.Silver;
            this.cb2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FocusedColor = System.Drawing.Color.Empty;
            this.cb2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.ForeColor = System.Drawing.Color.Black;
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(402, 59);
            this.cb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb2.Name = "cb2";
            this.cb2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb2.Size = new System.Drawing.Size(161, 28);
            this.cb2.TabIndex = 25;
            // 
            // lb_Guide
            // 
            this.lb_Guide.AutoSize = true;
            this.lb_Guide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Guide.Location = new System.Drawing.Point(848, 32);
            this.lb_Guide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Guide.Name = "lb_Guide";
            this.lb_Guide.Size = new System.Drawing.Size(87, 20);
            this.lb_Guide.TabIndex = 23;
            this.lb_Guide.TabStop = true;
            this.lb_Guide.Text = "Hướng dẫn";
            this.lb_Guide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Guide_LinkClicked);
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.AnimationHoverSpeed = 0.07F;
            this.btn_TaiLai.AnimationSpeed = 0.03F;
            this.btn_TaiLai.BaseColor = System.Drawing.Color.Teal;
            this.btn_TaiLai.BorderColor = System.Drawing.Color.Black;
            this.btn_TaiLai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TaiLai.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TaiLai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.ForeColor = System.Drawing.Color.Black;
            this.btn_TaiLai.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.Image")));
            this.btn_TaiLai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TaiLai.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_TaiLai.Location = new System.Drawing.Point(604, 515);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TaiLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TaiLai.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TaiLai.OnHoverImage = null;
            this.btn_TaiLai.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TaiLai.Size = new System.Drawing.Size(127, 34);
            this.btn_TaiLai.TabIndex = 23;
            this.btn_TaiLai.Text = "Tải Lại";
            this.btn_TaiLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // usrPlayerGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_XuatBaocao);
            this.Controls.Add(this.dgv_BXH_playergoal);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "usrPlayerGoal";
            this.Size = new System.Drawing.Size(944, 566);
            this.Load += new System.EventHandler(this.usrPlayerGoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BXH_playergoal)).EndInit();
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btn_XuatBaocao;
        private Guna.UI.WinForms.GunaButton btn_TimKiem;
        public Guna.UI.WinForms.GunaDataGridView dgv_BXH_playergoal;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaLinkLabel lb_Guide;
        public Guna.UI.WinForms.GunaComboBox cb2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCauThu;
        public Guna.UI.WinForms.GunaButton btn_TaiLai;
    }
}
