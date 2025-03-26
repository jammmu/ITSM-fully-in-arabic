using Microsoft.AspNetCore.Mvc;
using ITDashboard.Models.Identity;

namespace ITDashboard.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            // Replace with your actual data retrieval logic
            var users = new List<User>
            {
                new User { Id = 1, UserName = "admin", Email = "admin@example.com", FullName = "Admin User", IsActive = true, Roles = "Admin" },
                new User { Id = 2, UserName = "user", Email = "user@example.com", FullName = "Regular User", IsActive = true, Roles = "User" }
            };
            return View(users);
        }
    }
}