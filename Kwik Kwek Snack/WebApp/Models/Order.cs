namespace WebApp.Models
{
    class Order
    {
        public List<Snack> Snacks { get; set; }
        public int OrderID { get; set; }
        public List<Drink> Drinks { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
    }
}
