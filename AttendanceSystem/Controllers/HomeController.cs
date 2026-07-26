using Microsoft.AspNetCore.Mvc;
using AttendanceSystem.Models;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
      
        private static List<Attendance> _attendanceList = new List<Attendance>
        {
            new Attendance { StudentId = "1001", Name = "Juan Dela Cruz", Course = "BSIT", Status = "Present" },
            new Attendance { StudentId = "1002", Name = "Maria Santos", Course = "BSCS", Status = "Late" },
            new Attendance { StudentId = "1003", Name = "Peter Cruz", Course = "BSIT", Status = "Absent" }
        };

        
        [HttpGet]
        public IActionResult Attendance()
        {
            return View(_attendanceList);
        }

        
        [HttpPost]
        public IActionResult AddAttendance(Attendance model)
        {
            if (ModelState.IsValid)
            {
                _attendanceList.Add(model);
            }
            return RedirectToAction("Attendance");
        }

        public IActionResult Index() => View();
        public IActionResult About() => View();
    }
}