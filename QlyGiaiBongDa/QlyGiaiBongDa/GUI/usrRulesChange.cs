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
using System.Data.SqlClient;
using QlyGiaiBongDa.GUI;


namespace QlyGiaiBongDa.GUI
{
    public partial class usrRulesChange : UserControl
    {
        



        private static usrRulesChange _instance;
        public static usrRulesChange Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usrRulesChange();
                return _instance;
            }
        }
        public usrRulesChange()
        {
            InitializeComponent();
        }

        public int TuoiMin = 16;
        public int TuoiMax = 40;
        public int SoLgMin = 5;
        public int SoLgMax = 22;
        public int ForeignMax = 5;
        public int DiemSoThang = 3;
        public int DiemSoHoa = 1;
        public int DiemSoThua = 0;
        public int MaxTimeScore = 90;
        private void btt_RC_Default_Click(object sender, EventArgs e)
        {
            nm_tuoimin.Value = 16;
            nm_tuoimax.Value = 40;
            nm_slgmin.Value = 5;
            nm_slgmax.Value = 22;
            nm_formax.Value = 5;
        }

        private void btt_RC_Default_2_Click(object sender, EventArgs e)
        {
            nm_diemthang.Value = 3;
            nm_diemhoa.Value = 1;
            nm_diemthua.Value = 0;
            nm_maxtimescore.Value = 90;
        }


        private void btt_RC_Done_1_Click(object sender, EventArgs e)
        {
            TuoiMin = Int32.Parse(nm_tuoimin.ToString());
            TuoiMax = Int32.Parse(nm_tuoimax.ToString());
            SoLgMin = Int32.Parse(nm_slgmin.ToString());
            SoLgMax = Int32.Parse(nm_slgmax.ToString());
            ForeignMax = Int32.Parse(nm_formax.ToString());
        }

        private void btt_RC_Done_2_Click(object sender, EventArgs e)
        {
            DiemSoThang = Int32.Parse(nm_diemthang.ToString());
            DiemSoHoa = Int32.Parse(nm_diemhoa.ToString());
            DiemSoThua = Int32.Parse(nm_diemthua.ToString());
            MaxTimeScore = Int32.Parse(nm_maxtimescore.ToString());
        }

     
        private void usrRulesChange_Load_1(object sender, EventArgs e)
        {
            dgv_LoaiBanThang.DataSource = ObjRulesChangeBLL.Instance.GetGoalType();
        }

        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            ObjRulesChangeBLL.Instance.AddGoalType();
        }

        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            ObjRulesChangeBLL.Instance.DeleteGoalType();
        }

        private void dgv_LoaiBanThang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tb_LoaiBan.Text = dgv_LoaiBanThang.Rows[e.RowIndex].Cells["LoaiBanThang"].Value.ToString();
            }
        }

        private void lb_Guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tùy chỉnh các thuộc tính về cầu thủ, loại bàn thắng theo mong muốn" +
                            " Chọn hoàn tất để thực hiện thay đổi, chọn mặc định để quay lại trạng thái ban đầu");

        }
    }
}
