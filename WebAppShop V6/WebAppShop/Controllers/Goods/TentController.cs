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
    public class TentController : Controller
    {
        ApplicationDbContext context;
        public TentController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Tents);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tent tent)
        {
            context.Tents.Add(tent);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Tent tent = await context.Tents.FirstOrDefaultAsync(p => p.Id == id);
                if (tent != null)
                    return View(tent);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Tent tent = await context.Tents.FirstOrDefaultAsync(p => p.Id == id);
                if (tent != null)
                {
                    context.Tents.Remove(tent);
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
                Tent tent = await context.Tents.FirstOrDefaultAsync(p => p.Id == id);
                if (tent != null)
                    return View(tent);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Tent tent)
        {
            context.Tents.Update(tent);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
