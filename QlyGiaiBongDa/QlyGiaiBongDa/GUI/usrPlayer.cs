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
using QlyGiaiBongDa.GUI;
using System.Data.SqlClient;

namespace QlyGiaiBongDa.GUI
{
    public partial class usrPlayer : UserControl
    {

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
            cbb_team_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_team_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_team_name.DisplayMember = "TenDoi";
            cbb_team_name.ValueMember = "TenDoi";
            cbb_team_name.DataSource = ObjPlayerBLL.Instance.GetNameTeam_usrPlayer();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            //   dgv_TCCT.DataSource = ObjPlayerBLL.Instance.GetListFindPlayer();
            dgv_TCCT.DataSource = ObjPlayerBLL.Instance.LoadListPlayer();
        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn tìm kiếm để biết thêm thông tin cầu thủ");
        }
    }
}

