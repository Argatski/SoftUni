﻿namespace ProjectRider.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ProjectRider.Models;
    using System.Linq;

    public class ProjectController : Controller
    {
        private readonly ProjectDbContext context;

        public ProjectController(ProjectDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var projects = context.Projects.ToList();
            return View(projects);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            Project project = context
                .Projects
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(project);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Project projectModel)
        {
            context.Projects.Update(projectModel);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Project project = context
               .Projects
               .Where(p => p.Id == id)
               .FirstOrDefault();

            return View(project);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Project projectModel)
        {
            context.Projects.Remove(projectModel);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
