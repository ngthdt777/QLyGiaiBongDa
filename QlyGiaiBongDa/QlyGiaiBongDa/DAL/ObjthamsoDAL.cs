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
using QlyGiaiBongDa.DAL;

namespace QlyGiaiBongDa.DAL
{
    public class thamso
    {
        public int ma { get; set; }
        public int tuoi_min { get; set; }
        public int tuoi_max { get; set; }
        public int slgct_max { get; set; } //so luong cau thu toi da
        public int slgct_min { get; set; } //so luong cau thu toi thieu
        public int slgctnn_max { get; set; }//so cau thu nuoc ngoai toi da
        public int tdgb_max { get; set; } //thoi diem ghi ban toi da
        public int diem_thang { get; set; }
        public int diem_hoa { get; set; }
        public int ttutxh { get; set; }//thu tu uu tien xep hang
        public int slglbt { get; set; }
        public thamso() { }
    }
    public class ObjthamsoDAL
    {
        private static ObjthamsoDAL instance;

        public static ObjthamsoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjthamsoDAL();
                }
                return instance;
            }
            set { instance = value; }
        }
        public ObjthamsoDAL() { }

        public int myage = DateTime.Today.Year - usrTeamList.Instance.dtp_cauthu_ngsinh.Value.Year;

        public Boolean CheckTuoiMin()
        {
            int tuoimin = usrRulesChange.Instance.TuoiMin;
            if (myage > tuoimin)
                return true;
            else
            {
                MessageBox.Show("Độ tuổi tối thiểu là: " + tuoimin);
                return false;
            }

        }


        public Boolean CheckTuoiMax()
        {
            int tuoimax = usrRulesChange.Instance.TuoiMax;
            if (myage < tuoimax)
                return true;
            else
            {
                MessageBox.Show("Độ tuổi tối đa là: " + tuoimax);
                return false;
            }
        }


        public int soluongct = Int32.Parse(usrHomepage.Instance.cb_Team_slgct.Text.ToString());

        public Boolean CheckSoLgMin()
        {
            int soluongmin = usrRulesChange.Instance.SoLgMin;
            if (soluongct > soluongmin)
                return true;
            else
            {
                MessageBox.Show("số lượng cầu thủ tối thiểu là: " + soluongmin);
                return false;
            }
        }


        public Boolean CheckSoLgMax()
        {
            int soluongmax = usrRulesChange.Instance.SoLgMax;
            if (soluongct < soluongmax)
                return true;
            else
            {
                MessageBox.Show("số lượng cầu thủ tối đa là: " + soluongmax);
                return false;
            }
        }




        public Boolean CheckDiemSoThang()
        {
            return true;
        }


        public Boolean CheckDiemSoThua()
        {
            return true;
        }

        public Boolean CheckDiemSoHoa()
        {
            return true;
        }

        public Boolean CheckMaxTimeScore()
        {
            return true;
                MessageBox.Show("Thời điểm ghi bàn tối đa là: " + usrRulesChange.Instance.MaxTimeScore);
        }



        public Boolean CheckNoForeignPlayer()
        {


            int slg = Int32.Parse(usrTeamList.Instance.lb_hsdb_sctnq.Text);
            if (slg < usrRulesChange.Instance.ForeignMax)
                return true;
            else
            {
                MessageBox.Show("Số lượng cầu thủ ngoại quốc vượt quá quy định");
                return false;
            }
        }

        public DataTable LoadGoalType()
        {
            DataTable dt = new DataTable();

            string LoadQuery = "SELECT LOAIBANTHANG from LOAIBANTHANG "; // Bảng thêm chỉ dùng cho chức năng Thêm Loại bàn thắng
                           
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }
        public void AddGoalType()

        {
            string TenLoaiBan = usrRulesChange.Instance.tb_LoaiBan.Text;



            string AddQuery = "INSERT INTO LOAIBANTHANG(LOAIBANTHANG)" +
                "VALUES('" + TenLoaiBan + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);

            if (result > 0)
            {
                MessageBox.Show(" Đã thêm loại bàn thắng ");
            }

        }
        public void DeleteGoalType()
        {
            System.Windows.Forms.UserControl usr = new usrTeamList();

            string TenLoaiBan = usrRulesChange.Instance.tb_LoaiBan.Text;



            if (usrRulesChange.Instance.tb_LoaiBan.Text != "")
            {
                MessageBox.Show("Bạn có chắc sẽ xóa");

                string DeleteQuery = "DELETE FROM LOAIBANTHANG WHERE LOAIBANTHANG= '" + TenLoaiBan + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show(" Loại bàn thắng đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }






    }
}
