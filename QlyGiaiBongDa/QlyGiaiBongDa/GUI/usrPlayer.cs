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
        public void ShowCombobox()
        {
            cb_DoiBong.DataSource= ObjTeamBLL.Instance.GetListTeam();
            cb_DoiBong.DisplayMember = "TenDoi";
            cb_DoiBong.ValueMember = "MaDoi";
        }
        private void usrPlayer_Load(object sender, EventArgs e)
        {

        }

        private void cb_DoiBong_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}

