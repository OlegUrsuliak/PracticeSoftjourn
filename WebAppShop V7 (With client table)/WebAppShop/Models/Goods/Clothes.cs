using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Models.Goods
{
    public class Clothes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Size { get; set; }
        public string Teg { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int? DistributorId { get; set; }
        [ForeignKey("DistributorId")]
        public virtual Distributor Distributor { get; set; }
    }
}
