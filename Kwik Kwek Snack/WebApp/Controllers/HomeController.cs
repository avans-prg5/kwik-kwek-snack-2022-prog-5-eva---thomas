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
        WebApp.Models.Order _currentOrder = new WebApp.Models.Order();
        SnackRepo _repo = new SnackRepo();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _currentOrder.Drinks = new List<Models.DrinkInOrder>();
            _currentOrder.Snacks = new List<Models.SnackInOrder>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Drinks() => View(new WebApp.Models.DrinkInOrder());

        [HttpPost]
        public IActionResult Drinks(WebApp.Models.DrinkInOrder drink)
        {
            _currentOrder.Drinks.Add(drink);
            return View();
        }

        [HttpGet]
        public IActionResult Snacks()
        {
            Models.SnackInOrder model = new Models.SnackInOrder() { Order = _currentOrder };
            _repo.SaveNewOrder();
            return View(model);
        }

        [HttpPost]
        public IActionResult Snacks(WebApp.Models.SnackInOrder snack)
        {
            //Setting snack in order
            var tempSnack = _repo.GetItem(snack.SnackName);
            snack.Snack = new Models.Item().ConvertType(tempSnack);
            snack.Order = _currentOrder;
            _currentOrder.Snacks.Add(snack);

            //New snack
            Models.SnackInOrder model = new Models.SnackInOrder() { Order = _currentOrder };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void CreateNewOrder()
        {
            _currentOrder = new WebApp.Models.Order();
        }
    }
}