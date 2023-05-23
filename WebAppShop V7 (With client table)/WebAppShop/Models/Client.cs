using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppShop.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required(ErrorMessage = "Not found Name")]
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

    }
}
