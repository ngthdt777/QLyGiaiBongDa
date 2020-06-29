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
    public class ObjRulesChangeBLL
    {


        private static ObjRulesChangeBLL instance;

        public static ObjRulesChangeBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjRulesChangeBLL();
                }
                return instance;
            }
            set { instance = value; }
        }



        public Boolean  CheckTuoiMin()
        {
           return  ObjthamsoDAL.Instance.CheckTuoiMin();
        }


        public Boolean CheckTuoiMax()
        {
           return ObjthamsoDAL.Instance.CheckTuoiMax();
        }

        public Boolean CheckSoLgMin()
        {
            return ObjthamsoDAL.Instance.CheckSoLgMin();
        }


        public Boolean CheckSoLgMax()
        {
            return ObjthamsoDAL.Instance.CheckSoLgMax();
        }


        public Boolean CheckForMax()
        {
            return ObjthamsoDAL.Instance.CheckForMax();
        }


        public Boolean CheckDiemSoThang()
        {
            return ObjthamsoDAL.Instance.CheckDiemSoThang();
        }


        public Boolean CheckDiemSoHoa()
        {
            return ObjthamsoDAL.Instance.CheckDiemSoHoa();
        }


        public Boolean CheckDiemSoThua()
        {
            return ObjthamsoDAL.Instance.CheckDiemSoThua();
        }


        public Boolean CheckMaxTimeScore()
        {
            return ObjthamsoDAL.Instance.CheckMaxTimeScore();
        }

    }
}
