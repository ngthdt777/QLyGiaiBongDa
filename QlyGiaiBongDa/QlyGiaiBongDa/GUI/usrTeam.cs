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
            if (string.IsNullOrEmpty(tb_TenDoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_TenDoi.Focus();
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
                ObjTeamBLL.Instance.GetListTeam();
            }
        }

        private void btt_Team_View_Click(object sender, EventArgs e)
        {
            dgv_HSDB.Visible = true;
            btt_hsdb_capnhat.Visible = true;
         //   lb_hsdb_mact.Visible = lb_hsdb_Tenct.Visible = lb_hsdb_loaict.Visible = lb_hsdb_ngsinh.Visible = true;
          //  tb_hsdb_mact.Visible = tb_hsdb_tenct.Visible = tb_hsdb_loaict.Visible = tb_hsdb_ngsinh.Visible = true;
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.PlayerView();
        }

        // ham click du lieu tren database
        private void dgv_HSDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[index].Cells["MaCauThu"].Value.ToString();
                tb_TenDoi.Text = dgv_HSDB.Rows[index].Cells["TenCauThu"].Value.ToString();
            }
        }

        private void dgv_HSDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[index].Cells["MaCauThu"].Value.ToString();
                tb_TenDoi.Text = dgv_HSDB.Rows[index].Cells["TenCauThu"].Value.ToString();

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
            lb_team_name.Visible = tb_TenDoi.Visible = false;
            lb_hsdb_ghichu.Visible = tb_hsdb_ghichu.Visible = true;
            btt_Them.Visible = Btt_xoa.Visible = Btt_sua.Visible = true;
        }
    }
}
