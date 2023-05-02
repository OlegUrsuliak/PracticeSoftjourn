using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppShop.Models;
using WebAppShop.Models.Goods;
//using Microsoft.AspNetCore.Identity;

namespace WebAppShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public DbSet<WebAppShop.Models.Goods.Backpack> Backpack { get; set; }
        public DbSet<WebAppShop.Models.Goods.Caremat> Caremat { get; set; }
        public DbSet<WebAppShop.Models.Goods.Clothes> Clothes { get; set; }
        public DbSet<WebAppShop.Models.Goods.Dish> Dish { get; set; }
        public DbSet<WebAppShop.Models.Goods.Electronic> Electronic { get; set; }
        public DbSet<WebAppShop.Models.Goods.Equipment> Equipment { get; set; }
        public DbSet<WebAppShop.Models.Goods.Food> Food { get; set; }
        public DbSet<WebAppShop.Models.Goods.Literature> Literature { get; set; }
        public DbSet<WebAppShop.Models.Goods.Shoe> Shoe { get; set; }
        public DbSet<WebAppShop.Models.Goods.SleapingBag> SleapingBag { get; set; }
        public DbSet<WebAppShop.Models.Goods.Tent> Tent { get; set; }
    }
}
