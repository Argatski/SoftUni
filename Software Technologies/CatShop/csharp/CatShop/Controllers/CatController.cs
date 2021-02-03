namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext db;

        public CatController(CatDbContext dbcontext)
        {
            this.db = dbcontext;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var cats = db.Cats.ToList();
            return View(cats);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            db.Cats.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            var cat = this.db.Cats.Find(id);

            if (cat == null)
            {
                return NotFound(404);
            }

            return View(cat);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            this.db.Cats.Update(catModel);
            this.db.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var cat = this.db.Cats.Find(id);

            if (cat == null)
            {
                return NotFound(404);
            }

            return View(cat);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            this.db.Cats.Remove(catModel);
            this.db.SaveChanges();
            return Redirect("/");
        }
    }
}
