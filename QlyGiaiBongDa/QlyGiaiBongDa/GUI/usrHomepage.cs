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

namespace QlyGiaiBongDa.GUI
{
    public partial class usrHomepage : UserControl
    {
        private static usrHomepage _instance;
        public static usrHomepage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrHomepage();
                return _instance;
            }
        }
        public usrHomepage()
        {
            InitializeComponent();
        }

        private void usrHomepage_Load(object sender, EventArgs e)
        {
            dgv_Home.DataSource = ObjTeamBLL.Instance.GetListTeam();
            cb_Team_slgct.Text = "0";
        }

        public static int demkhoangtrang(string str)
        {
            int bien_dem = 0;
            string str1;
            for(int i=0;i<str.Length;i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    bien_dem++;
            }
            return bien_dem;
        }
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
            if (string.IsNullOrEmpty(cb_Team_slgct.Text))
            {
                MessageBox.Show("Bạn chưa nhập số cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Team_slgct.Focus();
                if ((ObjRulesChangeBLL.Instance.CheckSoLgMax() == false) && (ObjRulesChangeBLL.Instance.CheckSoLgMin() == false))
                {
                    return false;
                }

                return false;
            }
            if (string.IsNullOrEmpty(tb_SanNha.Text))
            {
                MessageBox.Show("Bạn chưa nhập sân nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_SanNha.Focus();
                return false;
            }
            if(tb_MaDoi.Text.Length<0 || tb_MaDoi.Text.Length>4)
            {
                MessageBox.Show("Mã đội chỉ được nhập 4 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           /* if(demkhoangtrang(tb_TenDoi.Text)<=)
            {
                MessageBox.Show("Tên đội không được ít hơn 3 từ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            */
            if(tb_TenDoi.Text.Length>45)
            {
                MessageBox.Show("Tên đội quá nhiều kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (tb_SanNha.Text.Length > 45)
            {
                MessageBox.Show("Sân nhà quá nhiều kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btt_team_add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ObjTeamBLL.Instance.AddTeam();
                Bindings();
            }
            dgv_Home.DataSource = ObjTeamBLL.Instance.GetListTeam();
            
        }

        private void btt_team_era_Click(object sender, EventArgs e)
        {
            ObjTeamBLL.Instance.DeleteTeam();
            Bindings();
            dgv_Home.DataSource = ObjTeamBLL.Instance.GetListTeam();
            

        }

        /*   public void  dgv_Home_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
              {

                  tb_MaDoi.Text = dgv_Home.Rows[e.RowIndex].Cells[0].Value.ToString();
                  tb_TenDoi.Text = dgv_Home.Rows[e.RowIndex].Cells[1].Value.ToString();
                  tb_SCT.Text = dgv_Home.Rows[e.RowIndex].Cells[2].Value.ToString();
                  tb_SanNha.Text = dgv_Home.Rows[e.RowIndex].Cells[3].Value.ToString();
              }
      */
        private void dgv_Home_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_MaDoi.Text = dgv_Home.Rows[e.RowIndex].Cells["MaDoi"].Value.ToString();
                tb_TenDoi.Text = dgv_Home.Rows[e.RowIndex].Cells["TenDoi"].Value.ToString();
                cb_Team_slgct.Text = dgv_Home.Rows[e.RowIndex].Cells["SoCauThu"].Value.ToString();
                tb_SanNha.Text = dgv_Home.Rows[e.RowIndex].Cells["SanNha"].Value.ToString();
            }
        }

        private void btt_team_fix_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ObjTeamBLL.Instance.UpdateTeam();
                Bindings();
            }
            dgv_Home.DataSource = ObjTeamBLL.Instance.GetListTeam();
            

        }

        private void Bindings()
        {
            tb_MaDoi.Clear();
            tb_SanNha.Clear();
            tb_TenDoi.Clear();
            cb_Team_slgct.Text = "0";
        }


    }
}
