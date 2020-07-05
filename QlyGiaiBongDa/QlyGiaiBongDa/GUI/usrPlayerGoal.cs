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
    public partial class usrPlayerGoal : UserControl
    {
        private static usrPlayerGoal _instance;
        public static usrPlayerGoal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrPlayerGoal();
                return _instance;
            }
        }
        public usrPlayerGoal()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_BXH_playergoal.DataSource = ObjGoalBLL.Instance.GetListPlayerGoal();
        }

        
        

      

        // hiện usr Goaldetail
        private void btn_XuatBaocao_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmQLGBD"];
            if (!((frmQLGBD)f).pnlMain.Controls.Contains(usrGoalDetail.Instance))
            {
                ((frmQLGBD)f).pnlMain.Controls.Add(usrGoalDetail.Instance);
                usrGoalDetail.Instance.Dock = DockStyle.Fill;
                usrGoalDetail.Instance.BringToFront();
            }
            else
                usrGoalDetail.Instance.BringToFront();

        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn chi tiết để biết thêm thông tin bàn thắng. " +
                            "Chọn tìm kiếm để biết thông tin vua phá lưới. ");

        }

        private void usrPlayerGoal_Load(object sender, EventArgs e)
        {
            cb2.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.DisplayMember = "TenVongDau";
            cb2.ValueMember = "TenVongDau";
            cb2.DataSource = ObjGoalBLL.Instance.GetRound();
            cb2.Text = " Chọn vòng đấu ";
        }
    }
}
