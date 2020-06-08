namespace QlyGiaiBongDa.GUI
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lb_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_tk = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.Lb_dangnhap = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btt_exit = new Guna.UI.WinForms.GunaControlBox();
            this.picbox_soccerball = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_soccerball)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.BackColor = System.Drawing.Color.Transparent;
            this.lb_Login.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.Color.Teal;
            this.lb_Login.Location = new System.Drawing.Point(145, 184);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(120, 45);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(90, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";
            // 
            // txb_tk
            // 
            this.txb_tk.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tk.Location = new System.Drawing.Point(95, 280);
            this.txb_tk.Name = "txb_tk";
            this.txb_tk.Size = new System.Drawing.Size(206, 25);
            this.txb_tk.TabIndex = 3;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.Teal;
            this.lb_pass.Location = new System.Drawing.Point(90, 319);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(92, 23);
            this.lb_pass.TabIndex = 4;
            this.lb_pass.Text = "Mật Khẩu:";
            // 
            // txb_pass
            // 
            this.txb_pass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pass.Location = new System.Drawing.Point(95, 345);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(206, 25);
            this.txb_pass.TabIndex = 5;
            this.txb_pass.UseSystemPasswordChar = true;
            this.txb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_pass_KeyPress);
            // 
            // Lb_dangnhap
            // 
            this.Lb_dangnhap.AutoSize = true;
            this.Lb_dangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_dangnhap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_dangnhap.ForeColor = System.Drawing.Color.Teal;
            this.Lb_dangnhap.Location = new System.Drawing.Point(123, 401);
            this.Lb_dangnhap.Name = "Lb_dangnhap";
            this.Lb_dangnhap.Size = new System.Drawing.Size(142, 34);
            this.Lb_dangnhap.TabIndex = 6;
            this.Lb_dangnhap.Text = "Đăng nhập";
            this.Lb_dangnhap.Click += new System.EventHandler(this.Lb_Dangnhap_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btt_exit
            // 
            this.btt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_exit.AnimationHoverSpeed = 0.07F;
            this.btt_exit.AnimationSpeed = 0.03F;
            this.btt_exit.BackColor = System.Drawing.Color.LightGray;
            this.btt_exit.IconColor = System.Drawing.Color.Crimson;
            this.btt_exit.IconSize = 25F;
            this.btt_exit.Location = new System.Drawing.Point(358, 2);
            this.btt_exit.Name = "btt_exit";
            this.btt_exit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btt_exit.OnHoverIconColor = System.Drawing.Color.White;
            this.btt_exit.OnPressedColor = System.Drawing.Color.Black;
            this.btt_exit.Size = new System.Drawing.Size(45, 29);
            this.btt_exit.TabIndex = 7;
            this.btt_exit.Click += new System.EventHandler(this.btt_exit_Click);
            // 
            // picbox_soccerball
            // 
            this.picbox_soccerball.BackColor = System.Drawing.Color.Transparent;
            this.picbox_soccerball.BaseColor = System.Drawing.Color.LightGray;
            this.picbox_soccerball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_soccerball.Image = ((System.Drawing.Image)(resources.GetObject("picbox_soccerball.Image")));
            this.picbox_soccerball.Location = new System.Drawing.Point(121, 26);
            this.picbox_soccerball.Name = "picbox_soccerball";
            this.picbox_soccerball.Size = new System.Drawing.Size(163, 155);
            this.picbox_soccerball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_soccerball.TabIndex = 8;
            this.picbox_soccerball.TabStop = false;
            this.picbox_soccerball.UseTransfarantBackground = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(404, 587);
            this.Controls.Add(this.picbox_soccerball);
            this.Controls.Add(this.btt_exit);
            this.Controls.Add(this.Lb_dangnhap);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.txb_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Login);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_soccerball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label Lb_dangnhap;
        public System.Windows.Forms.TextBox txb_tk;
        public System.Windows.Forms.TextBox txb_pass;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Guna.UI.WinForms.GunaControlBox btt_exit;
        private Guna.UI.WinForms.GunaCirclePictureBox picbox_soccerball;
    }
}