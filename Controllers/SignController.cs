using Microsoft.AspNetCore.Mvc;
using Homework1.Models;
using System;

namespace Homework1.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Sign()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sign(string studentId)
        {
            if (string.IsNullOrEmpty(studentId))
            {
                ViewBag.Error = "Student ID cannot be empty!";
                return View();
            }

            var student = Repository.GetStudents().FirstOrDefault(s => s.StudentID.Equals(studentId, StringComparison.OrdinalIgnoreCase));

            if (student == null)
            {
                ViewBag.Error = $"Student ID '{studentId}' not found!";
                
            }
            else
            {
                ViewBag.Error = $"Student '{student.Name}' '{student.Surname}' already signed at '{student.SignedAt}!'";
            }

            bool isSuccess = Repository.Sign(studentId);


            if (isSuccess)
            {
                TempData["SuccessMessage"] = $"Student {student.Name} {student.Surname} whose Id is {studentId} succesfully signed.";
                return RedirectToAction("SignedMessage");
            }
                return View();
        }

        public IActionResult SignedMessage()
        {
            var attendantStudents = Repository.GetAttendantStudents();
            var attendantCount = attendantStudents.Count();
            ViewBag.AttendantCount = attendantCount;
            
            var Message = TempData["SuccessdMessage"] as string;    
            return View(Message);
        }
        
    }
}