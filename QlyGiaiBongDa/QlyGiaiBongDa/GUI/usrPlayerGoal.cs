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
    }
}
