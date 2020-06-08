using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyGiaiBongDa.GUI
{
    public partial class frmQLGBD : Form
    {
        public frmQLGBD()
        {
            InitializeComponent();
        }

        private void frmQLGBD_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(usrHomepage.Instance);
            usrHomepage.Instance.Dock = DockStyle.Fill;
            usrHomepage.Instance.BringToFront();
        }



        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_gbd_Click(object sender, EventArgs e)
        {

        }

        private void btt_doibong_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrTeam.Instance))
            {
                pnlMain.Controls.Add(usrTeam.Instance);
                usrTeam.Instance.Dock = DockStyle.Fill;
                usrTeam.Instance.BringToFront();
            }
            else
                usrTeam.Instance.BringToFront();
        }

        private void btt_cauthu_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrPlayer.Instance))
            {
                pnlMain.Controls.Add(usrPlayer.Instance);
                usrPlayer.Instance.Dock = DockStyle.Fill;
                usrPlayer.Instance.BringToFront();
            }
            else
                usrPlayer.Instance.BringToFront();
        }

        private void btt_homepage_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrHomepage.Instance))
            {
                pnlMain.Controls.Add(usrHomepage.Instance);
                usrHomepage.Instance.Dock = DockStyle.Fill;
                usrHomepage.Instance.BringToFront();
            }
            else
                usrHomepage.Instance.BringToFront();
        }
    }
}
