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



namespace QlyGiaiBongDa.BLL
{




    public class trandau
    {
        public string ma { get; set; }
        public string doi_nha { get; set; }
        public string doi_khach { get; set; }
        public string ngay_td { get; set; }
        public string gio_td { get; set; }
        public string san_td { get; set; }
        public string ti_so { get; set; }
        public string ma_vd { get; set; }
        public trandau() { }
    }





    public class ObjMatchDAL
    {
        private static ObjMatchDAL instance;

        public static ObjMatchDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjMatchDAL();
                }
                return instance;
            }
            set { instance = value; }
        }



        private ObjMatchDAL() { }


        public DataTable LoadListResultMatch()
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