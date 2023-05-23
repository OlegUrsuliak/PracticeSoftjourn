using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppShop.Data;
using WebAppShop.Models.Goods;

namespace WebAppShop.Controllers.Goods
{
    public class LiteratureController : Controller
    {
        ApplicationDbContext context;
        public LiteratureController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Literatures);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Literature literature)
        {
            context.Literatures.Add(literature);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Literature literature = await context.Literatures.FirstOrDefaultAsync(p => p.Id == id);
                if (literature != null)
                    return View(literature);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Literature literature = await context.Literatures.FirstOrDefaultAsync(p => p.Id == id);
                if (literature != null)
                {
                    context.Literatures.Remove(literature);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        //Редагування
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Literature literature = await context.Literatures.FirstOrDefaultAsync(p => p.Id == id);
                if (literature != null)
                    return View(literature);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Literature literature)
        {
            context.Literatures.Update(literature);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
