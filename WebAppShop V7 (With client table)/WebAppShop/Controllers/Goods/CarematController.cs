using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppShop.Models;
using WebAppShop.Models.Goods;
using WebAppShop.Data;
using Microsoft.EntityFrameworkCore;

namespace WebAppShop.Controllers.Goods
{
    public class CarematController : Controller
    {
        ApplicationDbContext context;
        public CarematController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Caremats);
        }

        //Create item
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Goods.Caremat caremat)
        {
            context.Caremats.Add(caremat);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Delete one item
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Caremat caremat = await context.Caremats.FirstOrDefaultAsync(p => p.Id == id);
                if (caremat != null)
                    return View(caremat);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Caremat caremat = await context.Caremats.FirstOrDefaultAsync(p => p.Id == id);
                if (caremat != null)
                {
                    context.Caremats.Remove(caremat);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        //Edit item
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Caremat caremat = await context.Caremats.FirstOrDefaultAsync(p => p.Id == id);
                if (caremat != null)
                    return View(caremat);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Caremat caremat)
        {
            context.Caremats.Update(caremat);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
