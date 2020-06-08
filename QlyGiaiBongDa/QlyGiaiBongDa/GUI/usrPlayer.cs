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
    public partial class usrPlayer : UserControl
    {
        private static usrPlayer _instance;
        public static usrPlayer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrPlayer();
                return _instance;
            }
        }
        public usrPlayer()
        {
            InitializeComponent();
        }

        private void usrPlayer_Load(object sender, EventArgs e)
        {

        }

    }
}

