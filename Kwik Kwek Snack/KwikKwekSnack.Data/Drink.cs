using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class Drink : Item
    {
        public Size Size { get; set; }
        public bool Ice { get; set; }
        public bool Straw { get; set; }
    }
}
