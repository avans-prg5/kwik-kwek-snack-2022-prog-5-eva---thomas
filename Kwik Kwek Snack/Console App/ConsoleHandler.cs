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

        

        private static void PrintHeader()
        {
            Separator();
            Console.WriteLine("CURRENT ORDERS");
            Separator();

        }
        private static void PrintQueue(List<Order> orders, Order currentOrder)
        {
            for (int i = orders.Count()-1; i > orders.Count() - 6; i--)
            {
                String adin;
               
                if (i > -1) {
                    if (orders[i].TakeAway == false)
                    {
                        adin = "| DINER";
                    }
                    else { adin = "| TAKEOUT"; }

                    Console.WriteLine(orders[i].OrderID+adin); 
                }
            }
            if (currentOrder != null)
            {
                String adin;
                if (currentOrder.TakeAway == false)
                {
                    adin = "| DINER";
                }
                else { adin = "| TAKEOUT"; }
                Console.WriteLine(currentOrder.OrderID + adin) ;
            }
            else { Console.WriteLine(); }

        }

        private static void PrintFooter(Order lastCompleted)
        {
            Separator();
            Console.WriteLine("READY FOR PICKUP");
            Separator();
            if (lastCompleted != null)
            {
                String adin;
                if (lastCompleted.TakeAway == false)
                {
                    adin = "| DINER";
                }
                else { adin = "| TAKEOUT"; }
                Console.WriteLine(lastCompleted.OrderID+adin);
            }
            else
            {
                Console.WriteLine("No completed orders");
            }
        }

        public void GenerateVisual(List<Order> orders,Order activeOrder, Order lastcompleted)
        {
            Console.Clear();
            PrintHeader();
            PrintQueue(orders, activeOrder);
            PrintFooter(lastcompleted);

        }
    }
}

