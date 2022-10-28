using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class BeschikbareExtraInSnack
    {
        public string ItemName { get; set; }
        public Item SnackItem { get; set; }
        public string ExtraName { get; set; }
        public Extra Extra { get; set; }
        public bool isAvailable { get; set; }

    }
}
