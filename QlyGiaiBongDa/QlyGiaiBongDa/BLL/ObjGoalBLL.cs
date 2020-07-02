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
    public  class ObjGoalBLL
    {


        private static ObjGoalBLL instance;

        public static ObjGoalBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjGoalBLL();
                }
                return instance;
            }
            set { instance = value; }
        }


        // hiển thị cầu thủ ghi bàn 
        public DataTable GetListPlayerGoal()
        {
            return ObjGoalDAL.Instance.LoadListPlayerGoal();
        }


        
    }
}
