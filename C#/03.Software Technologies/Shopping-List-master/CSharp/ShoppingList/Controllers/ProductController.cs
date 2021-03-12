namespace ShoppingList.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class ProductController : Controller
    {
        private readonly ShoppingListDbContext db;

        public ProductController(ShoppingListDbContext dbContext)
        {
            this.db = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var products = this.db.Products.ToList();

            return View(products);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Product product)
        {

            if (ModelState.IsValid)
            {
                this.db.Products.Add(product);
                this.db.SaveChanges();
                return Redirect("/");
            }

            return View(product);
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            var project = this.db.Products.Find(id);

            if(project == null)
            {
                return NotFound(404);
            }
            
            return View(project);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Product product)
        {
                this.db.Products.Update(product);
                this.db.SaveChanges();
                return Redirect("/");
         
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int? id)
        {
            var project = this.db.Products.Find(id);

            if (project == null)
            {
                return NotFound(404);
            }

            return View(project);
        }

        [HttpPost]
        [Route("/Delete/{id}")]
        public IActionResult Delete(Product product)
        {
            this.db.Products.Remove(product);
            this.db.SaveChanges();
            return Redirect("/");

        }

    }
}
