using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class Order
    {
        public Snack[] Snacks { get; set; }
        public int OrderID { get; set; }
        public Drink[] Drinks { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
    }
}
