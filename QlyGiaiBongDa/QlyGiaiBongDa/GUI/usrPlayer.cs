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

namespace QlyGiaiBongDa.GUI
{
    public partial class usrPlayer : UserControl
    {
        public ObjTeamBLL ObjTeamBLL;


        public ObjPlayerBLL ObjPlayerBLL;

        private static usrPlayer _instance;
        public static usrPlayer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrPlayer();
                return _instance;
            }
        }
        public usrPlayer()
        {
            InitializeComponent();
        }
        private void usrPlayer_Load(object sender, EventArgs e)
        {
            cb_DoiBong.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_DoiBong.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_DoiBong.DisplayMember = "TenDoi";
            cb_DoiBong.ValueMember = "TenDoi";
            cb_DoiBong.DataSource = ObjTeamBLL.Instance.GetNameTeam();
        }

        private void cb_DoiBong_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_TCCT.DataSource = ObjPlayerBLL.Instance.GetListFindPlayer();
        }
    }
}

