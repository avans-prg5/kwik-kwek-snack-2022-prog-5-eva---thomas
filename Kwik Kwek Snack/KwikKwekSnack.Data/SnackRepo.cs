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

        public Size GetSize(string size)
        {
            return _context.Sizes.Where(s => s.sizes == size).FirstOrDefault();
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.Where(o => o.OrderID == id).FirstOrDefault();
        }
    }
}