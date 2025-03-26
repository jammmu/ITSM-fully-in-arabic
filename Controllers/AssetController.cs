using Microsoft.AspNetCore.Mvc;
using ITDashboard.Models.Asset;

namespace ITDashboard.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index()
        {
            // Replace with your actual data retrieval logic
            var assets = new List<Asset>
            {
                new Asset { Id = 1, Name = "لابتوب", Description = "لابتوب Dell", AssetTag = "DELL123", Location = "المكتب" },
                new Asset { Id = 2, Name = "شاشة", Description = "شاشة LG", AssetTag = "LG456", Location = "المكتب" }
            };
            return View(assets);
        }
    }
}