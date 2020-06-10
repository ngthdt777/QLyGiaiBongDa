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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrCreateMatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_CapNhat = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cb_VongDau = new System.Windows.Forms.ComboBox();
            this.dgv_TLTD = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_PhatSinh = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TLTD)).BeginInit();
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
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(3, 3);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 144);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Tạo lịch thi đấu";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.cb_VongDau);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 144);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 123);
            this.gb_HSDB.TabIndex = 3;
            this.gb_HSDB.Text = "Chọn vòng thi đấu";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.AnimationHoverSpeed = 0.07F;
            this.btn_CapNhat.AnimationSpeed = 0.03F;
            this.btn_CapNhat.BaseColor = System.Drawing.Color.Teal;
            this.btn_CapNhat.BorderColor = System.Drawing.Color.Black;
            this.btn_CapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_CapNhat.Location = new System.Drawing.Point(1005, 634);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_CapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_CapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.OnHoverImage = null;
            this.btn_CapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btn_CapNhat.Size = new System.Drawing.Size(179, 42);
            this.btn_CapNhat.TabIndex = 20;
            this.btn_CapNhat.Text = "Cập nhật";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(388, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(161, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Vòng thi đấu";
            // 
            // cb_VongDau
            // 
            this.cb_VongDau.FormattingEnabled = true;
            this.cb_VongDau.Location = new System.Drawing.Point(642, 59);
            this.cb_VongDau.Name = "cb_VongDau";
            this.cb_VongDau.Size = new System.Drawing.Size(121, 30);
            this.cb_VongDau.TabIndex = 21;
            // 
            // dgv_TLTD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TLTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TLTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TLTD.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_TLTD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TLTD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TLTD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TLTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TLTD.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TLTD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TLTD.EnableHeadersVisualStyles = false;
            this.dgv_TLTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.Location = new System.Drawing.Point(3, 273);
            this.dgv_TLTD.Name = "dgv_TLTD";
            this.dgv_TLTD.RowHeadersVisible = false;
            this.dgv_TLTD.RowTemplate.Height = 24;
            this.dgv_TLTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TLTD.Size = new System.Drawing.Size(1248, 340);
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
            this.dgv_TLTD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TLTD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TLTD.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_TLTD.ThemeStyle.ReadOnly = false;
            this.dgv_TLTD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TLTD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TLTD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TLTD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TLTD.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_TLTD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TLTD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_PhatSinh.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_PhatSinh.Location = new System.Drawing.Point(719, 634);
            this.btn_PhatSinh.Name = "btn_PhatSinh";
            this.btn_PhatSinh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_PhatSinh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PhatSinh.OnHoverImage = null;
            this.btn_PhatSinh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PhatSinh.Size = new System.Drawing.Size(267, 42);
            this.btn_PhatSinh.TabIndex = 22;
            this.btn_PhatSinh.Text = "Phát sinh trận đấu";
            // 
            // usrCreateMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_PhatSinh);
            this.Controls.Add(this.dgv_TLTD);
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.gunaButton1);
            this.Name = "usrCreateMatch";
            this.Size = new System.Drawing.Size(1254, 697);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TLTD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaButton btn_CapNhat;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox cb_VongDau;
        private Guna.UI.WinForms.GunaDataGridView dgv_TLTD;
        private Guna.UI.WinForms.GunaButton btn_PhatSinh;
    }
}
