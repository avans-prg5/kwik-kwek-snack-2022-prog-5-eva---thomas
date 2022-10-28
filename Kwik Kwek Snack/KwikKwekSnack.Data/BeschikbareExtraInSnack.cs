using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class BeschikbareExtraInSnack
    {
        [Key]
        public int ItemID { get; set; }
        public Item SnackItem { get; set; }
        [Key]
        public string Name { get; set; }
        public Extra Extra { get; set; }
        public bool isAvailable { get; set; }

    }
}
