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
   public  class ObjRoundBLL
    {

        private static ObjRoundBLL instance;

        public static ObjRoundBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjRoundBLL();
                }
                return instance;
            }
            set { instance = value; }
        }



        public DataTable GetListRoundMatch()
        {
            return ObjRoundDAL.Instance.LoadListRoundMatch();
        }



        public DataTable Add()
        {
            return ObjRoundDAL.Instance.AddMatch();
        }



        public DataTable DeleteMatch()
        {
            return ObjRoundDAL.Instance.DeleteMatch();
        }

       public void UpdateMatch()
        {
            ObjRoundDAL.Instance.UpdateMatch();
        }
    
        public DataTable GetRound()
        {
            return ObjRoundDAL.Instance.LoadRound();
        }

        public Boolean CheckID()
        {
            return ObjRoundDAL.Instance.CheckID();
        }



    /*    public void GetNextMatchID()
        {
            ObjRoundDAL.Instance.GetNextMatchID();
        }
        */

    }
}
