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

        public string SnackName { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public List<Extra> Extra { get; set; }
    }
}
