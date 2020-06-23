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
    class vongdau
    {
        public string ma { get; set; }
        public string ten_vd { get; set; }
        public vongdau() { }
    }

    public class ObjRoundDAL
    {
        private static ObjRoundDAL instance;

        public static ObjRoundDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjRoundDAL();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjRoundDAL() { }


        public DataTable LoadListRoundMatch()
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

