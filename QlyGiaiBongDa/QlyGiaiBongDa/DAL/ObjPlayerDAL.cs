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
    class cauthu
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime ngsinh { get; set; }
        public string maloaict { get; set; }
        public string ghichu { get; set; }
        public string ma_doi { get; set; }
        public cauthu(string ma, string ten, DateTime ngsinh, string maloaict,string ghichu, string ma_doi)
        {
            this.ma=ma;
            this.ten = ten;
            this.ngsinh = ngsinh;
            this.maloaict = maloaict;
            this.ghichu = ghichu;
            this.ma_doi = ma_doi;
        }
        public cauthu() { }
    }
}
/*public class ObjPlayerDAL
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
   // public cauthu player = new cauthu();
    System.Windows.Forms.UserControl u = new usrPlayer();

    public DataTable LoadListTeam()
    {
        DataTable dt = new DataTable();
        string LoadQuery = "SELECT * FROM DoiBong";
        dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
        return dt;
    }
    */