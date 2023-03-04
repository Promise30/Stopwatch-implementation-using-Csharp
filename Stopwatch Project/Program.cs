using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var stopWatch = new StopwatchClass();

            var valid = false;

            while (true)
            {
                if (!valid)
                    Console.Write("Enter 'start' or 'stop' or 'restart': ");

                var input = Console.ReadLine().ToLower();



                if (input == "start")
                {
                    stopWatch.Start();
                    Console.WriteLine("\nStopwatch has started...\n");
                    valid = true;

                }
                if (input == "stop")
                {
                    stopWatch.Stop();
                    Console.WriteLine("\nStopwatch has stopped...\n");
                    valid = false;

                    var interval = stopWatch.GetDuration();

                    Console.WriteLine("\nTime Interval: {0}:{1}:{2}", interval.Hours, interval.Minutes, interval.Seconds);
                }

                /*Console.Write("\nWill you like to continue: 'Yes/No': ");
                var answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                    continue;
                else

                    break;*/
                if(input == "restart")
                {
                    valid = false;
                    Console.WriteLine("Stopwatch has restarted...");
                    continue;
                }

            }


            Console.ReadKey();
        }
    }
}
