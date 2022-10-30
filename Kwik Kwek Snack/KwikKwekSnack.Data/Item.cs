using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace KwikKwekSnack.Data
{
    public class Item
    {
        [Key]
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public bool IsDrink { get; set; }
        [NotNull]
        public bool IsAvailable { get; set; }
        public virtual List<DrinkInOrder> OrderWithDrinks { get; set; }
        public virtual List<SnackInOrder> OrderWithSnacks { get; set; }
        public virtual List<BeschikbareExtraInSnack> BeschikbareExtras { get; set; }
    }
}