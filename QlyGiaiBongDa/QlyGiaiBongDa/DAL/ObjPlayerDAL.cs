using QlyGiaiBongDa.BLL;
using QlyGiaiBongDa.DAL;
using QlyGiaiBongDa.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QlyGiaiBongDa.DAL
{
    public class cauthu
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime ngsinh { get; set; }
        public string maloaict { get; set; }
        public string ghichu { get; set; }
        public string ma_doi { get; set; }
        public cauthu(string ma, string ten, DateTime ngsinh, string maloaict, string ghichu, string ma_doi)
        {
            this.ma = ma;
            this.ten = ten;
            this.ngsinh = ngsinh;
            this.maloaict = maloaict;
            this.ghichu = ghichu;
            this.ma_doi = ma_doi;
        }
        public cauthu() { }
    }
    public class ObjPlayerDAL
    {
        private static ObjPlayerDAL instance;

        public static ObjPlayerDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjPlayerDAL();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjPlayerDAL() { }



        public DataTable LoadListFindPlayer()
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
