using Microsoft.AspNetCore.Mvc;

namespace Bookly.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
