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
            string vdau = usrCreateMatch.Instance.cb_VongDau.Text;
            DataTable dt = new DataTable();

            string LoadQuery = "select MaTranDau, DoiChuNha, DoiKhach,NgayThiDau,GioThiDau,SanThiDau,TySo,BANTHANGDN,BANTHANGKH from TRANDAU, VONGDAU"+
           " where TenVongDau= '"+vdau+"'  and   VongDau.MaVongDau = TranDau.MaVongDau  ";
               

            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }

        public DataTable AddMatch()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            DataTable dt = new DataTable();



            string id = ((frmMatch)f).tb_match_id.Text;
            string doichunha = ((frmMatch)f).cb_doinha.Text;
            string doikhach = ((frmMatch)f).cb_doikhach.Text;
            string ngaythidau = ((frmMatch)f).dtp_match.Value.ToString();
            string santhidau = ((frmMatch)f).tb_match_court.Text;
            string vongdau = ((frmMatch)f).cb_VongDau.Text;
            string Tiso = ((frmMatch)f).tb_match_tiso.Text;
            string BanThang = Tiso.Substring(0, 1) ;
            string BanThua = Tiso.Substring(1, 1);
            string Gio = ((frmMatch)f).tb_GioThiDau.Text;
        


            string AddQuery = "INSERT INTO TRANDAU(MaTranDau,DoiChuNha,DoiKhach,NgayThiDau,GioThiDau,SanThiDau,TySo,MaVongDau,BANTHANGDN,BANTHANGKH )" +
                        "VALUES('" + id + "', '" + doichunha + "', '" + doikhach + "', '" + ngaythidau + "'," 
                        + " CONVERT(TIME, '"+ Gio +"')"  + " ,'" + santhidau + "','" + Tiso + "', '" + vongdau  + "','" + BanThang + "','" + BanThua + "')";

            int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
            if (result > 0)
            {
                MessageBox.Show(" Đã thêm trận đấu mới ");
            }
            return dt;
        }


        public DataTable LoadRound()
        {
            DataTable dt = new DataTable();
            string LoadQuery = "SELECT TenVongDau from VONGDAU";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        }



        public void UpdateMatch()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];

            string id = frmMatch.Instance.tb_match_id.Text;
            string doinha = frmMatch.Instance.cb_doinha.Text;
            string doikhach = frmMatch.Instance.cb_doikhach.Text;
            string ngaytd = frmMatch.Instance.dtp_match.Text;
            string giotd = frmMatch.Instance.tb_GioThiDau.Text;
            string san = frmMatch.Instance.tb_match_court.Text;
            string tyso = frmMatch.Instance.tb_match_tiso.Text;

            MessageBox.Show(tyso);


            string UpdateQuery = "UPDATE TRANDAU " +
                 "SET DoiKhach = '" + doikhach + "',DoiChuNha = '" + doikhach + "' " +
                 " ,NgayThiDau = '" + ngaytd + "',GioThiDau = '" + giotd + "',SanThiDau='" + san + "',TySo='" + tyso +
                 "' Where MaTranDau='" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Đội bóng đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }


        public Boolean CheckID()
        {
            int matd_updating = Int32.Parse(frmMatch.Instance.tb_match_id.Text.Substring(2, 3));
            string vdau = frmMatch.Instance.cb_VongDau.Text;

            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaTranDau " +
                    "from  TRANDAU,VONGDAU " +
                    "where TRANDAU.MaVongDau = '" + vdau + "' and TRANDAU.MaVongDau = VONGDAU.MaVongDau ORDER BY MaTranDAu DESC", connection);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    int matd_having = Int32.Parse(da.GetValue(0).ToString().Substring(2, 3)) ;
                    if ( (matd_updating - 1) == matd_having )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Mã Trận Đấu mới nhất là: " + matd_having + ". Vui lòng điền lại Mã Trận Đấu","Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return false;
        }



        public DataTable DeleteMatch()
        {
            DataTable dt = new DataTable();


            string id = frmMatch.Instance.tb_match_id.Text;
            string doinha = frmMatch.Instance.cb_doinha.Text;
            string doikhach = frmMatch.Instance.cb_doikhach.Text;
            string ngaytd = frmMatch.Instance.dtp_match.Text;
            string giotd = frmMatch.Instance.tb_GioThiDau.Text;
            string san = frmMatch.Instance.tb_match_court.Text;
            string tyso = frmMatch.Instance.tb_match_tiso.Text;


            string deletequery = "DELETE FROM TRANDAU WHERE MaTranDau = '" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(deletequery);
            if (result > 0)
            {
                MessageBox.Show("Trận đấu đã bị xoá,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
            return dt;
        }

   /*     public void GetNextMatchID()
        {

                frmMatch.Instance.tb_match_id.Text = "";
                string vdau = frmMatch.Instance.cb_VongDau.Text;
                string matd;
                string Query ="Select TOP 1 MaTranDau from TRANDAU,VONGDAU where TenVongDau = '" +vdau +"' and TRANDAU.MaVongDau = VONGDAU.MaVongDau ORDER BY MaTranDau DESC";

                SqlDataReader da = DataProvider.Instance.ExecuteReader(Query);
                while (da.Read())
                {
                    matd = da.GetValue(0).ToString();
                    int nextid = Int32.Parse(matd.Substring(2, 3)) + 1;
                    frmMatch.Instance.tb_match_id.Text = matd.Substring(0, 3) + nextid.ToString();
                    frmMatch.Instance.tb_match_id.ReadOnly = true;
                    frmMatch.Instance.tb_match_id.TextAlign = HorizontalAlignment.Center;
                    frmMatch.Instance.tb_match_id.BaseColor = Color.DarkGray;
                    frmMatch.Instance.cb_doinha.Focus();
                    
                    
                }

                if (frmMatch.Instance.tb_match_id.Text == "")
                {

                    string Query_second = "Select MaVongDau from VONGDAU where TenVongDau = '" + vdau + "'";

                    da = DataProvider.Instance.ExecuteReader(Query_second);
                    while (da.Read())
                    {
                        matd = da.GetValue(0).ToString() + "001";
                        frmMatch.Instance.tb_match_id.Text = matd;
                        frmMatch.Instance.tb_match_id.ReadOnly = true;
                        frmMatch.Instance.tb_match_id.TextAlign = HorizontalAlignment.Center;
                        frmMatch.Instance.tb_match_id.BaseColor = Color.DarkGray;
                        frmMatch.Instance.cb_doinha.Focus();

                    }

                }



        }*/



    }
}

