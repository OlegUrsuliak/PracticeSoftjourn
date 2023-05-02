using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppShop.Data;

namespace WebAppShop.Controllers
{
    public class DistributorController : Controller
    {
        ApplicationDbContext context;
        public DistributorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public IActionResult Index()
        {
            return View(context.Distributors);
        }
    }
}
