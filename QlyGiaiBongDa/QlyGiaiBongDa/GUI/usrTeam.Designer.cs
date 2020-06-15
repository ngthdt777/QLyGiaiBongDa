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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrTeam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_hsdb = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.tb_SanNha = new Guna.UI.WinForms.GunaTextBox();
            this.tb_TenDoi = new Guna.UI.WinForms.GunaTextBox();
            this.tb_SCT = new Guna.UI.WinForms.GunaTextBox();
            this.tb_MaDoi = new Guna.UI.WinForms.GunaTextBox();
            this.lb_team_slg = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_san = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_name = new Guna.UI.WinForms.GunaLabel();
            this.lb_team_id = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.gunaImageReplaceColor2 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.dgv_HSDB = new Guna.UI.WinForms.GunaDataGridView();
            this.Btn_xoa = new Guna.UI.WinForms.GunaButton();
            this.btn_Them = new Guna.UI.WinForms.GunaButton();
            this.Btn_sua = new Guna.UI.WinForms.GunaButton();
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
            this.lb_hsdb.Size = new System.Drawing.Size(1248, 144);
            this.lb_hsdb.TabIndex = 0;
            this.lb_hsdb.Text = "Hồ sơ đội bóng";
            this.lb_hsdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.tb_SanNha);
            this.gb_HSDB.Controls.Add(this.tb_TenDoi);
            this.gb_HSDB.Controls.Add(this.tb_SCT);
            this.gb_HSDB.Controls.Add(this.tb_MaDoi);
            this.gb_HSDB.Controls.Add(this.lb_team_slg);
            this.gb_HSDB.Controls.Add(this.lb_team_san);
            this.gb_HSDB.Controls.Add(this.lb_team_name);
            this.gb_HSDB.Controls.Add(this.lb_team_id);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(3, 140);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 181);
            this.gb_HSDB.TabIndex = 1;
            this.gb_HSDB.Text = "Thông tin đội bóng";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
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
            this.tb_SanNha.Location = new System.Drawing.Point(754, 103);
            this.tb_SanNha.Name = "tb_SanNha";
            this.tb_SanNha.PasswordChar = '\0';
            this.tb_SanNha.SelectedText = "";
            this.tb_SanNha.Size = new System.Drawing.Size(160, 32);
            this.tb_SanNha.TabIndex = 7;
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
            this.tb_TenDoi.Location = new System.Drawing.Point(754, 52);
            this.tb_TenDoi.Name = "tb_TenDoi";
            this.tb_TenDoi.PasswordChar = '\0';
            this.tb_TenDoi.SelectedText = "";
            this.tb_TenDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_TenDoi.TabIndex = 6;
            // 
            // tb_SCT
            // 
            this.tb_SCT.BaseColor = System.Drawing.Color.White;
            this.tb_SCT.BorderColor = System.Drawing.Color.Silver;
            this.tb_SCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SCT.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_SCT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_SCT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_SCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_SCT.Location = new System.Drawing.Point(327, 103);
            this.tb_SCT.Name = "tb_SCT";
            this.tb_SCT.PasswordChar = '\0';
            this.tb_SCT.SelectedText = "";
            this.tb_SCT.Size = new System.Drawing.Size(160, 32);
            this.tb_SCT.TabIndex = 5;
            // 
            // tb_MaDoi
            // 
            this.tb_MaDoi.BaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.BorderColor = System.Drawing.Color.Silver;
            this.tb_MaDoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaDoi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_MaDoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_MaDoi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_MaDoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_MaDoi.Location = new System.Drawing.Point(327, 52);
            this.tb_MaDoi.Name = "tb_MaDoi";
            this.tb_MaDoi.PasswordChar = '\0';
            this.tb_MaDoi.SelectedText = "";
            this.tb_MaDoi.Size = new System.Drawing.Size(160, 32);
            this.tb_MaDoi.TabIndex = 4;
            // 
            // lb_team_slg
            // 
            this.lb_team_slg.AutoSize = true;
            this.lb_team_slg.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_slg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_slg.ForeColor = System.Drawing.Color.Black;
            this.lb_team_slg.Location = new System.Drawing.Point(177, 103);
            this.lb_team_slg.Name = "lb_team_slg";
            this.lb_team_slg.Size = new System.Drawing.Size(134, 32);
            this.lb_team_slg.TabIndex = 3;
            this.lb_team_slg.Text = "Số cầu thủ:";
            // 
            // lb_team_san
            // 
            this.lb_team_san.AutoSize = true;
            this.lb_team_san.BackColor = System.Drawing.Color.Transparent;
            this.lb_team_san.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team_san.ForeColor = System.Drawing.Color.Black;
            this.lb_team_san.Location = new System.Drawing.Point(619, 103);
            this.lb_team_san.Name = "lb_team_san";
            this.lb_team_san.Size = new System.Drawing.Size(106, 32);
            this.lb_team_san.TabIndex = 2;
            this.lb_team_san.Text = "Sân nhà:";
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
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // gunaImageReplaceColor2
            // 
            this.gunaImageReplaceColor2.Image = null;
            this.gunaImageReplaceColor2.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor2.OldColor = System.Drawing.Color.White;
            // 
            // dgv_HSDB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HSDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HSDB.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_HSDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HSDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HSDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HSDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HSDB.ColumnHeadersHeight = 4;
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
            this.dgv_HSDB.Location = new System.Drawing.Point(0, 327);
            this.dgv_HSDB.Name = "dgv_HSDB";
            this.dgv_HSDB.RowHeadersVisible = false;
            this.dgv_HSDB.RowTemplate.Height = 24;
            this.dgv_HSDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HSDB.Size = new System.Drawing.Size(1251, 280);
            this.dgv_HSDB.TabIndex = 3;
            this.dgv_HSDB.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_HSDB.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgv_HSDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HSDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_HSDB.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_HSDB.ThemeStyle.ReadOnly = false;
            this.dgv_HSDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HSDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HSDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HSDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_HSDB.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_HSDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HSDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Btn_xoa
            // 
            this.Btn_xoa.AnimationHoverSpeed = 0.07F;
            this.Btn_xoa.AnimationSpeed = 0.03F;
            this.Btn_xoa.BaseColor = System.Drawing.Color.Teal;
            this.Btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.Btn_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_xoa.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.Btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("Btn_xoa.Image")));
            this.Btn_xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_xoa.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_xoa.Location = new System.Drawing.Point(866, 613);
            this.Btn_xoa.Name = "Btn_xoa";
            this.Btn_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_xoa.OnHoverImage = null;
            this.Btn_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_xoa.Size = new System.Drawing.Size(169, 52);
            this.Btn_xoa.TabIndex = 4;
            this.Btn_xoa.Text = "Xoá";
            this.Btn_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Them
            // 
            this.btn_Them.AnimationHoverSpeed = 0.07F;
            this.btn_Them.AnimationSpeed = 0.03F;
            this.btn_Them.BaseColor = System.Drawing.Color.Teal;
            this.btn_Them.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Them.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Them.Location = new System.Drawing.Point(661, 613);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them.OnHoverImage = null;
            this.btn_Them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them.Size = new System.Drawing.Size(169, 52);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_sua
            // 
            this.Btn_sua.AnimationHoverSpeed = 0.07F;
            this.Btn_sua.AnimationSpeed = 0.03F;
            this.Btn_sua.BaseColor = System.Drawing.Color.Teal;
            this.Btn_sua.BorderColor = System.Drawing.Color.Black;
            this.Btn_sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_sua.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sua.ForeColor = System.Drawing.Color.Black;
            this.Btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sua.Image")));
            this.Btn_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_sua.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_sua.Location = new System.Drawing.Point(1067, 613);
            this.Btn_sua.Name = "Btn_sua";
            this.Btn_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_sua.OnHoverImage = null;
            this.Btn_sua.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_sua.Size = new System.Drawing.Size(169, 52);
            this.Btn_sua.TabIndex = 6;
            this.Btn_sua.Text = "Sửa";
            this.Btn_sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.Btn_xoa);
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
        private Guna.UI.WinForms.GunaLabel lb_team_slg;
        private Guna.UI.WinForms.GunaLabel lb_team_san;
        private Guna.UI.WinForms.GunaLabel lb_team_name;
        private Guna.UI.WinForms.GunaLabel lb_team_id;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor2;
        private Guna.UI.WinForms.GunaButton Btn_xoa;
        private Guna.UI.WinForms.GunaButton btn_Them;
        private Guna.UI.WinForms.GunaButton Btn_sua;
        public Guna.UI.WinForms.GunaTextBox tb_SanNha;
        public Guna.UI.WinForms.GunaTextBox tb_TenDoi;
        public Guna.UI.WinForms.GunaTextBox tb_SCT;
        public Guna.UI.WinForms.GunaTextBox tb_MaDoi;
        public Guna.UI.WinForms.GunaDataGridView dgv_HSDB;
    }
}
