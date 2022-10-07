using KwikKwekSnack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public class MainController
    {
        private ConsoleHandler CH;
        private SnackRepo _repo;
        private List<Order> _queue;
        private Order _ActiveOrder;


        public MainController()
        {
            CH = new ConsoleHandler(this);
            _repo = new SnackRepo();

            HeartBeat();
        }





        private void HeartBeat()
        {
            while (true)
            {

                Thread.Sleep(2000);
            }
        }




        private void updateOrder(Order order)
        {
            _repo.UpdateOrder(order);
        }

    }
}
