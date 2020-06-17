using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyGiaiBongDa.BLL;
using QlyGiaiBongDa.DAL;

namespace QlyGiaiBongDa.GUI
{
    public partial class usrHomepage : UserControl
    {
        private static usrHomepage _instance;
        public static usrHomepage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrHomepage();
                return _instance;
            }
        }
        public usrHomepage()
        {
            InitializeComponent();
        }

        private void usrHomepage_Load(object sender, EventArgs e)
        {

        }

        private void btt_team_view_Click(object sender, EventArgs e)
        {
            dgv_Home.Visible = btt_team_add.Visible = btt_team_era.Visible = btt_team_fix.Visible = true;
            lb_team_id.Visible = true; tb_MaDoi.Visible = true;
            lb_team_name.Visible = true; tb_TenDoi.Visible = true;
            lb_team_san.Visible = true; tb_SanNha.Visible = true;
            lb_team_slg.Visible = true; tb_SCT.Visible = true;
            dgv_Home.DataSource = ObjTeamBLL.Instance.GetListTeam();
        }

    }
}
