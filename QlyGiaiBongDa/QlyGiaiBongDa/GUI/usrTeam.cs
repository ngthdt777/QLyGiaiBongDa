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
            lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = true;
            tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = tb_hsdb_loaict.Visible = tb_hsdb_ngsinh.Visible = true;
            lb_team_name.Visible = tb_TenDoi.Visible = false;
            lb_hsdb_ghichu.Visible = tb_hsdb_ghichu.Visible = true;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = true;
            btt_Team_View.Text = "Tải lại";
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.GetListPlayer();
        }







        // ham click du lieu tren database
        private void dgv_HSDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[index].Cells["MaDoi"].Value.ToString();
                tb_hsdb_mact.Text = dgv_HSDB.Rows[index].Cells["MaCauThu"].Value.ToString();
                tb_hsdb_loaict.Text = dgv_HSDB.Rows[index].Cells["MaLoaiCauThu"].Value.ToString();
                tb_hsdb_ngsinh.Text = dgv_HSDB.Rows[index].Cells["NgaySinh"].Value.ToString();
                tb_hsdb_tenct.Text = dgv_HSDB.Rows[index].Cells["TenCauThu"].Value.ToString();
                tb_hsdb_ghichu.Text = dgv_HSDB.Rows[index].Cells["GhiChu"].Value.ToString();
            }
        }





     /*   private void dgv_HSDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[index].Cells["MaCauThu"].Value.ToString();
                tb_TenDoi.Text = dgv_HSDB.Rows[index].Cells["TenCauThu"].Value.ToString();

            }
        }*/

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
            lb_team_name.Visible = tb_TenDoi.Visible = false;
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
    }
}
