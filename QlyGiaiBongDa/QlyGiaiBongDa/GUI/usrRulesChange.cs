using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyGiaiBongDa.GUI
{
    public partial class usrRulesChange : UserControl
    {
        private static usrRulesChange _instance;
        public static usrRulesChange Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrRulesChange();
                return _instance;
            }
        }
        public usrRulesChange()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            nm_tuoimin.Value = 16;
            nm_tuoimax.Value = 40;
            nm_slngmin.Value = 5;
            nm_slgmax.Value=22;
            nm_foreignmax.Value=3;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            nm_win.Value = 3;
            nm_eqaul.Value = 1;
            nm_eqaul.Value = 0;
        }
    }
}
