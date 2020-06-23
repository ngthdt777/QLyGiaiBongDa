using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QlyGiaiBongDa.GUI;
using System.Data.SqlClient;
using QlyGiaiBongDa.DAL;
using System.Windows.Forms;
using QlyGiaiBongDa.BLL;

namespace QlyGiaiBongDa.BLL
{
        public class ObjStandingBLL
        {

        private static ObjStandingBLL instance;



        public static ObjStandingBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjStandingBLL();
                }
                return instance;
            }
            set { instance = value; }
        }

        public DataTable GetListStanding()
        {
            return ObjStandingDAL.Instance.LoadListStanding();
        }

    }
}
