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

        private void btt_team_add_Click(object sender, EventArgs e)
        {
            ObjRoundBLL.Instance.Add();
        }


    }
}
