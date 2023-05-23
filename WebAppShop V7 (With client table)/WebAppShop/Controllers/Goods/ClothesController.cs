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
    public class ClothesController : Controller
    {
        ApplicationDbContext context;
        public ClothesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Clothess);
        }

        //Create item
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Goods.Clothes clothes)
        {
            context.Clothess.Add(clothes);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Clothes clothes = await context.Clothess.FirstOrDefaultAsync(p => p.Id == id);
                if (clothes != null)
                    return View(clothes);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Clothes clothes = await context.Clothess.FirstOrDefaultAsync(p => p.Id == id);
                if (clothes != null)
                {
                    context.Clothess.Remove(clothes);
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
                Clothes clothes = await context.Clothess.FirstOrDefaultAsync(p => p.Id == id);
                if (clothes != null)
                    return View(clothes);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Clothes clothes)
        {
            context.Clothess.Update(clothes);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }




    }
}
