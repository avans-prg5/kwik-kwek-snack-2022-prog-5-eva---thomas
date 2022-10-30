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

        [HttpGet]
        public IActionResult Drinks()
        {
            _currentOrder = _repo.SaveNewOrder(_currentOrder);
            TempData["orderid"] = _currentOrder.OrderID;
            DrinkInOrder model = new DrinkInOrder() { Order = _currentOrder, OrderID = _currentOrder.OrderID };
            return View(model);
        }

        [HttpPost]
        public IActionResult Drinks(DrinkInOrder drink)
        {
            //Setting drink in order
            drink.Drink = _repo.GetItem(drink.DrinkName);
            drink.Order = _repo.GetOrder(drink.OrderID);
            drink.DrinkId = drink.Drink.ItemID;
            _repo.AddDrinkToOrder(drink);

            _currentOrder = drink.Order;
            _repo.UpdateOrder(_currentOrder);
            foreach (var newDrink in _currentOrder.Drinks)
            {
                newDrink.Drink = _repo.GetItem(newDrink.DrinkId);
            }

            //New drink
            DrinkInOrder model = new DrinkInOrder() { Order = _currentOrder, OrderID = _currentOrder.OrderID };
            return View(model);
        }

        [HttpGet]
        public IActionResult Snacks(int orderID)
        {
            _currentOrder = _repo.GetOrder(Int32.Parse(TempData["orderid"].ToString()));
            TempData["orderid"] = _currentOrder.OrderID;
            SnackInOrder model = new SnackInOrder() { Order = _currentOrder, OrderID = _currentOrder.OrderID };
            return View(model);
        }

        [HttpPost]
        public ActionResult Snacks(SnackInOrder snack)
        {
            _currentOrder = _repo.GetOrder(snack.OrderID);
            TempData["orderid"] = _currentOrder.OrderID;
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