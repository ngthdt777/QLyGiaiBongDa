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
    }
}
