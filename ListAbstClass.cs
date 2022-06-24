using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TomatoTimer
{
    public interface IInterval 
    {
        string Name { get;  }
        int time { get;  }
        
    }
    public abstract class TomTimerBase
    {
        public delegate void getMyInfo(object str);
        public getMyInfo getMyTime;
        public getMyInfo getMyName;
        public getMyInfo getMyNum;
        public getMyInfo getMyMess;
        public int numActivInt { get; private set; }
        public abstract void StartTomTimer();
        public abstract void RestartInterval();
        public abstract void ShowRealTimInter(int min, int sec);
    }
    public abstract class ICustomTT
    { 
        public abstract void createListTimer(DataTable Tab);
        public abstract TomTimerBase GetYeorTimer();
    }
}
