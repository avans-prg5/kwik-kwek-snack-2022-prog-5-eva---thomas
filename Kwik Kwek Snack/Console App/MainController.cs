using KwikKwekSnack.Data;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
        private Queue<Order> _queue;
        private Order _ActiveOrder;
        private Order _LastCompeletedOrder;


        public MainController()
        {
            CH = new ConsoleHandler(this);
            _repo = new SnackRepo();
            _queue = new Queue<Order>();
            HeartBeat();
        }



        private void PrepareNext()
        {
            _ActiveOrder = _queue.Dequeue();
            _ActiveOrder.Status = Status.Bereiding;
            updateOrder(_ActiveOrder);
        }

        private void FinishCurrentOrder()
        {
            _ActiveOrder.Status = Status.Gereed;
            _LastCompeletedOrder = _ActiveOrder;
            _ActiveOrder = null;
            updateOrder(_LastCompeletedOrder);
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
