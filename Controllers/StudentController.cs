using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            var studentsList = Repository.GetStudents();
            int totalStudentNumber = studentsList.Count();
            ViewBag.TotalStudentNumber = totalStudentNumber;

            return View(studentsList);
        }

        public IActionResult Details(string studentId)
        {
            var student = Repository.GetStudentById(studentId);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }   


       



    }
}