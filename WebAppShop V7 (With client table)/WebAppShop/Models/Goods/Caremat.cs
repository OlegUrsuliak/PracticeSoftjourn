﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Models.Goods
{
    public class Caremat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Mass { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public int? DistributorId { get; set; }
        [ForeignKey("DistributorId")]
        public virtual Distributor Distributor { get; set; }
    }
}
