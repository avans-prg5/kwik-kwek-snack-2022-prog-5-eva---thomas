using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using KwikKwekSnack.Data;

namespace Console_App
{
    internal class ConsoleHandler
    {
        MainController MC;

        public ConsoleHandler(MainController mc)
        {
            MC = mc;
            for (int i = 0; i < 60; i++)
            {
                Console.Write("█");
                Thread.Sleep(60);
            }

            Console.Clear();

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
            Console.WriteLine("ORDERNR | TAKE | DRINK<SMALL>{ICE}, ORDER ITEM 2, ORDER ITEM 3, ORDER ITEM 4");
        }

        private static void PrintToBePreparedOrders(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                Console.Write(order.OrderID + " | ");
                if (order.TakeAway)
                {
                    Console.Write("TAKE |");
                }
                else
                {
                    Console.Write("STAY |");
                }
                //if (order.Snacks.Length > 0)
                //{
                //    Console.Write("|SNACKS[");
                //    foreach (Snack snack in order.Snacks)
                //    {
                //        Console.Write(snack.Name);
                //        if (snack.Extras.Length > 0)
                //        {
                //            Console.Write("{");
                //            foreach (Extra extra in snack.Extras)
                //            {
                //                Console.Write(extra.Extras + ", ");
                //            }
                //            Console.Write("}");
                //        }
                //        Console.Write(",");

                //    }
                //    Console.Write("]");

                //}
                //if (order.Drinks.Length > 0)
                //{
                //    Console.Write("DRINKS[");
                //    foreach (Drink drink in order.Drinks)
                //    {
                //        Console.Write(drink.Name + "<"+drink.Size+">");
                //        if (drink.Ice || drink.Straw)
                //        {
                //            Console.Write("{");
                //            if (drink.Ice)
                //            {
                //                Console.Write("ice, ");
                //            }
                //            if (drink.Straw)
                //            {
                //                Console.Write("straw ");
                //            }
                //            Console.Write("}");
                //        }
                //    }
                //    Console.WriteLine("]");

                //}
            }
        }

        private static void PrintHeader()
        {

            Separator();

        }

        public static void GenerateVisual()
        {
            throw new NotImplementedException();
           
            //PrintToBePreparedOrders();
        }
    }
}

