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
        public bool Straw { get; set; }
        public bool Ice { get; set; }
        public Size Size { get; set; }
        public int DrinkId { get; set; }
        public int Amount { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
