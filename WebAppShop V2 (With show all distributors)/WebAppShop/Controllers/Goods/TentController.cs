﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Controllers.Goods
{
    public class TentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
