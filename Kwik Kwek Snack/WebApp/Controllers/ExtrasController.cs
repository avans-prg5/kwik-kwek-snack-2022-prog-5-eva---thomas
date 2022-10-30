using KwikKwekSnack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ExtrasController : Controller
    {
        SnackRepo _repo = new SnackRepo();

        // GET: DrinksController
        public ActionResult Index()
        {
            return View(_repo.GetExtras());
        }

        // GET: DrinksController/Details/5
        public ActionResult Details(string id)
        {
            return View(_repo.GetExtra(id));
        }

        [HttpGet]
        public ActionResult Add(string? id)
        {
            return View(new BeschikbareExtraInSnack() { ExtraName = id });
        }
        [HttpPost]
        public RedirectToActionResult Add(BeschikbareExtraInSnack extra)
        {
            _repo.CreateExtraInSnack(extra);
            return RedirectToAction("Index", "Extras");
        }

        // GET: DrinksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrinksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Create(Extra extra, IFormCollection collection)
        {
            _repo.CreateNewExtra(extra);
            //_repo.CreateExtraInSnack(extra.Name, extra.)
            return RedirectToAction("Index", "Extras");
        }

        // GET: DrinksController/Edit/5
        public ActionResult Edit(string? id)
        {
            if (!id.Equals(null))
            {
                var gerecht = _repo.GetExtra(id);
                return View(gerecht);
            }
            return RedirectToAction("Index");
        }

        // POST: DrinksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Edit(Item item, string id, IFormCollection collection)
        {
            _repo.EditItem(item);
            return RedirectToAction("Index", "Extras");
        }

        // GET: DrinksController/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_repo.GetExtra(id));
        }

        // POST: DrinksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Delete(string id, IFormCollection collection)
        {
            _repo.DeleteExtra(_repo.GetExtra(id));
            return RedirectToAction("Index", "Extras");
        }
    }
}
