using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class ListController : Controller
    {
        public IActionResult List()
        {
            var students = Repository.GetStudents();  

            return View(students);
        }






    }
}