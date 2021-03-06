using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTimer
{
    //задание для форм
    //1-превести обе формы к единому стилю оформления
    //2-кнопки должны выделяться на основном фоне
    //3-создать метод для звуковоко оповещения
    //4-основная форма должна сворачиваться
    public partial class Form1 : Form
    {
        ICustomTT customTT;
        TomTimerBase MyTimer;
        int minute;
        int second;
        public Form1()
        {
            InitializeComponent();
            MyTimer = null;
            customTT = new CustomTT();
        }
        //загрузка формы с выбором формы
        private void Form1_Load(object sender, EventArgs e)
        {
            //старт формы настройки
            if (MyTimer == null)
            {
                Settings SettForm = new Settings();
                SettForm.getListInter = customTT.createListTimer;
                SettForm.ShowDialog();
                MyTimer = customTT.GetYeorTimer();
                if (MyTimer != null)
                {
                    Form1_Load(sender, e); 
                }
                else Close();
            }
            //основная форма
            else 
            {
                //обнуление полей формы подкл делегатов
                minute = second = 0;
                tBRound.Text = "not data";
                tb_TimeRound.Text = "00:00";
                MyTimer.getMyNum += setTime;
                MyTimer.getMyName += ShowYuerName;
                MyTimer.getMyTime += ShowYuerTime;
                MyTimer.getMyMess += ShowMessTimer;
                btn_RestartTimer.Enabled = btn_RestartInter.Enabled = false;
            }
        }
        //получение времени
        void setTime(object num) 
        {
            minute = (int)num;
            if (minute > 0)
            {
                --minute;
                second = 60;
                if (!timer1.Enabled) { timer1.Enabled = true; }
            }
            else 
            {
                if (timer1.Enabled) { timer1.Enabled = false; }
                btn_NewTim.Enabled = true;
                bStart.Text = "Старт";
                minute = second = 0;
            }
        }
        //вывод данных на форму
        void ShowMessTimer(object str) 
        {
            this.Show();
            if (!checkBox1.Checked)
            {
                SoundPlayer sound = new SoundPlayer("barab.wav");
                sound.Play();
            }
            MessageBox.Show((string)str);
        }
        void ShowYuerName(object str) { tBRound.Text = str.ToString(); }
        void ShowYuerTime(object str) { tb_TimeRound.Text = str.ToString(); }
        //старт пауза
        private void bStart_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
            {
                bStart.Text = "Pause";
                if (MyTimer.numActivInt == 0 && minute == 0 && second == 0) 
                {
                    MyTimer.StartTomTimer(); 
                }
                timer1.Enabled = true;
                if (btn_NewTim.Enabled) 
                {
                    btn_RestartTimer.Enabled = btn_RestartInter.Enabled = btn_NewTim.Enabled = false;
                }
            }
            else 
            {
                timer1.Enabled = false;
                bStart.Text = "Start";
                btn_RestartTimer.Enabled= btn_RestartInter.Enabled = btn_NewTim.Enabled = true;
            }
        }
        //запуск нового таймера
        private void btn_NewTim_Click(object sender, EventArgs e)
        {
            MyTimer = null;
            Form1_Load(sender, e);
        }
        //условие события тик
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

       
        //рестарт таймер
        private void btn_RestartTimer_Click(object sender, EventArgs e)
        {
            minute = second = 0;
            MyTimer.StartTomTimer();
            bStart.Text = "Pause";
            if (btn_NewTim.Enabled)
            {
                btn_RestartTimer.Enabled = btn_RestartInter.Enabled = btn_NewTim.Enabled = false;
            }
        }
        //рестарт интервал
        private void btn_RestartInter_Click(object sender, EventArgs e)
        {
            MyTimer.RestartInterval();
            bStart.Text = "Pause";
            if (btn_NewTim.Enabled)
            {
                btn_RestartTimer.Enabled = btn_RestartInter.Enabled = btn_NewTim.Enabled = false;
            }
        }

       
    }
}
