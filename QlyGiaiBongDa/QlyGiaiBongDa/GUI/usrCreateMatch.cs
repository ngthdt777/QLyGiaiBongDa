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
            frmMatch f = new frmMatch();
            f.ShowDialog();
        }

        private void btt_team_era_Click(object sender, EventArgs e)
        {
            ObjRoundBLL.Instance.Delete();
        }

        private void dgv_TLTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
              
                ((frmMatch)f).tb_match_id.Text = dgv_TLTD.Rows[e.RowIndex].Cells["MaTranDau"].Value.ToString();

            }
        }

        private void dgv_TLTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmMatch"];
            if (index >= 0)
            {
                ((frmMatch)f).tb_match_id.Text = dgv_TLTD.Rows[e.RowIndex].Cells["MaTranDau"].Value.ToString();
            }
        }
    }
}
