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
        private static ConsoleHandler CH;
        private SnackRepo _repo;
        private List<Order> _queue;
        private Order _ActiveOrder;
        private Order _LastCompeletedOrder;


        public MainController()
        {
            CH = new ConsoleHandler(this);
            _repo = new SnackRepo();
            _queue = new List<Order>();
            FillQueue();
            _ActiveOrder = PrepareNext();
            HeartBeat();
        }

        public void FillQueue()
        {
            _queue.Clear();

            _queue = _repo.GetOrdersInQueue();
        }

        private Order PrepareNext()
        {
            if (_queue.Count > 0)
            {
                _ActiveOrder = _queue.First();
                _queue.Remove(_queue.First());
                _ActiveOrder.Status = Status.Bereiding;
                updateOrder(_ActiveOrder);
                return _ActiveOrder;
            }
            return null;
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
                if(_queue.Count < 5) { FillQueue(); }
                if (_ActiveOrder != null) { FinishCurrentOrder(); }
                PrepareNext();
                CH.GenerateVisual(_queue, _ActiveOrder, _LastCompeletedOrder);
               
                Thread.Sleep(10000);
            }
        }




        private void updateOrder(Order order)
        {
            _repo.UpdateOrder(order);
        }

    }
}
