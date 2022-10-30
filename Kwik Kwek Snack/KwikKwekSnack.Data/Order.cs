using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
        public List<DrinkInOrder> Drinks { get; set; }
        public List<SnackInOrder> Snacks { get; set; }
    }

    public enum Status
    {
        Samenstellen,
        Wachtrij,
        Bereiding,
        Gereed
    }
}
