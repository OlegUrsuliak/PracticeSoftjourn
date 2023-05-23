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
    public class FoodController : Controller
    {
        ApplicationDbContext context;
        public FoodController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Foods);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Food food)
        {
            context.Foods.Add(food);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Food food = await context.Foods.FirstOrDefaultAsync(p => p.Id == id);
                if (food != null)
                    return View(food);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Food food = await context.Foods.FirstOrDefaultAsync(p => p.Id == id);
                if (food != null)
                {
                    context.Foods.Remove(food);
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
                Food food = await context.Foods.FirstOrDefaultAsync(p => p.Id == id);
                if (food != null)
                    return View(food);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Food food)
        {
            context.Foods.Update(food);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
