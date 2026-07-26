using Microsoft.AspNetCore.Mvc;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}