using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert for how much time the timer should run : ");
            int timerRunningTime = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Start the timer : \n - yes \n - no ");
            Thread.Sleep(2000);

            Console.Clear();
            Console.Write("Insert your option : ");
            string timerOption = Console.ReadLine();
             

            switch(timerOption)
            {
                case "yes":
                    var StartClass = new Start(timerRunningTime, false);
                    break;

                case "no":
                    Environment.Exit(0);
                    break;
            }

 
        }
    }
}
