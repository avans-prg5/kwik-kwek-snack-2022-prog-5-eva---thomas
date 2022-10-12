using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class DrinkInOrder
    {
        public Item Drink { get; set; }
        public Order Order { get; set; }
        public bool straw { get; set; }
        public bool ice { get; set; }
        public Size Size { get; set; }
        public string DrinkName { get; set; }
    }
}
