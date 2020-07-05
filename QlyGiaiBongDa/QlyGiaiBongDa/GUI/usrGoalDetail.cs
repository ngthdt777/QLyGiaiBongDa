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
    public partial class usrGoalDetail : UserControl
    {
        private static usrGoalDetail _instance;
        public static usrGoalDetail Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrGoalDetail();
                return _instance;
            }
        }
        public usrGoalDetail()
        {
            InitializeComponent();
        }
        public bool CheckData()
        {
            
            
            if (string.IsNullOrEmpty(tb_MaBanThang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bàn thắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaBanThang.Focus();
                return false;
            }
           
          
            if (string.IsNullOrEmpty(tb_MaCauThu.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaCauThu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_MaLoaiBanThang.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại bàn thắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaLoaiBanThang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_ThoiDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập thời điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_ThoiDiem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_MaTranDau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã trận đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaTranDau.Focus();
                return false;
            }
           
            return true;
        }

   

        private void usrGoalDetail_Load_1(object sender, EventArgs e)
        {
           cb1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.DisplayMember = "TenLoaiBanThang";
            cb1.ValueMember = "TenLoaiBanThang";
            cb1.DataSource = ObjGoalDetailBLL.Instance.GetGoalType(); 
            dgv_CTBT.DataSource = ObjGoalDetailBLL.Instance.GetListGoal();
        }



        private void btt_Them_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ObjGoalDetailBLL.Instance.AddGoal();
            }

        }

        private void dgv_CTBT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {  
                tb_MaBanThang.Text = dgv_CTBT.Rows[e.RowIndex].Cells["MaBanThang"].Value.ToString();
                tb_MaCauThu.Text = dgv_CTBT.Rows[e.RowIndex].Cells["MaCauThu"].Value.ToString();
                tb_MaLoaiBanThang.Text = dgv_CTBT.Rows[e.RowIndex].Cells["MaLoaiBanThang"].Value.ToString();
                tb_ThoiDiem.Text = dgv_CTBT.Rows[e.RowIndex].Cells["ThoiDiem"].Value.ToString();
                tb_MaTranDau.Text = dgv_CTBT.Rows[e.RowIndex].Cells["MaTranDau"].Value.ToString();

            }
            }

        private void Btt_xoa_Click(object sender, EventArgs e)
        {
            ObjGoalDetailBLL.Instance.DeleteGoal();
        }

        private void Btt_sua_Click(object sender, EventArgs e)
        {
            ObjGoalDetailBLL.Instance.DeleteGoal();
        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn vào bàn thắng trên bảng ");
        }
    }
}
