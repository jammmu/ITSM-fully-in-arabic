using Microsoft.AspNetCore.Mvc;
using ITDashboard.Models.Ticket;

namespace ITDashboard.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            // Replace with your actual data retrieval logic
            var tickets = new List<Ticket>
            {
                new Ticket { Id = 1, Title = "مشكلة في الشبكة", Description = "لا يمكن الاتصال بالإنترنت", Priority = "عالية", Status = "مفتوحة", ReportedBy = "أحمد" },
                new Ticket { Id = 2, Title = "مشكلة في الطابعة", Description = "الطابعة لا تطبع", Priority = "متوسطة", Status = "قيد المعالجة", ReportedBy = "سارة" }
            };
            return View(tickets);
        }
    }
}