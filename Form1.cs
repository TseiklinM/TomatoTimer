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
    public partial class Form1 : Form
    {
        TomTimer MyTimer;
        public Form1()
        {
            InitializeComponent();
            MyTimer = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MyTimer == null)
            {
                Settings Fu1 = new Settings();
                Fu1.getListInter = setInervalList;
                Fu1.ShowDialog();
                Form1_Load(sender,e);
            }
        }
        void setInervalList(List<Interval> Tl) 
        { 
            MyTimer = new TomTimer(Tl); 
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            tb_TimeRound.Text = MyTimer.GetActivInterval().time + ":00";
            tBRound.Text = MyTimer.GetActivInterval().Name;
            MyTimer.numUp();
        }

        private void btn_NewTim_Click(object sender, EventArgs e)
        {
            MyTimer = null;
            Form1_Load(sender, e);
        }
    }
}
