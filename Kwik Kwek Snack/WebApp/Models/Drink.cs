using System.Drawing;

namespace WebApp.Models
{
    class Drink : Item
    {
        public Size Size { get; set; }
        public bool Ice { get; set; }
        public bool Straw { get; set; }
    }
}
