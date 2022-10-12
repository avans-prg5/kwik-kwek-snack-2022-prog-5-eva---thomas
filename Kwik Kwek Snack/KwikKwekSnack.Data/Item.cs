using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

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
        [NotNull]
        public bool IsAvailable { get; set; }
        public virtual List<DrinkInOrder> OrderWithDrinks { get; set; }
        public virtual List<SnackInOrder> OrderWithSnacks { get; set; }
    }
}