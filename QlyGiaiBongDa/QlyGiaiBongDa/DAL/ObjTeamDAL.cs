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
    public class DoiBong
    {
        public string id { get; set; }
        public string ten { get; set; }
        public string ten_sannha { get; set; }
        public string slgct { get; set; }
        public DoiBong(string id, string ten, string ten_sannha, string slgct)
        {
            this.id = id;
            this.ten = ten;
            this.ten_sannha = ten_sannha;
            this.slgct = slgct;
        }
        public DoiBong() { }
    }
    public class ObjTeamDAL
    {
        private static ObjTeamDAL instance;

        public static ObjTeamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjTeamDAL();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjTeamDAL() { }

        public DoiBong Team = new DoiBong();
        System.Windows.Forms.UserControl u = new usrTeam();

        public DataTable LoadListTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT * FROM DoiBong";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }

        bool CheckMaDoi(string id)
        {
            /*string query = "SELECT MaDoi FROM DOIBONG WHERE MaDoi = '" + id + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;*/
            return true;
        }
        public void Add()
        {

            string id = ((usrTeam)u).tb_MaDoi.Text;
            string tendoi = ((usrTeam)u).tb_TenDoi.Text;
            string slgct = ((usrTeam)u).tb_SCT.Text;
            string sannha = ((usrTeam)u).tb_SanNha.Text;
            Team.id = id;
            Team.ten = tendoi;
            Team.slgct = slgct;
            Team.ten_sannha = sannha;
            if (true)
            {
                if (CheckMaDoi(Team.id) == true)
                {
                    string AddQuery = "INSERT INTO DOIBONG(MaDoi,TenDoi,SanNha,SoCauThu" +
                        "VALUES('" + Team.id + "', '" + Team.ten + "', '" + Team.ten_sannha + "', '" + Team.slgct + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("OKE da add ");
                    }
                }
                else MessageBox.Show("Ton tai");
            }
            else MessageBox.Show("Mã đội bóng phải nhỏ hơn 5 và lớn hơn 0 kí tự ", "Thông báo", MessageBoxButtons.OK);
        }
        public DataTable PlayerView()
        {
            string id = usrTeam.Instance.tb_MaDoi.Text.ToString();
            string tendoi = usrTeam.Instance.tb_TenDoi.Text;
            string FindQuery = " SELECT MaCauThu,TenCauThu,NgaySinh,TenLoaiCauThu,TenDoi " +
                "FROM CAUTHU,DOIBONG,LOAICAUTHU " +
               " Where CAUTHU.MaDoi = '" + id + "'AND LOAICAUTHU.MaLoaiCauThu=CAUTHU.MaLoaiCauThu";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
            return data;
        }



        public void Bindings()
        {
            System.Windows.Forms.UserControl u = new usrTeam();
            ((usrTeam)u).tb_MaDoi.DataBindings.Clear();
            ((usrTeam)u).tb_TenDoi.DataBindings.Clear();
            ((usrTeam)u).tb_SCT.DataBindings.Clear();
            ((usrTeam)u).tb_SanNha.DataBindings.Clear();
            ((usrTeam)u).tb_MaDoi.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "MaDoi"));
            ((usrTeam)u).tb_TenDoi.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "TenDoi"));
            ((usrTeam)u).tb_SCT.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "slgct"));
            ((usrTeam)u).tb_SanNha.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "SanNha"));
        }
    }
}

