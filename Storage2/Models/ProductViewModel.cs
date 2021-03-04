using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage2.Models
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Price { get; set; }

        [Required]
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
