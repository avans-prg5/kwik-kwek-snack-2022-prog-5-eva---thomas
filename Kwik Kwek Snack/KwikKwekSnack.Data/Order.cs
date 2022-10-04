using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    internal class Order
    {
        public int Id { get; set; }
        public Snack[] Snacks { get; set; }
        public Drink[] Drinks { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
    }
}
