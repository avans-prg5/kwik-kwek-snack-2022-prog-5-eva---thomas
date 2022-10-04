namespace WebApp.Models
{
    class Order
    {
        public Snack[] Snacks { get; set; }
        public int OrderID { get; set; }
        public Drink[] Drinks { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
    }
}
