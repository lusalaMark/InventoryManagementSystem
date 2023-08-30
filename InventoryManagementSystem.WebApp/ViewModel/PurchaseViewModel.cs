using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.WebApp.ViewModel
{
    public class PurchaseViewModel
    {
        [Required]
        public string PONumber { get; set; } = string.Empty;
        [Required]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "You have To select an Inventory")]
        public int InventoryId { get; set; }
        [Required]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Qunantity has to be greater than 1")]
        public int QuantityToPurchase { get; set; }
        public double InventoryPrice { get; set; }
    }
}
