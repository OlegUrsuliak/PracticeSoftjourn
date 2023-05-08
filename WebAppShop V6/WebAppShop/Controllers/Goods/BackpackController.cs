using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppShop.Data;
using WebAppShop.Models.Goods;

namespace WebAppShop.Controllers.Goods
{
    public class BackpackController : Controller
    {
        ApplicationDbContext context;
        public BackpackController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Backpacks);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Backpack backpack)
        {
            context.Backpacks.Add(backpack);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Backpack backpack = await context.Backpacks.FirstOrDefaultAsync(p => p.Id == id);
                if (backpack != null)
                    return View(backpack);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Backpack backpack = await context.Backpacks.FirstOrDefaultAsync(p => p.Id == id);
                if (backpack != null)
                {
                    context.Backpacks.Remove(backpack);
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
                Backpack backpack = await context.Backpacks.FirstOrDefaultAsync(p => p.Id == id);
                if (backpack != null)
                    return View(backpack);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Backpack backpack)
        {
            context.Backpacks.Update(backpack);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
