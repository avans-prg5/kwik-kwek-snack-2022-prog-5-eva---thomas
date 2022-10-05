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

        public List<Drink> GetDrinks()
        {
            return _context.Drinks.ToList();
        }

        public List<Snack> GetSnacks()
        {
            return _context.Snacks.ToList();
        }
    }
}