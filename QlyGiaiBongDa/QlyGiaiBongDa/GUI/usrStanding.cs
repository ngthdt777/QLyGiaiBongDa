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
    public partial class usrStanding : UserControl
    {
        private static usrStanding _instance;
        public static usrStanding Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrStanding();
                return _instance;
            }
        }
        public usrStanding()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dgv_BXH.DataSource = ObjStandingBLL.Instance.GetlistStanding();
        }

        private void usrStanding_Load(object sender, EventArgs e)
        {
            cbb_team_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbb_team_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_team_name.DisplayMember = "TenDoi";
            cbb_team_name.ValueMember = "TenDoi";
            cbb_team_name.DataSource = ObjStandingBLL.Instance.GetTeam();
           

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            dgv_BXH.DataSource = ObjStandingBLL.Instance.FindTeam();
        }
    }

    

      
    
}
