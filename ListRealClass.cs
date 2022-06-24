using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TomatoTimer
{
    public class Interval:IInterval
    {
        public string Name { get; private set; }
        public int time { get; private set; }
        public Interval(string str, int num)
        {
            Name = str;
            time = num;
        }
    }
    public class TomTimer:TomTimerBase
    {
        public new int numActivInt { get; private set; }
        List<IInterval> listIntervalTimer;
        public TomTimer(List<IInterval> intertime) 
        {
            listIntervalTimer = intertime;
            numActivInt =0;
        }
        void numUp()
        {
            numActivInt++;
            if (numActivInt >= listIntervalTimer.Count)
            {
                numActivInt = 0;
            }
        }
        public override void StartTomTimer()
        {
            if (numActivInt != 0) { numActivInt = 0; }
            getMyName?.Invoke(listIntervalTimer[numActivInt].Name);
            if (listIntervalTimer[numActivInt].time < 10)
            {
                getMyTime?.Invoke("0" + listIntervalTimer[numActivInt].time + ":00");
            }
            getMyNum?.Invoke(listIntervalTimer[numActivInt].time);
        }
        public override void RestartInterval()
        {
            if (listIntervalTimer[numActivInt].time < 10)
            {
                getMyTime?.Invoke("0" + listIntervalTimer[numActivInt].time + ":00");
            }
            getMyTime?.Invoke(listIntervalTimer[numActivInt].time + ":00");
            getMyNum?.Invoke(listIntervalTimer[numActivInt].time);
        }
        public override void ShowRealTimInter(int min, int sec)
        {
            if (min == 0)
            {
                if (sec == 3 && numActivInt!=(listIntervalTimer.Count-1)) 
                { 
                    getMyMess?.Invoke(listIntervalTimer[numActivInt].Name+" завершён!!!"); 
                }
                if (sec == 0)
                {
                    numUp();
                    if (numActivInt != 0)
                    {
                        getMyName?.Invoke(listIntervalTimer[numActivInt].Name);
                        if (listIntervalTimer[numActivInt].time < 10)
                        {
                            getMyTime?.Invoke("0" + listIntervalTimer[numActivInt].time + ":00");
                        }
                        getMyTime?.Invoke(listIntervalTimer[numActivInt].time + ":00");
                        getMyNum?.Invoke(listIntervalTimer[numActivInt].time);
                    }
                    else
                    {
                        getMyNum?.Invoke(numActivInt);
                        getMyTime?.Invoke("00:00");
                        getMyMess?.Invoke("Таймер окончен!!!");
                    }
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
                string str = (min < 10) ? "0" + min : min.ToString();
                str += ":";
                str += (sec < 10) ? "0" + sec : sec.ToString();
                getMyTime?.Invoke(str);
            }
        }
    }
    public class CustomTT:ICustomTT 
    {
        List<IInterval> Tl;
        public CustomTT() 
        {
            Tl = new List<IInterval>();
        }
        public override void createListTimer(DataTable Tab)
        {
            Tl.Clear();
            foreach (DataRow Row in Tab.Rows) 
            {
                Tl.Add(new Interval(Row[0].ToString(), int.Parse(Row[1].ToString())));
            }
        }
        public override TomTimerBase GetYeorTimer() 
        {
            if (Tl.Count == 0) return null;
            else return new TomTimer(Tl);
        }
    }
}
