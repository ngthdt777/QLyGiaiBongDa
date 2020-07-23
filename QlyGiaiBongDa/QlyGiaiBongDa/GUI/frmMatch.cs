using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyGiaiBongDa.BLL;


namespace QlyGiaiBongDa.GUI
{
    public partial class frmMatch : Form
    {
        private static frmMatch instance;

        public static frmMatch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmMatch();
                }
                return instance;
            }
            set { instance = value; }
        }
        public frmMatch()
        {
            InitializeComponent();
        }

        public Boolean CheckID()
        {
            return ObjRoundBLL.Instance.CheckID() ;
        }




        private void btt_team_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_match_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã trận đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_match_id.Focus();
            }
            if (string.IsNullOrEmpty(cb_VongDau.Text))
            {
                MessageBox.Show("Bạn chưa nhập vòng đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_VongDau.Focus();
            }
            else if (CheckID())
            {
 
                if (string.IsNullOrEmpty(cb_doinha.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên đội nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_doinha.Focus();
                }
                else if (string.IsNullOrEmpty(cb_doikhach.Text) || (cb_doikhach.Text == cb_doinha.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên đội khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cb_doikhach.Focus();
                }
                else if (string.IsNullOrEmpty(tb_GioThiDau.Text))
                {
                    MessageBox.Show("Bạn chưa nhập giờ thi đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_GioThiDau.Focus();
                }
                else if (string.IsNullOrEmpty(tb_match_court.Text))
                {
                    MessageBox.Show("Bạn chưa nhập sân đá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_match_court.Focus();
                }
                else if (string.IsNullOrEmpty(tb_match_tiso.Text) || (tb_match_tiso.Text == "<DoiNha><DoiKhach>"))
                {
                    MessageBox.Show("Bạn chưa nhập tỉ số trận đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_match_tiso.Focus();
                }
                else ObjRoundBLL.Instance.Add();
            }
            
        }

        private void frmMatch_Load(object sender, EventArgs e)
        {
            cb_doinha.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_doinha.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_doinha.DisplayMember = "MaDoi";
            cb_doinha.ValueMember = "MaDoi";
            cb_doinha.DataSource = ObjPlayerBLL.Instance.GetCodeTeam();

            cb_doikhach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_doikhach.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_doikhach.DisplayMember = "MaDoi";
            cb_doikhach.ValueMember = "MaDoi";
            cb_doikhach.DataSource = ObjPlayerBLL.Instance.GetCodeTeam();


            
        }



        private void cb_VongDau_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  ObjRoundBLL.Instance.GetNextMatchID();
        }
    }
}
