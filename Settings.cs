using System;
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
        DataTable Mytab;
        public Settings()
        {
            InitializeComponent();
            
            Mytab = new DataTable();
            Mytab.Columns.Add(new DataColumn("Название", Type.GetType("System.String")));
            Mytab.Columns.Add(new DataColumn("Время", Type.GetType("System.String")));
            
        }

        private void tb_NamInter_TextChanged(object sender, EventArgs e)
        {
            if (tb_NamInter.Text.Length > 0) {btn_Add.Enabled = true;}
            else { btn_Add.Enabled = false; }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGV_ListInterval.Rows.Add(tb_NamInter.Text,(int)numUD_TimInter.Value);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tb_NamInter.Text = "";
            tb_NamInter.Focus();
            //dataGV_ListInterval = new DataGridView();
            //dataGV_ListInterval.DataSource =new DataSet();
        }
    }
}
