using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sess4.Models;

namespace Sess4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student objStudent = new Student();
            
            objStudent.StudentName = "KIÊN ĐINH KUTE";
            objStudent.StudentAge = 20;
            objStudent = null;

            return View(objStudent);
            //ctrl + click
        }
    }
}