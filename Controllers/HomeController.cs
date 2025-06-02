using Microsoft.AspNetCore.Mvc;

namespace VideoCallApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}