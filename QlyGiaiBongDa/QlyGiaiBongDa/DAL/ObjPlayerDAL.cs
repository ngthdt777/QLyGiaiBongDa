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
        public ObjPlayerDAL() { }



        public DataTable LoadNameTeam_usrPlayer()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenDoi FROM DOIBONG";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }



        public DataTable LoadListFindPlayer()
        {
            string id, ten, loaict, doibong, tuoi_min, tuoi_max, ghichu;


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

            if (!string.IsNullOrEmpty(usrPlayer.Instance.tb_GhiChu.Text))
                ghichu = "='" + usrPlayer.Instance.tb_GhiChu.Text + "'";
            else ghichu = "is not null";


            DataTable dt = new DataTable();
            string LoadQuery = "SELECT MaCauThu,TenCauThu,DATEDIFF(YY, NgaySinh, GETDATE()) AS[AGE],MaLoaiCauThu,TenDoi,GhiChu FROM CAUTHU,DOIBONG" +
                                " where MaCauThu "+ id + " and TenCauThu " + ten + " and MaLoaiCauThu " + loaict + "" +
                                 " and DOIBONG.TenDoi " + doibong + "  and GhiChu " + ghichu + " " +
                                 " and DATEDIFF(YY, NgaySinh, GETDATE())" + tuoi_min + " and DATEDIFF(YY, NgaySinh, GETDATE())" + tuoi_max ;
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }




    }
}
