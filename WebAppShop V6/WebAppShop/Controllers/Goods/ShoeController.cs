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
    public class ShoeController : Controller
    {
        ApplicationDbContext context;
        public ShoeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Shoes);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Shoe shoe)
        {
            context.Shoes.Add(shoe);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Shoe shoe = await context.Shoes.FirstOrDefaultAsync(p => p.Id == id);
                if (shoe != null)
                    return View(shoe);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Shoe shoe = await context.Shoes.FirstOrDefaultAsync(p => p.Id == id);
                if (shoe != null)
                {
                    context.Shoes.Remove(shoe);
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
                Shoe shoe = await context.Shoes.FirstOrDefaultAsync(p => p.Id == id);
                if (shoe != null)
                    return View(shoe);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Shoe shoe )
        {
            context.Shoes.Update(shoe);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
