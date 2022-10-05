using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class Snack : Item
    {
        public Extra[] Extras { get; set; }
    }
}
