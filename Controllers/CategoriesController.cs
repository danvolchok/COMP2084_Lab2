using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        static List<CategoriesModel> categoryList = new List<CategoriesModel>
        {
            new CategoriesModel { CategoryId = 1, CategoryName = "Food"},
            new CategoriesModel { CategoryId = 2, CategoryName = "Tech"},
            new CategoriesModel { CategoryId = 3, CategoryName = "Sports"}
        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(categoryList);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            
            var selected = categoryList.First<CategoriesModel>(x => x.CategoryId == id);
            ViewBag.Message = "The selected category is " + selected.CategoryName;
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
