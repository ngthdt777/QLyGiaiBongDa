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
using System.Drawing;

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

    //    public DoiBong Team = new DoiBong();
      System.Windows.Forms.UserControl u = new usrTeamList();
        public DataTable LoadListTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT MaDoi,TenDoi,SanNha,SoCauThu FROM DOIBONG";
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


        public DataTable LoadNameTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenDoi FROM DOIBONG";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }
       
        


        public DataTable LoadNameTeam_usrPlayer()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenDoi FROM DOIBONG";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }



        public void CountForeign()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                string tendoi = usrTeamList.Instance.cbb_team_name.Text;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select Count(LoaiCauThu) AS SoCauThuNgoaiQuoc from CAUTHU, DOIBONG" +
"               where CAUTHU.MaDoi = DOIBONG.MaDoi AND LoaiCauThu = 'Ngoai Nuoc' AND DOIBONG.TenDoi = '" + tendoi + "'", connection);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string slg = da.GetValue(0).ToString();
                    usrTeamList.Instance.lb_hsdb_sctnq.Text = slg.ToString();
                    usrTeamList.Instance.lb_hsdb_sctnq.Font = new Font("Segoe UI SemiLight", 10.2f);
                }
            }
        }




        public void GetTeamID()
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                string tendoi = usrTeamList.Instance.cbb_team_name.Text;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select MaDoi from DOIBONG where TenDoi = '" + tendoi + "'", connection);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    usrTeamList.Instance.tb_MaDoi.Text = da.GetValue(0).ToString();
                    usrTeamList.Instance.tb_MaDoi.ReadOnly = true;
                    usrTeamList.Instance.tb_MaDoi.TextAlign = HorizontalAlignment.Center;
                    usrTeamList.Instance.tb_MaDoi.BaseColor = Color.DarkGray;
                }
            }
        }


        public void GetNextIDPlayer()
        {

            string tendoi = usrTeamList.Instance.cbb_team_name.Text;

            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaCauThu FROM DOIBONG,CAUTHU where TenDoi = '" + tendoi + "' and DOIBONG.MaDoi = CauThu.MaDoi ORDER BY MaCauThu DESC", connection);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    string mact = da.GetValue(0).ToString();
                    int nextid = Int32.Parse(mact.Substring(2, 2))+1;
                    usrTeamList.Instance.tb_hsdb_mact.Text =  mact.Substring(0,2) + nextid.ToString() ;
                    usrTeamList.Instance.tb_hsdb_mact.ReadOnly = true;
                    usrTeamList.Instance.tb_hsdb_mact.TextAlign = HorizontalAlignment.Center;
                    usrTeamList.Instance.tb_hsdb_mact.BaseColor = Color.DarkGray;
                    usrTeamList.Instance.tb_hsdb_tenct.Focus();
                }
            }



        }



        public DataTable LoadListPlayer()
        {
            string TenDoi = usrTeamList.Instance.cbb_team_name.Text;
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT MaCauThu,TenCauThu,NgaySinh,LoaiCauThu,TinhTrang,ThoiGianThiDau,CAUTHU.MaDoi FROM CAUTHU,DOIBONG " +
                "WHERE CAUTHU.MaDoi=DOIBONG.MaDoi AND TenDoi='" + TenDoi + "'";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }






        bool CheckMaDoi(string id)
        {
            string query = "SELECT MaDoi FROM DOIBONG WHERE MaDoi = '" + id + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }



       public void AddPlayer()
        {

            string id = usrTeamList.Instance.tb_hsdb_mact.Text;
            string tenct = usrTeamList.Instance.tb_hsdb_tenct.Text;
            string ngsinh = usrTeamList.Instance.dtp_cauthu_ngsinh.Value.ToString();
            string loaict = usrTeamList.Instance.cb_hsdb_loaict.Text;        
            string madoi = usrTeamList.Instance.tb_MaDoi.Text;
            string thoigiantd = usrTeamList.Instance.tb_hsdb_tgiantd.Text;
            string tinhtrang = usrTeamList.Instance.tb_hsdb_thetrang.Text;

            if (CheckMaDoi(id) == true)
            {
                
                    string AddQuery = "INSERT INTO CAUTHU(MaCauThu,TenCauThu,NgaySinh,LoaiCauThu,ThoiGianThiDau,TinhTrang,MaDoi)" +
                        "VALUES('" + id + "', '" + tenct + "', '" + ngsinh + "', '" + loaict + "', '" + thoigiantd + "','"+ tinhtrang+"', '" + madoi + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show(" Đã thêm cầu thủ ");
                        usrTeamList.Instance.dgv_HSDB.DataSource= LoadListPlayer();
                    }

            }
            else MessageBox.Show("Cầu thủ tồn tại");

        }






        public void AddTeam()
        {
            string id = usrHomepage.Instance.tb_MaDoi.Text;
            string tendoi = usrHomepage.Instance.tb_TenDoi.Text;
            string slgct = usrHomepage.Instance.cb_Team_slgct.Text;
            string sannha = usrHomepage.Instance.tb_SanNha.Text;


            if (CheckMaDoi(id) == true)
            {
                string AddQuery = "INSERT INTO DOIBONG(MaDoi,TenDoi,SanNha,SoCauThu)" +
                        "VALUES('" + id + "', '" + tendoi + "', '" + sannha + "', '" + slgct + "')";
                int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                if (result > 0)
                {
                    MessageBox.Show(" Đã thêm đội bóng  ");
                }
            }
            else MessageBox.Show("Đội bóng đã tồn tại");
        }






        public DataTable PlayerView()
        {
            string id = usrTeamList.Instance.tb_MaDoi.Text.ToString();
        //    string tendoi = usrTeam.Instance.tb_TenDoi.Text.ToString();

            string FindQuery = " SELECT * " +
                "FROM CAUTHU ,DOIBONG " +
               " Where CAUTHU.MaDoi= DOIBONG.MaDoi and CAUTHU.MaDoi = '" + id + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
            return data;
        }




        // xoa doi bong bang ma doi
        public void DeleteTeam()
        {
            System.Windows.Forms.UserControl usr = new usrHomepage();
            string id = usrHomepage.Instance.tb_MaDoi.Text;

            string CheckQuery = "SELECT * " +
             "FROM DOIBONG WHERE MaDoi = '" + id + "' ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(CheckQuery);
            if (dt.Rows.Count != 0)
            {
                var resultDialog = MessageBox.Show("Bạn có chắc muốn xóa đội bóng?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultDialog == DialogResult.OK)
                {
                    string DeleteQuery = "DELETE FROM DOIBONG WHERE MaDoi = '" + id + "'";
                    string DeletePlayer = "DELETE FROM CauThu WHERE MaDoi = '" + id + "'";
                    int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("Đội bóng đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }







        // cap nhap team
        public void UpdateTeam()
        {
            System.Windows.Forms.UserControl usr = new usrHomepage();
            string id = usrHomepage.Instance.tb_MaDoi.Text;
            string tendoi = usrHomepage.Instance.tb_TenDoi.Text;
            string slgct = usrHomepage.Instance.cb_Team_slgct.Text;
            string sannha = usrHomepage.Instance.tb_SanNha.Text;
            // MessageBox.Show(id);
            string UpdateQuery = "UPDATE DOIBONG " +
                 "SET TenDoi = '" + tendoi + "',SoCauThu = '" + slgct + "',SanNha = '" + sannha + "' " +
                 " WHERE MaDoi = '"+id+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
                if (result > 0)
                {
                    MessageBox.Show("Đội bóng đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }


        // cap nhat player

        public void UpdatePlayer()
        {
            System.Windows.Forms.UserControl usr = new usrTeamList();
            string id = usrTeamList.Instance.tb_hsdb_mact.Text;
            string tencauthu = usrTeamList.Instance.tb_hsdb_tenct.Text;
            string ngaysinh = usrTeamList.Instance.dtp_cauthu_ngsinh.Value.ToString();
            string loaiCT = usrTeamList.Instance.cb_hsdb_loaict.Text;
            string tgian = usrTeamList.Instance.tb_hsdb_tgiantd.Text;
            string thetrang = usrTeamList.Instance.tb_hsdb_thetrang.Text;
            // MessageBox.Show(id);


            string UpdateQuery = "UPDATE CAUTHU " +
                 "SET TenCauThu = '" + tencauthu + "', NgaySinh = '" +ngaysinh  + "', LoaiCauThu = '" + loaiCT + "', ThoiGianThiDau = '" + tgian + "',TinhTrang ='"+thetrang+"'"+
                 " WHERE MaCauThu = '" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Cầu thủ đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







        public void DeletePlayer()
        {
            System.Windows.Forms.UserControl usr = new usrTeamList();
            string id = usrTeamList.Instance.tb_hsdb_mact.Text;

           // string CheckQuery = "SELECT * " +
             //"FROM CAUTHU WHERE MaDoi = '" + id + "' ";

           // DataTable dt = DataProvider.Instance.ExecuteQuery(CheckQuery);

            if (usrTeamList.Instance.tb_hsdb_mact.Text != "")
            {
                var resultDialog = MessageBox.Show("Bạn có chắc muốn xóa cầu thủ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultDialog == DialogResult.OK)
                {
                    string DeleteQuery = "DELETE FROM CAUTHU WHERE MaCauThu = '" + id + "'";
                    int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("Cầu thủ đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }






    }
}

