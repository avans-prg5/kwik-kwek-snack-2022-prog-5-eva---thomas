using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class DrinkInOrder
    {
        [Key]
        public string DrinkName { get; set; }
        public Item Drink { get; set; }
        [Key]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public bool straw { get; set; }
        public bool ice { get; set; }
        public Size size { get; set; }
    }
}
