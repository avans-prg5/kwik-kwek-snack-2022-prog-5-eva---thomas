namespace WebApp.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Price { get; set; }
        public bool IsDrink { get; set; }
        public Item ConvertType(KwikKwekSnack.Data.Item dataItem)
        {
            Item temp = new Item()
            {
                Name = dataItem.Name,
                Description = dataItem.Description,
                ImageURL = dataItem.ImageURL,
                Price = dataItem.Price,
            };
            return temp;
        }
    }
}
