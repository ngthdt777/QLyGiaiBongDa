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
    }
}
