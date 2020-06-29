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


            // dgv_BXH.DataSource = ObjStandingBLL.Instance.GetListStanding();
            ObjStandingBLL.Instance.LoadInfo();
            dgv_BXH.DataSource = ObjStandingBLL.Instance.GetlistStanding();


        }

        private void usrStanding_Load(object sender, EventArgs e)
        {
           // dgv_BXH.DataSource = ObjStandingBLL.Instance.GetlistStanding();
        }

        private void tb_mtd_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
