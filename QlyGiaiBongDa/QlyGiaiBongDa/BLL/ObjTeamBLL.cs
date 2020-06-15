using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QlyGiaiBongDa.GUI;
using QlyGiaiBongDa.BLL;
using System.Data.SqlClient;
using QlyGiaiBongDa.DAL;
using System.Windows.Forms;

namespace QlyGiaiBongDa.BLL
{
    public class ObjTeamBLL
    {

        private static ObjTeamBLL instance;

        public static ObjTeamBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjTeamBLL();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjTeamBLL() { }

        public DoiBong Team = new DoiBong();
        string LoadQuery = "SELECT * FROM DOIBONG";
        public DataTable LoadCustomerData()
        {

            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return data;

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
            System.Windows.Forms.UserControl u = new usrTeam();
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
    }
}
