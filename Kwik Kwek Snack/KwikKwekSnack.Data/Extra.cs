using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack.Data
{
    public class Extra
    {
        [Key]
        public ExtraName Name { get; set; }
        public float Price { get; set; }
    }

    public enum ExtraName
    {
        Kaas,
        Ui,
        Sla,
        Tomaat
    }
}
