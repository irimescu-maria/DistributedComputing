using RentalCars.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalCars.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Category
        public ActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View(category);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Category category)
        {
            var newCategory = new Category
            {
                Class = category.Class
            };
            _context.Categories.Add(newCategory);
            _context.SaveChanges();

            return RedirectToAction("Index", "Category");
        }

        //Edit  category
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _context.Categories.Single(c => c.Id == id);

            return PartialView(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var editCategory = _context.Categories.Single(c => c.Id == category.Id);

            if (category.Id > 0)
            {
                editCategory.Class = category.Class;
                _context.Categories.AddOrUpdate(editCategory);
                _context.SaveChanges();
            }

            return View("Index");
        }
    }
}