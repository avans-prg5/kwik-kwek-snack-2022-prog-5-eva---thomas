using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class SnackInOrder
    {
        public SnackInOrder()
        {
            Extra = new List<Extra>();
        }
        public Item Snack { get; set; }
        public Order Order { get; set; }
        public List<Extra> Extra { get; set; }
    }
}
