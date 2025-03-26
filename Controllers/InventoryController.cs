using Microsoft.AspNetCore.Mvc;
using ITDashboard.Models.Inventory;

namespace ITDashboard.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            // Replace with your actual data retrieval logic
            var items = new List<Item>
            {
                new Item { Id = 1, Name = "لابتوب", Description = "لابتوب HP", Quantity = 10, PurchasePrice = 1200, VendorName = "HP" },
                new Item { Id = 2, Name = "شاشة", Description = "شاشة سامسونج", Quantity = 20, PurchasePrice = 250, VendorName = "Samsung" }
            };
            return View(items);
        }
    }
}