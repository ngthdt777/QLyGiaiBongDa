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
            // dgv_HSDB.DataSource = ObjTeamBLL.Instance.GetListTeam();
            cbb_team_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_team_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_team_name.DisplayMember = "TenDoi";
            cbb_team_name.ValueMember = "TenDoi";
            cbb_team_name.DataSource = ObjTeamBLL.Instance.GetNameTeam();
        }

        // ham Data Check - Duy Bao Change
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(tb_MaDoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaDoi.Focus();
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
            if (string.IsNullOrEmpty(tb_hsdb_ngsinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_ngsinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_loaict.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_loaict.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_hsdb_ghichu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú của cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_hsdb_ghichu.Focus();
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
               // ObjTeamBLL.Instance.GetListPlayer();
            }
        }








        private void btt_Team_View_Click(object sender, EventArgs e)
        {
            dgv_HSDB.Visible = true;
            lb_team_id.Visible= lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = true;
            tb_MaDoi.Visible= tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = tb_hsdb_loaict.Visible = tb_hsdb_ngsinh.Visible = true;
            lb_team_name.Visible = cbb_team_name.Visible = false;
            lb_hsdb_ghichu.Visible = tb_hsdb_ghichu.Visible = true;
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
                tb_hsdb_loaict.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaLoaiCauThu"].Value.ToString();
                tb_hsdb_ngsinh.Text = dgv_HSDB.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                tb_hsdb_tenct.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TenCauThu"].Value.ToString();
                tb_hsdb_ghichu.Text = dgv_HSDB.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            }
        }





        public void dgv_HSDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaDoi"].Value.ToString();
                tb_hsdb_mact.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaCauThu"].Value.ToString();
                tb_hsdb_loaict.Text = dgv_HSDB.Rows[e.RowIndex].Cells["MaLoaiCauThu"].Value.ToString();
                tb_hsdb_ngsinh.Text = dgv_HSDB.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                tb_hsdb_tenct.Text = dgv_HSDB.Rows[e.RowIndex].Cells["TenCauThu"].Value.ToString();
                tb_hsdb_ghichu.Text = dgv_HSDB.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
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
            tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = tb_hsdb_loaict.Visible = tb_hsdb_ngsinh.Visible = true;
            lb_team_name.Visible = cbb_team_name.Visible = false;
            lb_hsdb_ghichu.Visible = tb_hsdb_ghichu.Visible = true;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = true;

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

        private void cbb_team_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btt_back_Click(object sender, EventArgs e)
        {
            btt_back.Visible = false;
            dgv_HSDB.Visible = false;
            lb_team_id.Visible = lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = false;
            tb_MaDoi.Visible = tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = tb_hsdb_loaict.Visible = tb_hsdb_ngsinh.Visible = false;
            lb_team_name.Visible = cbb_team_name.Visible = true;
            lb_hsdb_ghichu.Visible = tb_hsdb_ghichu.Visible = false;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = false;
            btt_Team_View.Text = "Hiển thị";
        }
    }
}
