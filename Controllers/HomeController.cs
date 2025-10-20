using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        //cd /d/repos/'semester 3'/'web application'/HW1-AttendanceApp
        public IActionResult Index()
        {
            ViewBag.CourseCode = "SWE 203";
            ViewBag.CourseName = "Web Programming";
            ViewBag.CurrentDate = DateTime.Now.ToString("dd.MM.yyyy");


            var attendantStudents = Repository.GetAttendantStudents();
            int attendantCount = attendantStudents.Count();
            ViewBag.AttendantStudentCount = attendantCount;

            return View(attendantStudents);
        }    
    }
}