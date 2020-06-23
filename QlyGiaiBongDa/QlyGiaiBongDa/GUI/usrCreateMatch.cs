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
    public partial class usrCreateMatch : UserControl
    {
        private static usrCreateMatch _instance;
        public static usrCreateMatch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrCreateMatch();
                return _instance;
            }
        }
        public usrCreateMatch()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            dgv_TLTD.DataSource = ObjRoundMatchBLL.Instance.GetListRoundMatch();
        }
    }
}
