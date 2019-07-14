using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bai5_Razor.Models;

namespace Bai5_Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["loichao"] = "Xin chào các bạn mình là NET CORE";
            ViewBag.loichao2 = "Tớ là viewbag chào các bạn nhé hjhj";
            List<Student> lstStudents = new List<Student>();
            Random random = new Random();
            for(int i =0; i<40;i++)
            {

                Student student = new Student
                {
                    name = "Student of Kien số " + (i + 1),
                    age = random.Next(8, 20)
                };
                lstStudents.Add(student);
            }
            ViewData["std"] = lstStudents.FirstOrDefault();
            ViewBag.hocsinh = lstStudents.FirstOrDefault();
            return View(lstStudents);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
