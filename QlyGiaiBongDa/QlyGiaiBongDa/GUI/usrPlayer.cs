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
      

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_TCCT.DataSource = ObjPlayerBLL.Instance.GetListFindPlayer();         
            Bindings();
        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn tìm kiếm để biết thêm thông tin cầu thủ");
        }
      
        private void tb_tuoimin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            
        }

        private void tb_tuoimax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void usrPlayer_Load_1(object sender, EventArgs e)
        {
            cbb_team_name.Text = null;
            
            cb_LoaiCT.Text = null;

        }

        private void cb_LoaiCT_DropDown(object sender, EventArgs e)
        {
           
            cb_LoaiCT.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_LoaiCT.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_LoaiCT.DisplayMember = "LoaiCauThu";
            cb_LoaiCT.ValueMember = "LoaiCauThu";
            cb_LoaiCT.DataSource = ObjPlayerBLL.Instance.GetPlayerType();
        }

        private void cbb_team_name_DropDown(object sender, EventArgs e)
        {
            cbb_team_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_team_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_team_name.DisplayMember = "TenDoi";
            cbb_team_name.ValueMember = "TenDoi";
            cbb_team_name.DataSource = ObjPlayerBLL.Instance.GetNameTeam();
        }


        private void  Bindings()
        {
            tb_HoTen.Clear();
            tb_MaCT.Clear();
            tb_tgian.Clear();
            tb_tuoimax.Clear();
            tb_tuoimin.Clear();
            cbb_team_name.DataSource = null; 
            cb_LoaiCT.DataSource = null;
            //cb_LoaiSoSanh.Text = "";
        }
    }
}

