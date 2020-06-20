﻿using System;
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
            string LoadQuery = "SELECT * FROM DoiBong";
            dt = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return dt;
        } 

        bool CheckMaDoi(string id)
        {
            /*string query = "SELECT MaDoi FROM DOIBONG WHERE MaDoi = '" + id + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;*/
            return true;
        }
       public void AddPlayer()
        {
          /*  // khởi tạo giá trị text box
            string id = usrTeam.Instance.tb_hsdb_mact.Text;
            string tenct = usrTeam.Instance.tb_hsdb_tenct.Text;
            string ngsinh = usrTeam.Instance.tb_hsdb_ngsinh.Text;
            string loaict = usrTeam.Instance.tb_hsdb_loaict.Text;

                if (CheckMaDoi(id) == true)
                {
                    string AddQuery = "INSERT INTO DOIBONG(MaDoi,TenDoi,SanNha,SoCauThu" +
                        "VALUES('" + id + "', '" + Team.ten + "', '" + Team.ten_sannha + "', '" + Team.slgct + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("OKE da add ");
                    }
                }
                else MessageBox.Show("Ton tai");

    */
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
            else MessageBox.Show("Doi bong da ton toi");
        }






        public DataTable PlayerView()
        {
            string id = usrTeam.Instance.tb_MaDoi.Text.ToString();
            string tendoi = usrTeam.Instance.tb_TenDoi.Text.ToString();

            string FindQuery = " SELECT MaCauThu,TenCauThu,NgaySinh,TenLoaiCauThu,TenDoi " +
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
        public void DeletePlayer()
        {
              string id = usrHomepage.Instance.tb_MaDoi.Text;

          
           
            if (usrHomepage.Instance.tb_MaDoi.Text != "")
            {
                string DeleteQuery = "DELETE FROM DOIBONG WHERE MaDoi = '" + id + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show("Đội bóng đã bị xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public void Bindings()
        {
          //  System.Windows.Forms.UserControl u = new usrTeam();

            usrTeam.Instance.tb_MaDoi.DataBindings.Clear();
            usrTeam.Instance.tb_TenDoi.DataBindings.Clear();
            usrTeam.Instance.tb_MaDoi.DataBindings.Add(new Binding("Text", usrTeam.Instance.dgv_HSDB.DataSource, "MaDoi"));
            usrTeam.Instance.tb_TenDoi.DataBindings.Add(new Binding("Text", ((usrTeam)u).dgv_HSDB.DataSource, "TenDoi"));

            // Ban thay doi cua Duy Bao
            usrTeam.Instance.DataBindings.Clear();
        }
    }
}

