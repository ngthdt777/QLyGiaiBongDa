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
    public partial class usrTeam : UserControl
    {
        public ObjTeamBLL ObjTeamBLL;
        private static usrTeam _instance;
        public static usrTeam Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrTeam();
                return _instance;
            }
        }
        public usrTeam()
        {
            InitializeComponent();
        }

       private void usrTeam_Load(object sender, EventArgs e)
        {
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.GetListTeam();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.Add();
        }

        private void btt_Team_View_Click(object sender, EventArgs e)
        {
            dgv_HSDB.Controls.Clear();
            //System.Windows.Forms.UserControl u = new usrTeam();
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.PlayerView();
        }
    }
}
