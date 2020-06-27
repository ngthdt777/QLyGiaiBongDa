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


namespace QlyGiaiBongDa.BLL
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
            MessageBox.Show(vdau);
            DataTable dt = new DataTable();

            string LoadQuery = "select MaTranDau, DoiChuNha, DoiKhach,NgayThiDau,GioThiDau,SanThiDau,TenVongDau from VONGDAU,TRANDAU" +
            " where VONGDAU.TenVongDau = '"+vdau+ "' and TRANDAU.MaVongDau = VONGDAU.MaVongDau";
               

            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);

            return dt;
        }

        public DataTable AddMatch()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            DataTable dt = new DataTable();



            string id = ((frmMatch)f).tb_match_id.Text;
            string doichunha = ((frmMatch)f).tb_match_home.Text;
            string doikhach = ((frmMatch)f).tb_match_guest.Text;
            string ngaythidau = ((frmMatch)f).dtp_match.Value.ToString();
            string santhidau = ((frmMatch)f).tb_match_court.Text;
            string vongdau = ((frmMatch)f).cb_VongDau.Text;
            string Gio = ((frmMatch)f).tb_GioThiDau.Text;
        


            string AddQuery = "INSERT INTO TRANDAU(MaTranDau,DoiChuNha,DoiKhach,NgayThiDau,GioThiDau,SanThiDau,MaVongDau)" +
                        "VALUES('" + id + "', '" + doichunha + "', '" + doikhach + "', '" + ngaythidau + "'," 
                        + " CONVERT(TIME, '"+ Gio +"')"  + " ,'" + santhidau + "', '" +vongdau  + "')";

            int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
            if (result > 0)
            {
                MessageBox.Show("OKE da add ");
            }
            return dt;
        }
        public void delete()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            string id = ((frmMatch)f).tb_match_id.Text;
            string deletequery= "DELETE FROM TRANDAU WHERE MaTranDau = '" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(deletequery);
            if (result > 0)
            {
                MessageBox.Show("Trận đấu đã bị xoá,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }

        }

        public DataTable DeleteMatch()
        {
            DataTable dt = new DataTable();
            return dt;
        }



    }
}

