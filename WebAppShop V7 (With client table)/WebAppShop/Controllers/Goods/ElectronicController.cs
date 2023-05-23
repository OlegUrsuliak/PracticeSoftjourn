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
    public class ElectronicController : Controller
    {
        ApplicationDbContext context;
        public ElectronicController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Electronics);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Electronic electronic)
        {
            context.Electronics.Add(electronic);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Electronic electronic = await context.Electronics.FirstOrDefaultAsync(p => p.Id == id);
                if (electronic != null)
                    return View(electronic);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Electronic electronic = await context.Electronics.FirstOrDefaultAsync(p => p.Id == id);
                if (electronic != null)
                {
                    context.Electronics.Remove(electronic);
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
                Electronic electronic = await context.Electronics.FirstOrDefaultAsync(p => p.Id == id);
                if (electronic != null)
                    return View(electronic);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Electronic electronic)
        {
            context.Electronics.Update(electronic);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
