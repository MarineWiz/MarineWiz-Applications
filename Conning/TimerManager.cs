using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace App_Conning
{
    public static class TimerManager
    {
        private static List<DispatcherTimer> timers = new List<DispatcherTimer>();
        
        public static DispatcherTimer GetTimer(double interval) 
        {
            var timeSpan = TimeSpan.FromMilliseconds(interval);
            var timer = timers.FirstOrDefault(item => item.Interval == timeSpan);
            if (timer == null) 
            {
                Console.WriteLine("Created");
                timers.Add(timer = new DispatcherTimer { Interval = timeSpan });
            }
            
            return timer;
        }
    }
}