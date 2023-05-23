using Microsoft.AspNetCore.Authorization;
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
    public class DistributorController : Controller
    {
        ApplicationDbContext context;
        //Конструктор
        public DistributorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //Відображення всієї інформації з таблички
        public IActionResult Index()
        {
            return View(context.Distributors);
        }

        //Створення одного item
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.Distributor distributors)
        {
                context.Distributors.Add(distributors);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task <IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Distributor distributors = await context.Distributors.FirstOrDefaultAsync(p => p.Id == id);
                if (distributors != null)
                    return View(distributors);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int ? id)
        {
            if (id != null)
            {
                Distributor distributors = await context.Distributors.FirstOrDefaultAsync(p => p.Id == id);
                if (distributors != null)
                {
                    context.Distributors.Remove(distributors);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                } 
            }
                return NotFound();
        }

        //Редагування
        [HttpGet]
        //[Authorize(Roles = "admin")]
        public async Task <IActionResult> Edit (int? id)
        {
            if (id!=null)
            {
                Distributor distributor = await context.Distributors.FirstOrDefaultAsync(p => p.Id == id);
                if (distributor != null)
                    return View(distributor);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(Distributor distributor)
        {
            context.Distributors.Update(distributor);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
