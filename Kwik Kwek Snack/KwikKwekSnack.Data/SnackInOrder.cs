using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KwikKwekSnack.Data
{
    public class SnackInOrder
    {
        public SnackInOrder()
        {
            Extra = new List<Extra>();
        }

        [Key]
        public string SnackName { get; set; }
        public Item Snack { get; set; }
        [Key]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public List<Extra> Extra { get; set; }
        [Key]
        public int SnackID { get; set; }
        public int Amount { get; set; }
    }
}
