﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTimer
{
    public partial class Settings : Form
    {
        public delegate void getMyList(DataTable Tab);
        public getMyList getListInter;
        public Settings()
        {
            InitializeComponent();
            
            
        }

        private void tb_NamInter_TextChanged(object sender, EventArgs e)
        {
            if (tb_NamInter.Text.Length > 0) {btn_Add.Enabled = true;}
            else { btn_Add.Enabled = false; }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dataGV_ListInterval.Rows.Count > 1) { btn_CrTim.Enabled = true; }
            else btn_CrTim.Enabled = false;
            if (!btn_ClearGrid.Enabled) { btn_ClearGrid.Enabled = true; }
            dataGV_ListInterval.Rows.Add(tb_NamInter.Text,(int)numUD_TimInter.Value);
            tb_NamInter.Text = "";
            tb_NamInter.Focus();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btn_ClearGrid_Click(object sender, EventArgs e)
        {
            btn_ClearGrid.Enabled = false;
            btn_CrTim.Enabled = false;
            dataGV_ListInterval.Rows.Clear();
            
        }

        private void btn_CrTim_Click(object sender, EventArgs e)
        {
            var tab = new DataTable();
            for (int i = 0; i < dataGV_ListInterval.ColumnCount; i++)
            {
                tab.Columns.Add(new DataColumn("", Type.GetType("System.String")));
            }
            foreach(DataGridViewRow Row in dataGV_ListInterval.Rows) 
            {
                DataRow fu1 = tab.NewRow();
                for(int i = 0; i < dataGV_ListInterval.ColumnCount; i++) 
                {
                    fu1[i] = Row.Cells[i].Value.ToString();
                }
                tab.Rows.Add(fu1);
            }
            getListInter?.Invoke(tab);
            Close();
        }
    }
}
