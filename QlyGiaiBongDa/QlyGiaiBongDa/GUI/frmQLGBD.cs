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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btt_doibong_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrTeamList.Instance))
            {
                pnlMain.Controls.Add(usrTeamList.Instance);
                usrTeamList.Instance.Dock = DockStyle.Fill;
                usrTeamList.Instance.BringToFront();
            }
            else
                usrTeamList.Instance.BringToFront();
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

        private void btt_dieule_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrRulesChange.Instance))
            {
                pnlMain.Controls.Add(usrRulesChange.Instance);
                usrRulesChange.Instance.Dock = DockStyle.Fill;
                usrRulesChange.Instance.BringToFront();
            }
            else
                usrRulesChange.Instance.BringToFront();
        }

        private void btt_kqvd_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrStanding.Instance))
            {
                pnlMain.Controls.Add(usrStanding.Instance);
                usrStanding.Instance.Dock = DockStyle.Fill;
                usrStanding.Instance.BringToFront();
            }
            else
                usrStanding.Instance.BringToFront();
        }

        private void btt_lichtd_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrCreateMatch.Instance))
            {
                pnlMain.Controls.Add(usrCreateMatch.Instance);
                usrCreateMatch.Instance.Dock = DockStyle.Fill;
                usrCreateMatch.Instance.BringToFront();
            }
            else
                usrCreateMatch.Instance.BringToFront();
        }


        private void btt_baocao_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(usrPlayerGoal.Instance))
            {
                pnlMain.Controls.Add(usrPlayerGoal.Instance);
                usrPlayerGoal.Instance.Dock = DockStyle.Fill;
                usrPlayerGoal.Instance.BringToFront();
            }
            else
                usrPlayerGoal.Instance.BringToFront();
        }
    }
}
