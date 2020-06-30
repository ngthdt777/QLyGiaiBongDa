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
        int TranThang_CN, TranHoa_CN, TranThua_CN, Diem_CN, tyso, BanThang_CN, BanThang_Khach, HieuSo;
        int TranThang_Khach, TranHoa_Khach, TranThua_Khach, Diem_Khach;
        int WinPt = usrRulesChange.Instance.DiemSoThang;
        int EvePt = usrRulesChange.Instance.DiemSoHoa;
        int LosePt = usrRulesChange.Instance.DiemSoThua;



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

                for (int count_tran = 1; count_tran <7; count_tran++)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaTranDau, DoiChuNha,DoiKhach,TySo from TRANDAU where MaTranDau='VB00" + count_tran + "'", connection);

                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        usrStanding.Instance.tb_doichunha.Text = da.GetValue(1).ToString();
                        usrStanding.Instance.tb_doikhach.Text = da.GetValue(2).ToString();
                        usrStanding.Instance.tb_tyso.Text = da.GetValue(3).ToString();
                    }
                    CalPoint();

                    string UpdateQuery_CN = " UPDATE BANGXEPHANG,DOIBONG " +
                    "SET DiemSo = '" + Diem_CN + "' ,  TranThang = '" + TranThang_CN + "' , TranHoa ='" + TranHoa_CN + "' ,  TranThua ='" + TranThua_CN + "' " +
                    " where TenDoi = '" + usrStanding.Instance.tb_doichunha.Text+ "' AND BANGXEPHANG.MaDoi= DOIBONG.MaDoi ";

                    string UpdateQuery_Khach = " UPDATE BANGXEPHANG,DOIBONG " +
                    "SET DiemSo = '" + Diem_Khach + "' ,  TranThang = '" + TranThang_Khach + "' , TranHoa ='" + TranHoa_Khach + "' ,  TranThua ='" + TranThua_Khach + "' " +
                    " where TenDoi = '" + usrStanding.Instance.tb_doikhach.Text + "'AND BANGXEPHANG.MaDoi= DOIBONG.MaDoi ";


                    int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery_CN);
                    result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery_Khach);



                    connection.Close();
                }
                
            }


        }
        

        public void  CalPoint()

        {
            tyso = Int32.Parse(usrStanding.Instance.tb_tyso.Text);

            // Thong tin doi chu nha

             BanThang_CN = tyso / 10;
             BanThang_Khach = tyso % 10;
             HieuSo = BanThang_CN - BanThang_Khach;


           // So sanh

            if (BanThang_CN > BanThang_Khach)

            {
                    TranThang_CN += 1;
                    Diem_CN += 3;
                    TranThua_Khach += 1;

            }

            else if (BanThang_CN == BanThang_Khach)
            {
                    TranHoa_CN += 1; Diem_CN += 1;
                    TranHoa_Khach += 1; Diem_Khach += 1;
            }
            
            else
            {
                    TranThua_CN += 1;
                    Diem_Khach += 3;
                    TranThang_Khach += 1;
            }

        }





        public DataTable LoadListStanding()
        {
            string vdau = usrCreateMatch.Instance.cb_VongDau.Text;
            //  MessageBox.Show(vdau);
            DataTable dt = new DataTable();

            string LoadQuery = " SELECT * FROM BANGXEPHANG Where MaDoi = '7'";


            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }
    }

    

}


