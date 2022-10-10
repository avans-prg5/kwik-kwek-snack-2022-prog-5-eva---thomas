namespace WebApp.Models
{
    public class Extra
    {
        public ExtraName Name { get; set; }
        public int Price { get; set; }
    }
    public enum ExtraName
    {
        Cheese,
        Onion,
        Lettuce,
        Tomato
    }
}
