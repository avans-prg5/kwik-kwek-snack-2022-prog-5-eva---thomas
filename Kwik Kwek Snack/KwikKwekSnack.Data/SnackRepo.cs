using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class SnackRepo
    {
        SnackContext _context = new SnackContext();

        //Methods to get stuff out of database

        public List<Item> GetDrinks()
        {
            return _context.Items.Where(i => i.IsDrink).ToList();
        }

        public List<Item> GetSnacks()
        {
            return _context.Items.Where(i => !i.IsDrink).ToList();
        }

        public Item GetItem(string name)
        {
            return _context.Items.Where(i => i.Name.Equals(name)).FirstOrDefault();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
        }

        public List<Extra> GetExtra(ExtraName name)
        {
            return _context.Extras.Where(e => e.Name.Equals(name.ToString())).ToList();
        }

        public Order GetLastCompleted()
        {
            return _context.Orders.OrderBy(o => o.OrderID).Where(o => o.Status.Equals(Status.Gereed)).LastOrDefault();

        }

        public List<Order> GetOrdersInPreparation()
        {
            return _context.Orders.OrderBy(o => o.OrderID).Where(o => o.Status.Equals(Status.Bereiding)).ToList(); ;
        }

        public List<Order> GetOrdersInQueue()
        {
            return _context.Orders.OrderBy(o => o.OrderID).Where(o => o.Status.Equals(Status.Wachtrij)).ToList(); ;
        }

        public void UpdateOrder(Order order)
        {
            _context.Update(order);
            _context.SaveChanges();
        }
    }

}