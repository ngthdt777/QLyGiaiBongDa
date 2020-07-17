using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace QlyGiaiBongDa.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Lb_Dangnhap_Click(object sender, EventArgs e)
        {
            if (LoginCheck())
            {
                frmQLGBD f = new frmQLGBD();
                this.Hide();
                f.Show();
            }
        }
        bool LoginCheck()
        {
            return QlyGiaiBongDa.DAL.DataProvider.Instance.LoginCheck();
        }

        private void btt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (LoginCheck())
                {
                    frmQLGBD f = new frmQLGBD();
                    this.Hide();
                    f.Show();
                }
            }
        }

        private void txb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (LoginCheck())
                {
                    frmQLGBD f = new frmQLGBD();
                    this.Hide();
                    f.Show();
                }
            }
        }

    }
}
