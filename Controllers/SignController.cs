using Microsoft.AspNetCore.Mvc;
using Homework1.Models;

namespace Homework1.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Sign()
        {
            
            return View();
        }
    }
}