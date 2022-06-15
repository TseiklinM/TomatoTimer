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
        //MyTimer timer;
        TomTimer MyTimer;
        int minute;
        int second;
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
            else 
            {
                //timer = new MyTimer();
                //timer.GetYourTime += MyTimer.ShowRealTimInter;
                MyTimer.getMyNum += Fu1;
                //timer.TimeNow += ShowYuerTime;
                MyTimer.getMyName += ShowYuerName;
                MyTimer.getMyTime += ShowYuerTime;
            }
        }
        void Fu1(object num) 
        {
            minute = (int)num - 1;
            second = 60;
            if (MyTimer.numActivInt != 0) { timer1.Enabled = true; }
        }
        void ShowYuerName(object str) { tBRound.Text = str.ToString(); }
        void ShowYuerTime(object str) { tb_TimeRound.Text = str.ToString(); }
        void setInervalList(List<Interval> Tl) 
        { 
            MyTimer = new TomTimer(Tl); 
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            //tb_TimeRound.Text = MyTimer.GetActivInterval().time + ":00";
            //tBRound.Text = MyTimer.GetActivInterval().Name;
            //MyTimer.numUp();
            MyTimer.StartTomTimer();
            timer1.Enabled = true;
        }

        private void btn_NewTim_Click(object sender, EventArgs e)
        {
            MyTimer = null;
            Form1_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                if (minute > 0)
                {
                    minute--;
                    second = 60;
                }
                else if (minute == 0)
                {
                    timer1.Enabled=false;
                }

            }
            MyTimer.ShowRealTimInter(minute, second);
        }
    }
}
