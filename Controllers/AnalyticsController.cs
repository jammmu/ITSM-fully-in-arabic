using Microsoft.AspNetCore.Mvc;
using ITDashboard.Models.Analytics;

namespace ITDashboard.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            // Replace with your actual data retrieval logic
            var reports = new List<Report>
            {
                new Report { Id = 1, Name = "تقرير المخزون", ReportType = "Inventory", CreatedDate = DateTime.Now },
                new Report { Id = 2, Name = "تقرير الأصول", ReportType = "Asset", CreatedDate = DateTime.Now }
            };
            return View(reports);
        }
    }
}