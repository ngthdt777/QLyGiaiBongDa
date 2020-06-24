namespace QlyGiaiBongDa.GUI
{
    partial class usrNewTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrNewTour));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gb_HSDB = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_Done = new Guna.UI.WinForms.GunaButton();
            this.checkb_LTD = new Guna.UI.WinForms.GunaCheckBox();
            this.checkb_DSDB = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
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
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(3, 3);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(1248, 82);
            this.gunaButton1.TabIndex = 1;
            this.gunaButton1.Text = "Tạo giải đấu mới";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_HSDB
            // 
            this.gb_HSDB.BackColor = System.Drawing.Color.Transparent;
            this.gb_HSDB.BaseColor = System.Drawing.Color.White;
            this.gb_HSDB.BorderColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Controls.Add(this.btn_Done);
            this.gb_HSDB.Controls.Add(this.checkb_LTD);
            this.gb_HSDB.Controls.Add(this.checkb_DSDB);
            this.gb_HSDB.Controls.Add(this.gunaLabel4);
            this.gb_HSDB.Controls.Add(this.gunaLabel1);
            this.gb_HSDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_HSDB.LineColor = System.Drawing.Color.Gainsboro;
            this.gb_HSDB.Location = new System.Drawing.Point(6, 91);
            this.gb_HSDB.Name = "gb_HSDB";
            this.gb_HSDB.Size = new System.Drawing.Size(1248, 603);
            this.gb_HSDB.TabIndex = 2;
            this.gb_HSDB.Text = "Chọn loại thông tin khởi tạo lại";
            this.gb_HSDB.TextLocation = new System.Drawing.Point(10, 8);
            this.gb_HSDB.Click += new System.EventHandler(this.gb_HSDB_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.AnimationHoverSpeed = 0.07F;
            this.btn_Done.AnimationSpeed = 0.03F;
            this.btn_Done.BaseColor = System.Drawing.Color.Teal;
            this.btn_Done.BorderColor = System.Drawing.Color.Black;
            this.btn_Done.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Done.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Done.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.ForeColor = System.Drawing.Color.Black;
            this.btn_Done.Image = ((System.Drawing.Image)(resources.GetObject("btn_Done.Image")));
            this.btn_Done.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Done.Location = new System.Drawing.Point(604, 272);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Done.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Done.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Done.OnHoverImage = null;
            this.btn_Done.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Done.Size = new System.Drawing.Size(179, 42);
            this.btn_Done.TabIndex = 20;
            this.btn_Done.Text = "Hoàn tất";
            // 
            // checkb_LTD
            // 
            this.checkb_LTD.BaseColor = System.Drawing.Color.White;
            this.checkb_LTD.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkb_LTD.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkb_LTD.FillColor = System.Drawing.Color.White;
            this.checkb_LTD.Location = new System.Drawing.Point(708, 188);
            this.checkb_LTD.Name = "checkb_LTD";
            this.checkb_LTD.Size = new System.Drawing.Size(20, 20);
            this.checkb_LTD.TabIndex = 5;
            // 
            // checkb_DSDB
            // 
            this.checkb_DSDB.BaseColor = System.Drawing.Color.White;
            this.checkb_DSDB.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkb_DSDB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkb_DSDB.FillColor = System.Drawing.Color.White;
            this.checkb_DSDB.Location = new System.Drawing.Point(708, 132);
            this.checkb_DSDB.Name = "checkb_DSDB";
            this.checkb_DSDB.Size = new System.Drawing.Size(30, 20);
            this.checkb_DSDB.TabIndex = 4;
            this.checkb_DSDB.Text = " ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(366, 176);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(273, 32);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Lịch thi đấu-Bàn thắng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.MintCream;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(396, 120);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(243, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Danh sách đội bóng";
            // 
            // usrNewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_HSDB);
            this.Controls.Add(this.gunaButton1);
            this.Name = "usrNewTour";
            this.Size = new System.Drawing.Size(1254, 697);
            this.gb_HSDB.ResumeLayout(false);
            this.gb_HSDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGroupBox gb_HSDB;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCheckBox checkb_LTD;
        private Guna.UI.WinForms.GunaCheckBox checkb_DSDB;
        private Guna.UI.WinForms.GunaButton btn_Done;
    }
}
