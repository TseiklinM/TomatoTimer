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
    //задание для форм
    //1-превести обе формы к единому стилю оформления
    //2-кнопки должны выделяться на основном фоне
    //3-создать метод для звуковоко оповещения
    //4-основная форма должна сворачиваться
    public partial class Form1 : Form
    {
        TomTimer MyTimer;
        int minute;
        int second;
        public Form1()
        {
            InitializeComponent();
            MyTimer = null;
        }
        //загрузка формы с выбором формы
        private void Form1_Load(object sender, EventArgs e)
        {
            //старт формы настройки
            if (MyTimer == null)
            {
                Settings SettForm = new Settings();
                SettForm.getListInter = setInervalList;
                SettForm.ShowDialog();
                Form1_Load(sender,e);
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
            }
        }
        //получение времени
        void setTime(object num) 
        {
            minute = (int)num - 1;
            second = 60;
            if (MyTimer.numActivInt != 0) { timer1.Enabled = true; }
        }
        //вывод данных на форму
        void ShowYuerName(object str) { tBRound.Text = str.ToString(); }
        void ShowYuerTime(object str) { tb_TimeRound.Text = str.ToString(); }
        //метод будет удоллен
        void setInervalList(List<Interval> Tl) 
        { 
            MyTimer = new TomTimer(Tl); 
        }
        //старт пауза
        private void bStart_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
            {
                bStart.Text = "Пауза";
                if (MyTimer.numActivInt == 0 && minute == 0 && second == 0) 
                {
                    MyTimer.StartTomTimer(); 
                }
                timer1.Enabled = true;
                if (btn_NewTim.Enabled) { btn_NewTim.Enabled = false; }
            }
            else 
            {
                timer1.Enabled = false;
                bStart.Text = "Старт";
                btn_NewTim.Enabled = true;
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
    }
}
