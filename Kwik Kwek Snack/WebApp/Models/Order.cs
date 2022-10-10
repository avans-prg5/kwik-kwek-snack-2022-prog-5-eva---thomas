namespace WebApp.Models
{
    public class Order
    {
        public List<SnackInOrder> Snacks { get; set; }
        public int OrderID { get; set; }
        public List<DrinkInOrder> Drinks { get; set; }
        public Status Status { get; set; }
        public bool TakeAway { get; set; }
    }
}
