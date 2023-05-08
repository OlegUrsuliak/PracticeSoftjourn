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
        public virtual DbSet<Backpack> Backpacks { get; set; }
        public virtual DbSet<Caremat> Caremats { get; set; }
        public virtual DbSet<Clothes> Clothess { get; set; }
        public virtual DbSet<Dish> Dishs { get; set; }
        public virtual DbSet<Electronic> Electronics { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Literature> Literatures { get; set; }
        public virtual DbSet<Shoe> Shoes { get; set; }
        public virtual DbSet<SleapingBag> SleapingBags { get; set; }
        public virtual DbSet<Tent> Tents { get; set; }
    }
}
