using System.ComponentModel.DataAnnotations;

namespace KwikKwekSnack.Data
{
    public class Item
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public bool IsDrink { get; set; }
        public virtual List<DrinkInOrder> Drinks { get; set; }
        public virtual List<SnackInOrder> Snacks { get; set; }
    }
}