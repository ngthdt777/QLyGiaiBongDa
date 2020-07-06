using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using QlyGiaiBongDa.GUI;
using System.Data.SqlClient;

namespace QlyGiaiBongDa.BLL
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set => instance = value;
        }
        private DataProvider() { }
       // private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLGBDVDQG;Integrated Security=True"; -- MayDat

        private string connectionSTR = @"Data Source=DESKTOP-9OUV00A;Initial Catalog=QLGBDVDQG1;Integrated Security=True";


        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

   /*     public void ExecuteReader(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
            }
        }
*/





        public int ExecuteNonQuery(string query)
        {

            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();

                return data;
            }
        }

        public object ExecuteScalar(string query)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();

                return data;
            }
        }
        public bool LoginCheck()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmLogin"];
            string acc = ((frmLogin)f).txb_tk.Text;
            string pass = ((frmLogin)f).txb_pass.Text;
            string query = "SELECT * from DANGNHAP WHERE TaiKhoan = '" + acc + "' AND MatKhau = '" + pass + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                MessageBox.Show("Sai");
                return false;
            }

        }
    }
}
