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
    public class DishController : Controller
    {
        ApplicationDbContext context;
        public DishController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Dishs);
        }

        //Create item
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Goods.Dish dish)
        {
            context.Dishs.Add(dish);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Dish dish = await context.Dishs.FirstOrDefaultAsync(p => p.Id == id);
                if (dish != null)
                    return View(dish);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Dish dish = await context.Dishs.FirstOrDefaultAsync(p => p.Id == id);
                if (dish != null)
                {
                    context.Dishs.Remove(dish);
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
                Dish dish = await context.Dishs.FirstOrDefaultAsync(p => p.Id == id);
                if (dish != null)
                    return View(dish);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Dish dish)
        {
            context.Dishs.Update(dish);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
