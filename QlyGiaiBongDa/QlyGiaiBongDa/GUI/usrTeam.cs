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
            if (string.IsNullOrEmpty(tb_SCT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SCT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_SanNha.Text))
            {
                MessageBox.Show("Bạn chưa nhập sân nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SanNha.Focus();
                return false;
            }

            return true;
        }

        // su kien chon nut them - Duy Bao Change
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ObjTeamBLL.Instance.Add();
                ObjTeamBLL.Instance.GetListTeam();
            }
        }

        private void btt_Team_View_Click(object sender, EventArgs e)
        {
            dgv_HSDB.Controls.Clear();
          
            dgv_HSDB.DataSource = ObjTeamBLL.Instance.PlayerView();
        }

        // ham click du lieu tren database
        private void dgv_HSDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_HSDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_HSDB.Rows[index].Cells["MaCauThu"].Value.ToString();
                tb_TenDoi.Text = dgv_HSDB.Rows[index].Cells["TenCauThu"].Value.ToString();
                tb_SCT.Text = dgv_HSDB.Rows[index].Cells["NgaySinh"].Value.ToString();
                tb_SanNha.Text = dgv_HSDB.Rows[index].Cells["TenLoaiCauThu"].Value.ToString();
            }
        }

        // su kien xoa
        private void Btn_xoa_Click_1(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.Delete();
            if (tb_MaDoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đội", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
