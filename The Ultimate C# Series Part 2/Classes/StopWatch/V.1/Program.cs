using System;
using System.Timers;
using System.Threading;

namespace Exercises
{
    class Program
    {
        static int timerTicks = 0;
        static int timeTicking;
        static System.Timers.Timer timer = new System.Timers.Timer();

        static void Main(string[] args)
        {
            Console.Write("Insert the StopWatch time when it should tick : ");
            int timeRunning = Int32.Parse(Console.ReadLine());
            int milliesecondInterval = timeRunning * 1000;
            timer.Interval = milliesecondInterval;

            Console.Write("Insert the time for how much time it should tick : ");
            timeTicking = Int32.Parse(Console.ReadLine());
            int milliesecondTimeTicking = timeTicking * 1000;

            Console.Clear();
            Console.Write("Start Timer (yes / no) : ");
            string timerStartOption = Console.ReadLine();
            ExeptionCatch(timerStartOption);

            if (timerStartOption == "yes" && timerStartOption != null)
            {
                timer.Elapsed += OnTimedEvent;
                timer.Start();

                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    int ticksLeft = timeTicking - timerTicks;
                    timer.Stop();
                    Console.Clear();
                    Console.WriteLine(
                        $"Timer stopped [!] \n" +
                        $"Ticks made {timerTicks} \n" +
                        $"Ticks left {ticksLeft}");
                }
            }
            else if (timerStartOption == "no")
                Environment.Exit(0);
            else
                Console.WriteLine("Inseterd something wrong");
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);

            if (timerTicks > timeTicking)
            {
                timer.Stop();
                Console.Clear();
            }
        }
        static string ExeptionCatch(string _timerStartOption)
        {
            if (_timerStartOption == null)
                Console.WriteLine("Value is null");
            else if (_timerStartOption is not string)
                Console.WriteLine("You didnt provide a string");

            return _timerStartOption;
        }
    }
}