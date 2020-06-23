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
    public partial class usrResultMatch : UserControl
    {
        private static usrResultMatch _instance;
        public static usrResultMatch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrResultMatch();
                return _instance;
            }
        }
        public usrResultMatch()
        {
            InitializeComponent();
        }

        private void btt_Bxh_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmQLGBD"];
            if (!((frmQLGBD)f).pnlMain.Controls.Contains(usrStanding.Instance))
            {
                ((frmQLGBD)f).pnlMain.Controls.Add(usrStanding.Instance);
                usrStanding.Instance.Dock = DockStyle.Fill;
                usrStanding.Instance.BringToFront();
            }
            else
                usrStanding.Instance.BringToFront();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
