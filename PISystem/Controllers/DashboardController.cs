using Microsoft.AspNetCore.Mvc;

namespace PISystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
