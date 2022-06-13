using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class TomTimer 
    {
        int numActivInt;
        List<Interval> listIntervalTimer;
        public TomTimer(List<Interval> intertime) 
        {
            listIntervalTimer = intertime;
            numActivInt = 0;
        }
        public void numUp() 
        {
            numActivInt++;
            if (numActivInt >= listIntervalTimer.Count) { numActivInt = 0; }
        }
        public Interval GetActivInterval() { return listIntervalTimer[numActivInt]; }
    }
}
