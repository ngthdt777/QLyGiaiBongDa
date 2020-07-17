using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QlyGiaiBongDa.GUI;
using QlyGiaiBongDa.BLL;
using System.Data.SqlClient;
using QlyGiaiBongDa.DAL;
using System.Windows.Forms;

namespace QlyGiaiBongDa.BLL
{
    public class ObjTeamBLL
    {
        private static ObjTeamBLL instance;

        public static ObjTeamBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjTeamBLL();
                }
                return instance;
            }
            set { instance = value; }
        }


       public DataTable GetListTeam()
       {
            return ObjTeamDAL.Instance.LoadListTeam();
       }


        public DataTable GetNameTeam()
        {
            return ObjTeamDAL.Instance.LoadNameTeam();
        }


        public DataTable GetListPlayer()
        {
            return ObjTeamDAL.Instance.LoadListPlayer();
        }



        public void AddPlayer()
        {
           ObjTeamDAL.Instance.AddPlayer();
        }




       public DataTable GetPlayerType()
        {
            return ObjTeamDAL.Instance.LoadPlayerType();
        }




        // goi lai ham thay doi tu DAL, Duy Bao Change
        public void DeletePlayer()
        {
            ObjTeamDAL.Instance.DeletePlayer();
        }


        public void AddTeam()
        {
            ObjTeamDAL.Instance.AddTeam();
        }


        public void DeleteTeam()
        {
            ObjTeamDAL.Instance.DeleteTeam();
        }


        public void Bindings()
        {
            ObjTeamDAL.Instance.Bindings();
        }



        public void UpdateTeam()
        {
            ObjTeamDAL.Instance.UpdateTeam();
        }

        public void UpdatePlayer()
        {
            ObjTeamDAL.Instance.UpdatePlayer();
        }

    }
}
