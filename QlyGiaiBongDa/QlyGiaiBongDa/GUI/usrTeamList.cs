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
using System.Data.SqlClient;
using QlyGiaiBongDa.GUI;



namespace QlyGiaiBongDa.GUI
{
    public partial class usrTeamList : UserControl
    {
        public ObjTeamBLL ObjTeamBLL;
        private static usrTeamList _instance;
        public static usrTeamList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrTeamList();
                return _instance;
            }
        }
        public usrTeamList()
        {
            InitializeComponent();
            
        }

       private void usrTeam_Load(object sender, EventArgs e)
        {
            // dgv_HSDB.DataSource = ObjTeamBLL.Instance.GetListTeam();
            cbb_team_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_team_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_team_name.DisplayMember = "TenDoi";
            cbb_team_name.ValueMember = "TenDoi";
            cbb_team_name.DataSource = ObjTeamBLL.Instance.GetNameTeam();

            cb_hsdb_loaict.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_hsdb_loaict.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hsdb_loaict.DisplayMember = "LoaiCauThu";
            cb_hsdb_loaict.ValueMember = "LoaiCauThu";
            cb_hsdb_loaict.DataSource = ObjTeamBLL.Instance.GetPlayerType();


        }


        // ham Data Check - Duy Bao Change
        public bool CheckData()
        {
            System.Windows.Forms.UserControl usr = new usrRulesChange();
            int yearofbirth = dtp_cauthu_ngsinh.Value.Year;
            int year = DateTime.Now.Year;
            int tuoi = year - yearofbirth;
            if (string.IsNullOrEmpty(tb_MaDoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaDoi.Focus();
                return false;
            }
            if((ObjRulesChangeBLL.Instance.CheckTuoiMax() == false ) && (ObjRulesChangeBLL.Instance.CheckTuoiMin() == false))
            {
                dtp_cauthu_ngsinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_mact.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_mact.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_tenct.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_tenct.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cb_hsdb_loaict.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_hsdb_loaict.Focus();
                return false;
            }
            if (ObjRulesChangeBLL.Instance.CheckForMax() == false)
            {
                cb_hsdb_loaict.Focus();

                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_tgiantd.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời gian thi đấu của cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_tgiantd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_thetrang.Text))
            {
                MessageBox.Show("Bạn chưa nhập thể trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_thetrang.Focus();
                return false;
            }

            return true;
        }






        // su kien chon nut them - Duy Bao Change
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ObjTeamBLL.Instance.AddPlayer();

            }
        }




        private void btt_Team_View_Click(object sender, EventArgs e)
        {
            CountForeign();
            dgv_HSDB.Visible = true;
            lb_hsdb_soctngoaiquoc.Visible = lb_hsdb_sctnq.Visible = true;
            lb_team_id.Visible= lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = lb_hsdb_thetrang.Visible = true;
            tb_MaDoi.Visible= tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = cb_hsdb_loaict.Visible = dtp_cauthu_ngsinh.Visible = tb_hsdb_thetrang.Visible =  true;
            lb_team_name.Visible = cbb_team_name.Visible= false;
            lb_hsdb_tgiantd.Visible = tb_hsdb_tgiantd.Visible = true;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = btt_back.Visible= true;
            btt_Team_View.Text = "Tải lại";
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.GetListPlayer();
        }







        // ham click du lieu tren database
        private void dgv_HSDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaDoi"].Value.ToString();
                tb_hsdb_mact.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaCauThu"].Value.ToString();            
                dtp_cauthu_ngsinh.Text = dgv_HSDB.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                cb_hsdb_loaict.Text = dgv_HSDB.Rows[e.RowIndex].Cells["LoaiCauThu"].Value.ToString();
                tb_hsdb_tenct.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TenCauThu"].Value.ToString();
                tb_hsdb_tgiantd.Text = dgv_HSDB.Rows[e.RowIndex].Cells["ThoiGianThiDau"].Value.ToString();
                tb_hsdb_thetrang.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            }
        }





        public void dgv_HSDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaDoi"].Value.ToString();
                tb_hsdb_mact.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaCauThu"].Value.ToString();
                cb_hsdb_loaict.Text = dgv_HSDB.Rows[e.RowIndex].Cells["LoaiCauThu"].Value.ToString();
                dtp_cauthu_ngsinh.Text = dgv_HSDB.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                tb_hsdb_tenct.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TenCauThu"].Value.ToString();
                tb_hsdb_tgiantd.Text = dgv_HSDB.Rows[e.RowIndex].Cells["ThoiGianThiDau"].Value.ToString();
                tb_hsdb_thetrang.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
            }
        }

        // su kien xoa
        private void Btn_xoa_Click_1(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.DeleteTeam();
            if (tb_MaDoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đội", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ObjTeamBLL.Instance.Bindings();
        }








        private void btt_hsdb_capnhat_Click(object sender, EventArgs e)
        {
            lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = true;
            tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = cb_hsdb_loaict.Visible = dtp_cauthu_ngsinh.Visible = true;
            lb_team_name.Visible = cbb_team_name.Visible = false;
            lb_hsdb_tgiantd.Visible = tb_hsdb_tgiantd.Visible = true;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = true;
            lb_hsdb_soctngoaiquoc.Visible = lb_hsdb_sctnq.Visible = true;
            ObjTeamBLL.Instance.GetListPlayer();

        }







        private void Btt_xoa_Click(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.DeletePlayer();
        }

        private void Btt_sua_Click(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.UpdatePlayer();
        }

        private void btt_back_Click(object sender, EventArgs e)
        {
            btt_back.Visible = false;
            dgv_HSDB.Visible = false;
            lb_team_id.Visible = lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = lb_hsdb_thetrang.Visible= false;
            tb_MaDoi.Visible = tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = cb_hsdb_loaict.Visible = dtp_cauthu_ngsinh.Visible = tb_hsdb_thetrang.Visible = false;
            lb_team_name.Visible = cbb_team_name.Visible = true;
            lb_hsdb_tgiantd.Visible = tb_hsdb_tgiantd.Visible = false;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = false;
            btt_Team_View.Text = "Hiển thị";
            lb_hsdb_soctngoaiquoc.Visible = lb_hsdb_sctnq.Visible = false;
        }
       public string connectionSTR = DataProvider.Instance.connectionSTR;

        private void CountForeign()
        {

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                string tendoi = usrTeamList.Instance.cbb_team_name.Text;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select Count(LoaiCauThu) AS SoCauThuNgoaiQuoc from CAUTHU, DOIBONG"+
"               where CAUTHU.MaDoi = DOIBONG.MaDoi AND LoaiCauThu = 'Ngoai Nuoc' AND DOIBONG.TenDoi = '"+tendoi+ "'",connection);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    usrTeamList.Instance.lb_hsdb_sctnq.Text = da.GetValue(0).ToString();
                }
            }
        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn hiển thị để xem thông tin cầu thủ");
        }
    }
}
