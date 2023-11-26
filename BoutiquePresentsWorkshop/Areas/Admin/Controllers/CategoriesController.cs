using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BPW.Data.Entities;
using BoutiquePresentsWorkshop.Data;
using Microsoft.AspNetCore.Authorization;

namespace BoutiquePresentsWorkshop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext db)
        {
            _context = db;
        }

        //GET Index Action Method
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        //GET Create Action Method

        public ActionResult Create()
        {
            return View();
        }

        //POST Create Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                TempData["save"] = "Продуктът е добавен успешно!";
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Update(category);
                await _context.SaveChangesAsync();
                TempData["edit"] = "Продуктът е редактиран успешно!";
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        //GET Details Action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTag = _context.Categories.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }

        //POST Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Category category)
        {
            return RedirectToAction(nameof(Index));

        }

        //GET Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTag = _context.Categories.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }

        //POST Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Category category)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id != category.CategoryId)
            {
                return NotFound();
            }

            var categories = _context.Categories.Find(id);
            if (categories == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Remove(categories);
                await _context.SaveChangesAsync();
                TempData["delete"] = "Продуктът е изтрит успешно!";
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}
