using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Console_App
{
    internal class ConsoleHandler
    {
        private static System.Timers.Timer timer;

        public ConsoleHandler()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.Write("█");
                Thread.Sleep(60);
            }

            Console.Clear();

        }


        private void SetTimer()
        {

            Console.WriteLine("timer was set");
            // Create a timer with a two second interval.
            timer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
           // timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
        private static void Separator()
        {
            for (int i = 0; i < 49; i++) { Console.Write("█"); }
            Console.WriteLine("█");
        }

        private static void EmptySeparator(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }
            
        }
        private static void GetNextMockResult()
        {
            Console.WriteLine("ORDERNR |  ORDER ITEM 1, ORDER ITEM 2, ORDER ITEM 3, ORDER ITEM 4");
        }

        private static void GetNextResult()
        {
            throw new NotImplementedException();
        }

        public static void GenerateVisual()
        {
            throw new NotImplementedException();
        }
    }
}

