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




        public DataTable LoadRound()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenVongDau from VONGDAU";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }

        public DataTable LoadListPlayerGoal()
        {
            DataTable dt = new DataTable();

            string vongdau = usrPlayerGoal.Instance.cb2.Text;

            string LoadQuery = "SELECT TenCauThu, TenDoi, LoaiCauThu, COUNT(BANTHANG.MaCauThu) as 'Số Bàn Thắng' FROM DOIBONG, CAUTHU, BANTHANG, TRANDAU"+
          " where DOIBONG.MaDoi = CAUTHU.MaDoi and CAUTHU.MaCauThu = BANTHANG.MaCauThu and BANTHANG.MaTranDau = TRANDAU.MaTranDau and TRANDAU.MaVongDau = '"+vongdau+"' " +
          "GROUP BY TenCauThu,TenDoi,LoaiCauThu";



            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }

      
     

    }
}
