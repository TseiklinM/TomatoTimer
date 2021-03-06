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
        public delegate void getMyList(DataTable Tab);
        public getMyList getListInter;
        bool flag;
        public Settings()
        {
            InitializeComponent();
            flag = false;
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
            
            tb_NamInter.Focus();
            if (dataGV_ListInterval.Rows.Count % 2 == 0) 
            {
                tb_NamInter.Text = "Большой интервал";
                numUD_TimInter.Maximum = 60;
                numUD_TimInter.Minimum = 15;
                numUD_TimInter.Value = 25;
            }
            else 
            {
                tb_NamInter.Text = "Малый интервал";
                numUD_TimInter.Maximum = 7;
                numUD_TimInter.Minimum = 3;
                numUD_TimInter.Value = 5;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            numUD_TimInter.Maximum = 7;
            numUD_TimInter.Minimum = 3;
            numUD_TimInter.Value = 5;
            tb_NamInter.Text = "Малый интервал";
            tb_NamInter.Focus();
        }

        private void btn_ClearGrid_Click(object sender, EventArgs e)
        {
            btn_ClearGrid.Enabled = false;
            btn_CrTim.Enabled = false;
            dataGV_ListInterval.Rows.Clear();
            Settings_Load(sender, e);

        }
        private void btn_CrTim_Click(object sender, EventArgs e)
        {
            var tab = new DataTable();
            for (int i = 0; i < dataGV_ListInterval.ColumnCount; i++)
            {
                tab.Columns.Add(new DataColumn("", Type.GetType("System.String")));
            }
            for(int i=0;i<dataGV_ListInterval.RowCount-1;i++) 
            {
                DataRow fu1 = tab.NewRow();
               
                fu1[0] = dataGV_ListInterval.Rows[i].Cells["NameInter"].Value.ToString();
                fu1[1] = dataGV_ListInterval.Rows[i].Cells["TimeNum"].Value.ToString();
                tab.Rows.Add(fu1);
            }
            getListInter?.Invoke(tab);
            flag = true;
            Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag) 
            {  
                MessageBox.Show("Таймер не создан!\n" +
                    "это приведет к закрытию программы \n" +
                    "или востоновлению ренее создонного таймера.", "Внимание!");
            }
        }
    }
}
