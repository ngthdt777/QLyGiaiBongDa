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
   public class ObjResultMatchBLL
    {
        private static ObjResultMatchBLL instance;

        public static ObjResultMatchBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjResultMatchBLL();
                }
                return instance;
            }
            set { instance = value; }
        }



        public DataTable GetListResultMatch()
        {
            return ObjMatchDAL.Instance.LoadListResultMatch();
        }


    }
}
