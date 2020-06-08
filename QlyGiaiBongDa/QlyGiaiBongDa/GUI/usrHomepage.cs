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

        }
    }
}
