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
    public class ObjGoalDetailBLL
    {


        private static ObjGoalDetailBLL instance;

        public static ObjGoalDetailBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjGoalDetailBLL();
                }
                return instance;
            }
            set { instance = value; }
        }


        public DataTable GetListGoal()
        {
            return ObjGoalDetailDAL.Instance.LoadListGoal();
        }

        public void AddGoal()
        {
            ObjGoalDetailDAL.Instance.AddGoal();
        }

        public void DeleteGoal()
        {
            ObjGoalDetailDAL.Instance.DeleteGoal();
        }

        public void UpdateGoal()
        {
            ObjGoalDetailDAL.Instance.UpdateGoal();
        }
    }
}