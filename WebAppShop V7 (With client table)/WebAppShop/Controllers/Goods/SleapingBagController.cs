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
    public class SleapingBagController : Controller
    {
        ApplicationDbContext context;
        public SleapingBagController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.SleapingBags);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SleapingBag sleapingBag)
        {
            context.SleapingBags.Add(sleapingBag);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                SleapingBag sleapingBag = await context.SleapingBags.FirstOrDefaultAsync(p => p.Id == id);
                if (sleapingBag != null)
                    return View(sleapingBag);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                SleapingBag sleapingBag = await context.SleapingBags.FirstOrDefaultAsync(p => p.Id == id);
                if (sleapingBag != null)
                {
                    context.SleapingBags.Remove(sleapingBag);
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
                SleapingBag sleapingBag = await context.SleapingBags.FirstOrDefaultAsync(p => p.Id == id);
                if (sleapingBag != null)
                    return View(sleapingBag);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SleapingBag sleapingBag)
        {
            context.SleapingBags.Update(sleapingBag);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
