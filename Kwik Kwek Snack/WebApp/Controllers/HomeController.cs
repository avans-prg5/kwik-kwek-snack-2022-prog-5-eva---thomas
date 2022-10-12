using KwikKwekSnack.Data;
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
        SnackRepo _repo = new SnackRepo();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _currentOrder.Drinks = new List<DrinkInOrder>();
            _currentOrder.Snacks = new List<SnackInOrder>();
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
        public IActionResult Snacks()
        {
            _repo.SaveNewOrder(_currentOrder);
            SnackInOrder model = new SnackInOrder() { Order = _currentOrder, OrderID = _currentOrder.OrderID };
            return View(model);
        }

        [HttpPost]
        public IActionResult Snacks(SnackInOrder snack)
        {
            //Setting snack in order
            snack.Snack = _repo.GetItem(snack.SnackName);
            snack.Order = _repo.GetOrder(snack.OrderID);
            snack.SnackID = snack.Snack.ItemID;
            _repo.AddSnackToOrder(snack);

            _currentOrder = snack.Order;
            _repo.UpdateOrder(_currentOrder);

            //New snack
            SnackInOrder model = new SnackInOrder() { Order = _currentOrder, OrderID = _currentOrder.OrderID };
            return View(model);
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