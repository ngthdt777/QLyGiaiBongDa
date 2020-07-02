using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using QlyGiaiBongDa.GUI;
using QlyGiaiBongDa.BLL;




namespace QlyGiaiBongDa.DAL
{
    class BANTHANG
    {
        public string mab { get; set; }
        public string ma_ct { get; set; }
        public string ma_lbt { get; set; }
        public string thoidiem { get; set; }
        public string id_td { get; set; }
        public BANTHANG() { }
    }

    public class ObjGoalDetailDAL
    {
        private static ObjGoalDetailDAL instance;

        public static ObjGoalDetailDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjGoalDetailDAL();
                }
                return instance;
            }
            set { instance = value; }
        }


        private ObjGoalDetailDAL() { }




        public DataTable LoadListGoal()
        {
            DataTable dt = new DataTable();


            string LoadQuery = "Select * from BANTHANG";

            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;

        }


        // Hàm thêm bàn thắng
        public void AddGoal()

        {
            string MaBan = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string MaCauThu = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string LoaiBan = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string ThoiDiem = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string MaTran = usrGoalDetail.Instance.tb_MaBanThang.Text;


            string AddQuery = "INSERT INTO BANTHANG" +
                "VALUES('" + MaBan + "', '" + MaCauThu + "', '" + LoaiBan + "', '" + ThoiDiem + "', '" + MaTran + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
            if (result > 0)
            {
                MessageBox.Show(" Đã thêm bàn thắng ");
            }



        }


        public void UpdateGoal()
        {
            System.Windows.Forms.UserControl usr = new usrGoalDetail();
            string MaBan = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string MaCauThu = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string LoaiBan = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string ThoiDiem = usrGoalDetail.Instance.tb_MaBanThang.Text;
            string MaTran = usrGoalDetail.Instance.tb_MaBanThang.Text;
            // MessageBox.Show(id);


            string UpdateQuery = "UPDATE BANTHANG " +
                 "SET MaBanThang = '" + MaBan + "', MaCauThu = '" + MaCauThu + "', MaLoaiBanThang = '" + LoaiBan + "', ThoiDiem = '" + ThoiDiem + "',MaTran = '" + MaTran + "' ";

            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Bàn thắng đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DeleteGoal()
        {
            System.Windows.Forms.UserControl usr = new usrTeamList();

            string MaBan = usrGoalDetail.Instance.tb_MaBanThang.Text;



            if (usrGoalDetail.Instance.tb_MaBanThang.Text != "")
            {
                MessageBox.Show("Ok chưa");

                string DeleteQuery = "DELETE FROM BANTHANG WHERE MaBanThang= '" + MaBan + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show("Bàn thắng đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}

