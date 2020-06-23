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
   public  class ObjRoundMatchBLL
    {

        private static ObjRoundMatchBLL instance;

        public static ObjRoundMatchBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjRoundMatchBLL();
                }
                return instance;
            }
            set { instance = value; }
        }



        public DataTable GetListRoundMatch()
        {
            return ObjRoundDAL.Instance.LoadListRoundMatch();
        }
    }
}
