using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string InventoryName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quantity Must Be Greater than Zero")]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Price Must Be Greater than Zero")]
        public double Price { get; set; }
    }
}
