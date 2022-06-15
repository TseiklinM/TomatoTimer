using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TomatoTimer
{
    public class Interval 
    {
        public string Name { get; private set; }
        public int time { get; private set; }
        public Interval(string str,int num) 
        {
            Name = str;
            time = num;
        }
    }
    public class MyTimer 
    {
        public delegate void yourTime(int min, int sec);
        public yourTime GetYourTime;
        //TimerCallback myCallback;
        Timer myTimer;
        int minute;
        int second;
        bool FlagStop;
        public MyTimer() 
        {
            minute = 0;
            second = 0;
            //myCallback = new TimerCallback(myTicTak); 
            FlagStop = true;
        }
       
        public void StartMyTim(object num)
        {
            FlagStop = false;
            minute = (int)num - 1;
            second = 60;
            //myTimer = new Timer(myCallback,null,0,10000);
            myTimer = new Timer(1000);
            myTimer.Elapsed += myTicTak;
            myTimer.Start();
            //do
            //{
            //    Task tas = new Task(() => myTicTak());
            //    tas.Start();
            //    tas.Wait();
            //    GetYourTime?.Invoke(minute, second);
            //} while (!FlagStop);


        }
        void myTicTak(object ser,ElapsedEventArgs e) 
        {
            if (!FlagStop) 
            {
            //Thread.Sleep(1000);
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
                        FlagStop = true;
                    }

                }
                
                
            }
            GetYourTime?.Invoke(minute, second);
            if (FlagStop) { myTimer.Stop(); }
        }

    }
    public class TomTimer 
    {
        public delegate void getMyInfo(object str);
        public getMyInfo getMyTime;
        public getMyInfo getMyName;
        public getMyInfo getMyNum;
        
        //MyTimer timer;
        int numActivInt;
        List<Interval> listIntervalTimer;
        public TomTimer(List<Interval> intertime) 
        {
            listIntervalTimer = intertime;
            numActivInt = 0;
            //timer = new MyTimer();
            //timer.GetYourTime += ShowRealTimInter;
        }
        void numUp() 
        {
            numActivInt++;
            if (numActivInt >= listIntervalTimer.Count) 
            {
                numActivInt = 0; 
            }
        }
        //public Interval GetActivInterval() { return listIntervalTimer[numActivInt]; }
        public void StartTomTimer() 
        {
            if (numActivInt != 0) { numActivInt = 0; }
            getMyName?.Invoke(listIntervalTimer[numActivInt].Name);
            if (listIntervalTimer[numActivInt].time < 10) 
            {
                getMyTime?.Invoke("0" + listIntervalTimer[numActivInt].time+":00");
            }
            getMyNum?.Invoke(listIntervalTimer[numActivInt].time);
        }
        public void ShowRealTimInter(int min,int sec) 
        {
            if (min == 0) 
            {
                if (sec == 0) 
                {
                    numUp();
                    getMyName?.Invoke(listIntervalTimer[numActivInt].Name);
                    if (listIntervalTimer[numActivInt].time < 10)
                    {
                        getMyTime?.Invoke("0" + listIntervalTimer[numActivInt].time + ":00");
                    }
                    getMyNum?.Invoke(listIntervalTimer[numActivInt].time);
                }
                else 
                {
                    string str = (min < 10) ? "0" + min : min.ToString();
                    str += ":";
                    str += (sec < 10) ? "0" + sec : sec.ToString();
                    getMyTime?.Invoke(str);
                }
            }
            else 
            {
                string str = (min < 10) ? "0" + min : min.ToString() + ":";
                str+=(sec<10)?"0"+sec:sec.ToString();
                getMyTime?.Invoke(str);
            }
        }
    }
}
