using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MidtermStopWatch
{
    class StopWatch
    {
        public int seconds = 0;
        public int minutes = 0;
        public int hours = 0;
        public bool startWatch = true;
        
        public void Start()
        {
            Console.WriteLine("press spacebar to start or backspace to exit");

            while (startWatch)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Stop();
                }
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Good bye");
                    break;
                }
            }
            Console.WriteLine("press spacebar to start or backspace to exit");

        }
        

        private void Stop()
        {
            Console.WriteLine("Press ESC to stop");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Console.Write("\r Time: {00}:{1}:{2}", hours, minutes, seconds);
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }
                System.Threading.Thread.Sleep(1000);
                seconds++;

            }
            Console.WriteLine("\nPress any key to continue:");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
