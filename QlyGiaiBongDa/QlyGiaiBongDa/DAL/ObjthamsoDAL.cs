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
        
        public int myage = DateTime.Today.Year - usrTeam.Instance.dtp_cauthu_ngsinh.Value.Year;

        public Boolean CheckTuoiMin()
        {
            int tuoimin = usrRulesChange.Instance.TuoiMin;
            if (myage < tuoimin)
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
            if (myage > tuoimax)
                return true;
            else
            {
                MessageBox.Show("Độ tuổi tối thiểu là: " + tuoimax);
                return false;
            }
        }


        public Boolean CheckSoLgMin()
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


        public Boolean CheckSoLgMax()
        {
            return true;
            MessageBox.Show("Số lượng cầu thủ tối thiểu là: " + usrRulesChange.Instance.SoLgMax);
        }


        public Boolean CheckForMax()
        {
            return true;
            MessageBox.Show("Số lượng cầu thủ ngoại quốc tối đa là: " + usrRulesChange.Instance.ForeignMax);
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



    }







}
