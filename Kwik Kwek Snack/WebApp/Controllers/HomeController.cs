using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Order _currentOrder = new Order();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _currentOrder.Drinks = new List<DrinkInOrder>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Drinks() => View(new DrinkInOrder());

        [HttpPost]
        public IActionResult Drinks(DrinkInOrder drink)
        {
            _currentOrder.Drinks.Add(drink);
            return View();
        }

        [HttpGet]
        public IActionResult Snacks() => View(new SnackInOrder());

        [HttpPost]
        public IActionResult Snacks(SnackInOrder snack)
        {
            snack.Order = _currentOrder;
            _currentOrder.Snacks.Add(snack);
            return View();
        }

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