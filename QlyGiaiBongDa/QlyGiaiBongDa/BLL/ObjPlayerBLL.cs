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
   public  class ObjPlayerBLL
    {

        private static ObjPlayerBLL instance;

        public static ObjPlayerBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjPlayerBLL();
                }
                return instance;
            }
            set { instance = value; }
        }


        public DataTable GetListFindPlayer()
        {
            return ObjPlayerDAL.Instance.LoadListFindPlayer();
        }
        public DataTable LoadListPlayer()
        {
            return ObjPlayerDAL.Instance.LoadListFindPlayer();
        }

        public DataTable GetNameTeam()
        {
            return ObjPlayerDAL.Instance.LoadNameTeam();
        }

        public DataTable GetPlayerType()
        {
            return ObjPlayerDAL.Instance.LoadPlayerType();
        }


    }
}
