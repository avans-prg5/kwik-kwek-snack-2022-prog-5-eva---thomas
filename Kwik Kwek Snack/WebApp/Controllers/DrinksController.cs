using KwikKwekSnack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class DrinksController : Controller
    {
        SnackRepo _repo = new SnackRepo();

        // GET: DrinksController
        public ActionResult Index()
        {
            return View(_repo.GetDrinks());
        }

        // GET: DrinksController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetItem(id));
        }

        // GET: DrinksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrinksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Create(Item item, IFormCollection collection)
        {
            _repo.CreateNewItem(item);
            return RedirectToAction("Index", "Drinks");
        }

        // GET: DrinksController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var gerecht = _repo.GetItem(id.Value);
                return View(gerecht);
            }
            return RedirectToAction("Index");
        }

        // POST: DrinksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Edit(Item item, int id, IFormCollection collection)
        {
            _repo.EditItem(item);
            return RedirectToAction("Index", "Drinks");
        }

        // GET: DrinksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetItem(id));
        }

        // POST: DrinksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Delete(int id, IFormCollection collection)
        {
            _repo.DeleteItem(_repo.GetItem(id));
            return RedirectToAction("Index", "Drinks");
        }
    }
}
