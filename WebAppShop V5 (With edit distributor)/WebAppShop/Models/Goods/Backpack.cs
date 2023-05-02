using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Models.Goods
{
    public class Backpack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public int Size { get; set; }
        public int Mass { get; set; }
        public string Teg { get; set; }
        public string Description { get; set; }
        public int Distributor_Id { get; set; }
        public virtual Distributor Distributor { get; set; }
    }
}
