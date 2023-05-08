using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Models
{
    public class Distributor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required(ErrorMessage = "Not found Name")]
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public int Arrears { get; set; }
        public string Notes { get; set; }
    }
}
