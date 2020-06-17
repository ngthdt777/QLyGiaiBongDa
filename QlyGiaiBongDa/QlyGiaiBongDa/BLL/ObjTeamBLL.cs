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
        public void Add()
        {
            ObjTeamDAL.Instance.Add();
        }
        public DataTable PlayerView()
        {
            return ObjTeamDAL.Instance.PlayerView();
        }

        // goi lai ham thay doi tu DAL, Duy Bao Change
        public void Delete()
        {
            ObjTeamDAL.Instance.Delete();
        }
    }
}
