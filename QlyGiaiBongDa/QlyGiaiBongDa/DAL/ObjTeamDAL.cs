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

    //    public DoiBong Team = new DoiBong();
      System.Windows.Forms.UserControl u = new usrTeam();
        public DataTable LoadListTeam()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT * FROM DOIBONG";
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


        public DataTable LoadListPlayer()
        {
            string TenDoi = usrTeam.Instance.cbb_team_name.Text;
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT MaCauThu,TenCauThu,NgaySinh,MaLoaiCauThu,GhiChu,CAUTHU.MaDoi FROM CAUTHU,DOIBONG " +
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
  // khởi tạo giá trị text box
            string id = usrTeam.Instance.tb_hsdb_mact.Text;
            string tenct = usrTeam.Instance.tb_hsdb_tenct.Text;
            string ngsinh = usrTeam.Instance.dtp_cauthu_ngsinh.Text;
            string loaict = usrTeam.Instance.tb_hsdb_loaict.Text.ToString();        
            string madoi = usrTeam.Instance.tb_MaDoi.Text;
            string ghichu = usrTeam.Instance.tb_hsdb_ghichu.Text;

                if (CheckMaDoi(id) == true)
                if (ObjRulesChangeBLL.Instance.CheckTuoiMax == true() && (ObjRulesChangeBLL.Instance.CheckTuoiMin() == true))
                {
                    string AddQuery = "INSERT INTO CAUTHU(MaCauThu,TenCauThu,NgaySinh,MaLoaiCauThu,GhiChu,MaDoi)"+
                        "VALUES('" + id + "', '" + tenct + "', '" +ngsinh + "', '" + loaict + "', '" + ghichu + "', '" + madoi +"')";
                int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("OKE đã thêm ");
                    }
                }
                else MessageBox.Show("Cầu thủ tồn tại");

        }






        public void AddTeam()
        {
            string id = usrHomepage.Instance.tb_MaDoi.Text;
            string tendoi = usrHomepage.Instance.tb_TenDoi.Text;
            string slgct = usrHomepage.Instance.tb_SCT.Text;
            string sannha = usrHomepage.Instance.tb_SanNha.Text;


            if (CheckMaDoi(id) == true)
            {
                string AddQuery = "INSERT INTO DOIBONG(MaDoi,TenDoi,SanNha,SoCauThu)" +
                        "VALUES('" + id + "', '" + tendoi + "', '" + sannha + "', '" + slgct + "')";
                int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                if (result > 0)
                {
                    MessageBox.Show("OKE da add ");
                }
            }
            else MessageBox.Show("Doi bong da ton tai");
        }






        public DataTable PlayerView()
        {
            string id = usrTeam.Instance.tb_MaDoi.Text.ToString();
        //    string tendoi = usrTeam.Instance.tb_TenDoi.Text.ToString();

            string FindQuery = " SELECT MaCauThu,TenCauThu,NgaySinh,TenLoaiCauThu,GhiChu " +
                "FROM CAUTHU , DOIBONG,LOAICAUTHU " +
               " Where LOAICAUTHU.MaLoaiCauThu=CAUTHU.MaLoaiCauThu and CAUTHU.MaDoi= DOIBONG.MaDoi and CAUTHU.MaDoi = '" + id + "' ";
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
                MessageBox.Show(id);
                string DeleteQuery = "DELETE FROM DOIBONG WHERE MaDoi = '" + id + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show("Đội bóng đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }







        // cap nhap team
        public void UpdateTeam()
        {
            System.Windows.Forms.UserControl usr = new usrHomepage();
            string id = usrHomepage.Instance.tb_MaDoi.Text;
            string tendoi = usrHomepage.Instance.tb_TenDoi.Text;
            string slgct = usrHomepage.Instance.tb_SCT.Text;
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
            System.Windows.Forms.UserControl usr = new usrTeam();
            string id = usrTeam.Instance.tb_hsdb_mact.Text;
            string tencauthu = usrTeam.Instance.tb_hsdb_tenct.Text;
            string ngaysinh = usrTeam.Instance.dtp_cauthu_ngsinh.Text;
            string loaiCT = usrTeam.Instance.tb_hsdb_loaict.Text;
            string GhiChu = usrTeam.Instance.tb_hsdb_ghichu.Text;
            // MessageBox.Show(id);


            string UpdateQuery = "UPDATE CAUTHU " +
                 "SET TenCauThu = '" + tencauthu + "', NgaySinh = '" +ngaysinh  + "', MaLoaiCauThu = '" + loaiCT + "', GhiChu = '" + GhiChu + "' " +
                 " WHERE MaCauThu = '" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Cầu thủ đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







        public void DeletePlayer()
        {
            System.Windows.Forms.UserControl usr = new usrTeam();
            string id = usrTeam.Instance.tb_hsdb_mact.Text;

           // string CheckQuery = "SELECT * " +
             //"FROM CAUTHU WHERE MaDoi = '" + id + "' ";

           // DataTable dt = DataProvider.Instance.ExecuteQuery(CheckQuery);

            if (usrTeam.Instance.tb_hsdb_mact.Text != "")
            {
                MessageBox.Show("ok chua");

                string DeleteQuery = "DELETE FROM CAUTHU WHERE MaCauThu = '" + id + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show("Cầu thủ đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }






        public void Bindings()
        {
          //  System.Windows.Forms.UserControl u = new usrTeam();

            usrTeam.Instance.tb_MaDoi.DataBindings.Clear();
      //      usrTeam.Instance.tb_TenDoi.DataBindings.Clear();
            usrTeam.Instance.tb_MaDoi.DataBindings.Add(new Binding("Text", usrTeam.Instance.dgv_HSDB.DataSource, "MaDoi"));
        //    usrTeam.Instance.tb_TenDoi.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "TenDoi"));

            // Ban thay doi cua Duy Bao
            usrTeam.Instance.DataBindings.Clear();
        }
    }
}

