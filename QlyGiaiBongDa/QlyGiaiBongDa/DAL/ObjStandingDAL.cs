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
        public ObjStandingDAL() { }
        public string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLGBDVDQG;Integrated Security=True";

        
        public void LoadInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                
                for (int count_tran = 1; count_tran < 100; count_tran++)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaTranDau, DoiChuNha,DoiKhach,TySo from TRANDAU where MaTranDau='VB00"+count_tran+"'", connection);

                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        usrStanding.Instance.tb_doichunha.Text = da.GetValue(1).ToString();
                        usrStanding.Instance.tb_doikhach.Text = da.GetValue(2).ToString();
                        usrStanding.Instance.tb_tyso.Text = da.GetValue(3).ToString();
                    }

                    int tyso = Int32.Parse(usrStanding.Instance.tb_tyso.Text);
                    int x = tyso / 10;
                    int y = tyso % 10;
                    MessageBox.Show(x.ToString());
                    connection.Close();
                }
                
            }
        }


        public void CalPoint()

        {
            int tyso = Int32.Parse(usrStanding.Instance.tb_tyso.Text);

            // Thong tin doi chu nha

            int BanThang_CN = tyso / 10;
            int BanThang_Khach = tyso % 10;

            int HieuSo = BanThang_CN - BanThang_Khach;


            int TranThang = 0;
            int TranHoa = 0;
            int TranThua = 0;
            int Diem = 0;


            // So sacnh

            if (BanThang_CN > BanThang_Khach)

            {

                TranThang = TranThang + 1;
                TranHoa = TranHoa + 0;
                TranThua = TranThua + 0;

                Diem = Diem + 3;

                DataTable dt = new DataTable();

                string LoadQuery = "UPDATE BANGXEPHANG" +
                    "SET DiemSo ='"+Diem+ "' ,  TranThang ='" + TranThang + "' , TranHoa ='" + TranHoa + "' ,  TranThua ='" + TranThua + "' , TranThua ='" + TranThua + "',     " +

            " where MaDoi = '7' ";

            }


        }




        public DataTable LoadListStanding()
        {
            string vdau = usrCreateMatch.Instance.cb_VongDau.Text;
            MessageBox.Show(vdau);
            DataTable dt = new DataTable();

            string LoadQuery = "select MaTranDau, DoiChuNha, DoiKhach,NgayThiDau,GioThiDau,SanThiDau,TySo from VONGDAU,TRANDAU" +
            " where VONGDAU.TenVongDau = '" + vdau + "' and TRANDAU.MaVongDau = VONGDAU.MaVongDau";


            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }


    }

}


