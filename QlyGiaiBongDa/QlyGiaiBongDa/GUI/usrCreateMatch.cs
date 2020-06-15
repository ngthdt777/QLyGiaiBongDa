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
    }
}
