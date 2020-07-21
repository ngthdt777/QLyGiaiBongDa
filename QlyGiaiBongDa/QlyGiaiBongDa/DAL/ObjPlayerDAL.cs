using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using QlyGiaiBongDa.GUI;
using QlyGiaiBongDa.BLL;

namespace QlyGiaiBongDa.DAL
{
    public class cauthu
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime ngsinh { get; set; }
        public string loaict { get; set; }
        public string thoigiantd { get; set; }
        public string tinhtrang { get; set; }
        public string ma_doi { get; set; }
        public cauthu(string ma, string ten, DateTime ngsinh, string loaict, string thoigiantd,string tinhtrang, string ma_doi)
        {
            this.ma = ma;
            this.ten = ten;
            this.ngsinh = ngsinh;
            this.loaict = loaict;
            this.thoigiantd = thoigiantd;
            this.tinhtrang = tinhtrang;
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
        public ObjPlayerDAL() { }



        public DataTable LoadCodeTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT MaDoi FROM DOIBONG";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }
        public DataTable LoadNameTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenDoi FROM DOIBONG";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }
            public DataTable LoadPlayerType()   
        {
            DataTable dt = new DataTable();

            string LoadQuery = "SELECT LoaiCauThu from CauThu" +
                " group by LoaiCauThu ";

            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }


        public DataTable LoadListFindPlayer()
        {
            string id, ten, loaict, doibong, tuoi_min, tuoi_max, tgian,thetrang;


            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_MaCT.Text))
                id = "='"+usrPlayer.Instance.tb_MaCT.Text+"'";
            else id = "is not null";

            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_HoTen.Text))
                ten = "='" + usrPlayer.Instance.tb_HoTen.Text + "'";
            else ten = "is not null";

            if (!string.IsNullOrEmpty(usrPlayer.Instance.cb_LoaiCT.Text))
                loaict = "='" + usrPlayer.Instance.cb_LoaiCT.Text + "'";
            else loaict = "is not null";


            if (!string.IsNullOrEmpty(usrPlayer.Instance.cbb_team_name.Text))
                doibong = "='" + usrPlayer.Instance.cbb_team_name.Text + "'";
            else doibong = "is not null";


            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_tuoimin.Text))
                tuoi_min =">"+ "(SELECT CAST('" + usrPlayer.Instance.tb_tuoimin.Text + "' as int))";
            else tuoi_min = "is not null";

            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_tuoimax.Text))
                tuoi_max = "<"+ "(SELECT CAST('" + usrPlayer.Instance.tb_tuoimax.Text + "' as int))";
            else tuoi_max = "is not null";

            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_tgian.Text) || (usrPlayer.Instance.tb_tgian.Text!="<Thi Dau ? nam>"))
                tgian = "='" + usrPlayer.Instance.tb_tgian.Text + "'";
            else tgian= "is not null";


            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_thetrang.Text))
                thetrang = "='" + usrPlayer.Instance.tb_thetrang.Text + "'";
            else thetrang = "is not null";



            DataTable dt = new DataTable();
            string LoadQuery = "SELECT DISTINCT MaCauThu,TenCauThu,DATEDIFF(YY, NgaySinh, GETDATE()) AS[Tuổi Cầu Thủ],LoaiCauThu,TenDoi,ThoiGianThiDau,TinhTrang FROM CAUTHU,DOIBONG" +
                                " where MaCauThu "+ id + " and TenCauThu " + ten + " and LoaiCauThu " + loaict + " " +
                                 " and DOIBONG.TenDoi " + doibong + "  and ThoiGianThiDau " + tgian + " and TinhTrang " + thetrang + " " +
                                 " and DATEDIFF(YY, NgaySinh, GETDATE())" + tuoi_min + " and DATEDIFF(YY, NgaySinh, GETDATE())" + tuoi_max + " and CAUTHU.MaDoi = DOIBONG.MaDoi";
           dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

           return dt;
        }




    }
}
