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
    public partial class usrTeam : UserControl
    {
        private static usrTeam _instance;
        public static usrTeam Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrTeam();
                return _instance;
            }
        }
        public usrTeam()
        {
            InitializeComponent();
        }

        private void usrTeam_Load(object sender, EventArgs e)
        {

        }
    }
}
