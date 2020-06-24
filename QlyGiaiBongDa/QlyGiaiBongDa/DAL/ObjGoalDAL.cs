using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QlyGiaiBongDa.GUI;
using QlyGiaiBongDa.BLL;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QlyGiaiBongDa.DAL
{
    class banthang
    {
        public string mab { get; set; }
        public string ma_ct { get; set; }
        public string ma_lbt { get; set; }
        public string thoidiem { get; set; }
        public string id_td { get; set; }
        public banthang() { }
    }


    public class ObjGoalDAL
    {
        private static ObjGoalDAL instance;

        public static ObjGoalDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjGoalDAL();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjGoalDAL() { }


        //    System.Windows.Forms.UserControl u = new usrPlayerGoal(); // Tao usrPlayerGoal moi


        public DataTable LoadListPlayerGoal()
        {
            DataTable dt = new DataTable();


            string LoadQuery = "select TenCauThu, TenDoi, MaLoaiCauThu, COUNT(MaLoaiBanThang) as SOBANTHANG" +
                " from DOIBONG, CAUTHU, BANTHANG where DOIBONG.MaDoi = CAUTHU.MaDoi and CAUTHU.MaCauThu = '1001' " +
                "group by TenCauThu, TenDoi, MaLoaiCauThu, MaLoaiBanThang";
            


            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }


    }
}
