using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyGiaiBongDa.BLL;
using QlyGiaiBongDa.DAL;
using QlyGiaiBongDa.GUI;



namespace QlyGiaiBongDa.GUI
{
    public partial class usrCreateMatch : UserControl
    {
        private static usrCreateMatch _instance;
        public static usrCreateMatch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrCreateMatch();
                return _instance;
            }
        }
        public usrCreateMatch()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            dgv_TLTD.DataSource = ObjRoundBLL.Instance.GetListRoundMatch();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vONGDAUTableAdapter.FillBy(this.qLGBDVDQGDataSet1.VONGDAU);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vONGDAUTableAdapter.FillBy(this.qLGBDVDQGDataSet1.VONGDAU);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_PhatSinh_Click(object sender, EventArgs e)
        {
            frmMatch.Instance.ShowDialog();

        }

        private void btt_team_era_Click(object sender, EventArgs e)
        {
            ObjRoundBLL.Instance.DeleteMatch();
            dgv_TLTD.DataSource = ObjRoundBLL.Instance.GetListRoundMatch();
        }
  //-------------------------------------------------------------------------------------------------------------------


        private void dgv_TLTD_CellStyleContentChanged(object sender, DataGridViewCellStyleContentChangedEventArgs e)
        {

        }

        private void btt_match_update_Click(object sender, EventArgs e)
        {
            ObjRoundBLL.Instance.GetListRoundMatch();
        }

 
        //-------------------------------------------------------------------------------------------------------------------




        private void dgv_TLTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int index = e.RowIndex;
          //  System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
             
                frmMatch.Instance.tb_match_id.Text = dgv_TLTD.Rows[e.RowIndex].Cells["MaTranDau"].Value.ToString();
                frmMatch.Instance.cb_doinha.Text = dgv_TLTD.Rows[e.RowIndex].Cells["DoiChuNha"].Value.ToString();
                frmMatch.Instance.cb_doikhach.Text = dgv_TLTD.Rows[e.RowIndex].Cells["DoiKhach"].Value.ToString();
                frmMatch.Instance.dtp_match.Text = dgv_TLTD.Rows[e.RowIndex].Cells["NgayThiDau"].Value.ToString();
                frmMatch.Instance.tb_GioThiDau.Text = dgv_TLTD.Rows[e.RowIndex].Cells["GioThiDau"].Value.ToString();
                frmMatch.Instance.tb_match_court.Text = dgv_TLTD.Rows[e.RowIndex].Cells["SanThiDau"].Value.ToString();
                frmMatch.Instance.tb_match_tiso.Text = dgv_TLTD.Rows[e.RowIndex].Cells["TySo"].Value.ToString();
                MessageBox.Show(frmMatch.Instance.tb_match_tiso.Text);
           
            }





        }



        private void dgv_TLTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                                  
            int index = e.RowIndex;
           // System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
               

                frmMatch.Instance.tb_match_id.Text = dgv_TLTD.Rows[e.RowIndex].Cells["MaTranDau"].Value.ToString();
                frmMatch.Instance.cb_doinha.Text = dgv_TLTD.Rows[e.RowIndex].Cells["DoiChuNha"].Value.ToString();
                frmMatch.Instance.cb_doikhach.Text = dgv_TLTD.Rows[e.RowIndex].Cells["DoiKhach"].Value.ToString();
                frmMatch.Instance.dtp_match.Text = dgv_TLTD.Rows[e.RowIndex].Cells["NgayThiDau"].Value.ToString();
                frmMatch.Instance.tb_GioThiDau.Text = dgv_TLTD.Rows[e.RowIndex].Cells["GioThiDau"].Value.ToString();
                frmMatch.Instance.tb_match_court.Text = dgv_TLTD.Rows[e.RowIndex].Cells["SanThiDau"].Value.ToString();
                frmMatch.Instance.tb_match_tiso.Text = dgv_TLTD.Rows[e.RowIndex].Cells["TySo"].Value.ToString();
              
              
            }



        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chọn phát sinh trận đấu để tạo trận đấu mới");
        }

        private void usrCreateMatch_Load(object sender, EventArgs e)
        {
            cb_VongDau.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_VongDau.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_VongDau.DisplayMember = "TenVongDau";
            cb_VongDau.ValueMember = "TenVongDau";
            cb_VongDau.DataSource = ObjRoundBLL.Instance.GetRound();
            cb_VongDau.Text = " Chọn vòng đấu ";
            
        }
    }
}
