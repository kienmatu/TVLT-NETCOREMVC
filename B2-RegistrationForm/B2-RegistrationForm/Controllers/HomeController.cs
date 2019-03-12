using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B2_RegistrationForm.Models;
using B2RegistrationForm.Models;

namespace B2_RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult /*ViewResult*/ Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Kiendinh = "Tôi là Kiên Đinh";
            ViewBag.Greeting = Hour < 12 ? "Chao buoi sang !" : "Chao buoi chieu";
            return View("myView");
        }
        public string Index2()
        {
            return "INDEX2 IS ME !";
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else
            {
                return View();
            }
        }
        public IActionResult StudentList()
        {
            return View(Repository.GetStudents());
        }


    }
}
