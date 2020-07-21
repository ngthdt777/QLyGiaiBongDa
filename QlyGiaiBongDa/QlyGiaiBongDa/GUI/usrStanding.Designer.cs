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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.btt_Standing_back = new Guna.UI.WinForms.GunaButton();
            this.cbb_team_name = new Guna.UI.WinForms.GunaComboBox();
            this.btt_stading_find = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dgv_BXH = new Guna.UI.WinForms.GunaDataGridView();
            this.MaDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanThua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.gb_HSDB.Controls.Add(this.btt_Standing_back);
            this.gb_HSDB.Controls.Add(this.cbb_team_name);
            this.gb_HSDB.Controls.Add(this.btt_stading_find);
            this.gb_HSDB.Controls.Add(this.gunaLabel2);
            this.gb_HSDB.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.ForeColor = System.Drawing.Color.Black;
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 76);
            this.gb_HSDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 172);
            this.gb_HSDB.TabIndex = 3;
            this.gb_HSDB.Text = "Thông tin bản xếp hạng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btt_Standing_back
            // 
            this.btt_Standing_back.AnimationHoverSpeed = 0.07F;
            this.btt_Standing_back.AnimationSpeed = 0.03F;
            this.btt_Standing_back.BaseColor = System.Drawing.Color.White;
            this.btt_Standing_back.BorderColor = System.Drawing.Color.Black;
            this.btt_Standing_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Standing_back.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Standing_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Standing_back.ForeColor = System.Drawing.Color.White;
            this.btt_Standing_back.Image = ((System.Drawing.Image)(resources.GetObject("btt_Standing_back.Image")));
            this.btt_Standing_back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_Standing_back.ImageSize = new System.Drawing.Size(20, 20);
            this.btt_Standing_back.Location = new System.Drawing.Point(3, 40);
            this.btt_Standing_back.Name = "btt_Standing_back";
            this.btt_Standing_back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_Standing_back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_Standing_back.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_Standing_back.OnHoverImage = null;
            this.btt_Standing_back.OnPressedColor = System.Drawing.Color.Black;
            this.btt_Standing_back.Size = new System.Drawing.Size(54, 35);
            this.btt_Standing_back.TabIndex = 20;
            this.btt_Standing_back.Click += new System.EventHandler(this.btt_Standing_back_Click);
            // 
            // cbb_team_name
            // 
            this.cbb_team_name.BackColor = System.Drawing.Color.Transparent;
            this.cbb_team_name.BaseColor = System.Drawing.Color.White;
            this.cbb_team_name.BorderColor = System.Drawing.Color.Silver;
            this.cbb_team_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_team_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_team_name.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_team_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_team_name.ForeColor = System.Drawing.Color.Black;
            this.cbb_team_name.FormattingEnabled = true;
            this.cbb_team_name.Location = new System.Drawing.Point(568, 60);
            this.cbb_team_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_team_name.Name = "cbb_team_name";
            this.cbb_team_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbb_team_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbb_team_name.Size = new System.Drawing.Size(223, 33);
            this.cbb_team_name.TabIndex = 19;
            // 
            // btt_stading_find
            // 
            this.btt_stading_find.AnimationHoverSpeed = 0.07F;
            this.btt_stading_find.AnimationSpeed = 0.03F;
            this.btt_stading_find.BaseColor = System.Drawing.Color.White;
            this.btt_stading_find.BorderColor = System.Drawing.Color.Black;
            this.btt_stading_find.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_stading_find.FocusedColor = System.Drawing.Color.Empty;
            this.btt_stading_find.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_stading_find.ForeColor = System.Drawing.Color.Black;
            this.btt_stading_find.Image = ((System.Drawing.Image)(resources.GetObject("btt_stading_find.Image")));
            this.btt_stading_find.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btt_stading_find.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_stading_find.Location = new System.Drawing.Point(797, 53);
            this.btt_stading_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_stading_find.Name = "btt_stading_find";
            this.btt_stading_find.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btt_stading_find.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btt_stading_find.OnHoverForeColor = System.Drawing.Color.White;
            this.btt_stading_find.OnHoverImage = null;
            this.btt_stading_find.OnPressedColor = System.Drawing.Color.Black;
            this.btt_stading_find.Size = new System.Drawing.Size(60, 42);
            this.btt_stading_find.TabIndex = 11;
            this.btt_stading_find.Click += new System.EventHandler(this.btt_stading_find_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(354, 53);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(208, 42);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Thông tin đội";
            // 
            // dgv_BXH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_BXH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BXH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BXH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BXH.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_BXH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BXH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BXH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BXH.ColumnHeadersHeight = 30;
            this.dgv_BXH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoi,
            this.TenDoi,
            this.BanThang,
            this.BanThua,
            this.DiemSo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BXH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BXH.EnableHeadersVisualStyles = false;
            this.dgv_BXH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH.Location = new System.Drawing.Point(3, 252);
            this.dgv_BXH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_BXH.Name = "dgv_BXH";
            this.dgv_BXH.RowHeadersVisible = false;
            this.dgv_BXH.RowTemplate.Height = 24;
            this.dgv_BXH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BXH.Size = new System.Drawing.Size(1251, 359);
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
            this.dgv_BXH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgv_BXH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_BXH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_BXH.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_BXH.ThemeStyle.ReadOnly = false;
            this.dgv_BXH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_BXH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_BXH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_BXH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_BXH.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_BXH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_BXH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.HeaderText = "Tên Đội";
            this.TenDoi.Name = "TenDoi";
            // 
            // BanThang
            // 
            this.BanThang.DataPropertyName = "BanThang";
            this.BanThang.HeaderText = "Bàn thắng ghi được";
            this.BanThang.Name = "BanThang";
            // 
            // BanThua
            // 
            this.BanThua.DataPropertyName = "BanThua";
            this.BanThua.HeaderText = "Bàn thua nhận";
            this.BanThua.Name = "BanThua";
            // 
            // DiemSo
            // 
            this.DiemSo.DataPropertyName = "DiemSo";
            this.DiemSo.HeaderText = "Điểm Số";
            this.DiemSo.Name = "DiemSo";
            // 
            // usrStanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_BXH);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usrStanding";
            this.Size = new System.Drawing.Size(1253, 697);
            this.Load += new System.EventHandler(this.usrStanding_Load);
            this.gb_HSDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BXH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaDataGridView dgv_BXH;
        private Guna.UI.WinForms.GunaButton btt_stading_find;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaComboBox cbb_team_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanThua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemSo;
        private Guna.UI.WinForms.GunaButton btt_Standing_back;
    }
}
