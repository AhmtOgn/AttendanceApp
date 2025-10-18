using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            var students = Repository.GetStudents();  

            return View(students);
        }






    }
}