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
    public class EquipmentController : Controller
    {
        ApplicationDbContext context;
        public EquipmentController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Equipments);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Equipment equipment)
        {
            context.Equipments.Add(equipment);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //Видалення одного елементу
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Equipment equipment = await context.Equipments.FirstOrDefaultAsync(p => p.Id == id);
                if (equipment != null)
                    return View(equipment);
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Equipment equipment = await context.Equipments.FirstOrDefaultAsync(p => p.Id == id);
                if (equipment != null)
                {
                    context.Equipments.Remove(equipment);
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
                Equipment equipment = await context.Equipments.FirstOrDefaultAsync(p => p.Id == id);
                if (equipment != null)
                    return View(equipment);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Equipment equipment)
        {
            context.Equipments.Update(equipment);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
