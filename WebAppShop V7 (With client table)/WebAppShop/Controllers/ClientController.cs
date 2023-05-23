using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppShop.Data;
using WebAppShop.Models;

namespace WebAppShop.Controllers
{
    public class ClientController : Controller
    {
        ApplicationDbContext context;
        //Конструктор
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //Відображення всієї інформації з таблички
        public IActionResult Index()
        {
            return View(context.Buyers);
        }

        //Створення одного item
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Client buyer)
        {
            context.Buyers.Add(buyer);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Client buyer = await context.Buyers.FirstOrDefaultAsync(p => p.Id == id);
                if (buyer != null)
                    return View(buyer);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Client buyer = await context.Buyers.FirstOrDefaultAsync(p => p.Id == id);
                if (buyer != null)
                {
                    context.Buyers.Remove(buyer);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        //Редагування
        [HttpGet]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Client buyer = await context.Buyers.FirstOrDefaultAsync(p => p.Id == id);
                if (buyer != null)
                    return View(buyer);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(Client buyer)
        {
            context.Buyers.Update(buyer);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
