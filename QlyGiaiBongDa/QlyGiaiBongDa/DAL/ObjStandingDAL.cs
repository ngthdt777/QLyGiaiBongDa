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
    public class Standing
    {
        public string DiemSoThang { get; set; }
        public string DiemSoHoa { get; set; }
        public string DiemSoThua { get; set; }
        public string ThuTuUuTienXepHang { get; set; }
        public string MaTranDau { get; set; }
        public string MaVongDau { get; set; }
        public Standing() { }

    }




    public class ObjStandingDAL
    {
        private static ObjStandingDAL instance;

        public static ObjStandingDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjStandingDAL();
                }
                return instance;
            }
            set { instance = value; }
        }




        private ObjStandingDAL() { }


        public DataTable LoadListStanding()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "select TenCauThu, TenDoi, MaLoaiCauThu, COUNT(MaLoaiBanThang) as SOBANTHANG" +
                " from DOIBONG, CAUTHU, BANTHANG where DOIBONG.MaDoi = CAUTHU.MaDoi and CAUTHU.MaCauThu = '1001' " +
                "group by TenCauThu, TenDoi, MaLoaiCauThu, MaLoaiBanThang";


            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }


