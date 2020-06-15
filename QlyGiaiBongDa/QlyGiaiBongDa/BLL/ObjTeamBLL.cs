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
        public DataTable GetListTeam()
        {
            return ObjTeamDAL.Instance.LoadListTeam();
        }
       
    }
}
