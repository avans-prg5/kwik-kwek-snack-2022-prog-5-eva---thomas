using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Order _currentOrder = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Drinks()
        {
            var drinks = new List<DrinkInOrder>();
            var drink = new DrinkInOrder();
            drink.Drink = new Item() { Name = "bepis" };
            _currentOrder = new Order();
            drinks.Add(drink);
            ViewBag.Drinks = new List<Item> { drink.Drink }; //TODO: real data
            ViewBag.CurrentOrder = _currentOrder;
            return View(new DrinkInOrder());
        }

        /*public IActionResult Drinks(DrinkInOrder drink)
        {
            _currentOrder.Drinks.Add(drink);
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void CreateNewOrder()
        {
            _currentOrder = new Order();
        }
    }
}