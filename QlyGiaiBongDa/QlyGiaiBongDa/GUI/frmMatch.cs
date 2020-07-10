﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QlyGiaiBongDa.BLL;


namespace QlyGiaiBongDa.GUI
{
    public partial class frmMatch : Form
    {
        private static frmMatch instance;

        public static frmMatch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmMatch();
                }
                return instance;
            }
            set { instance = value; }
        }
        public frmMatch()
        {
            InitializeComponent();
        }

        private void btt_team_add_Click(object sender, EventArgs e)
        {
            ObjRoundBLL.Instance.Add();
        }

        private void frmMatch_Load(object sender, EventArgs e)
        {
            cb_doinha.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_doinha.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_doinha.DisplayMember = "TenDoi";
            cb_doinha.ValueMember = "TenDoi";
            cb_doinha.DataSource = ObjPlayerBLL.Instance.GetNameTeam();

            cb_doikhach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_doikhach.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_doikhach.DisplayMember = "TenDoi";
            cb_doikhach.ValueMember = "TenDoi";
            cb_doikhach.DataSource = ObjPlayerBLL.Instance.GetNameTeam();
        }
    }
}
