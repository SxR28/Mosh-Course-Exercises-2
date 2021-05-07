using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StopWatch
{
    class Start
    { 
        public Start(int TimeRunning, bool timerActivity)
        {
            Console.WriteLine($"The timer will run for {TimeRunning}, if you want to stop it, press [SPACE]");
            timerActivity = true;

            timerStoper(timerActivity);
            Console.ReadLine();
        }

        public bool timerStoper(bool _timerActivity)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                _timerActivity = false;

            if (_timerActivity == false)
                Environment.Exit(0);

            return _timerActivity;
        }
    }
}
