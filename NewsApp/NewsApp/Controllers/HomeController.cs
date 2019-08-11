using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private PostRepository postRepo;
        private UnitOfWork unitOfWork;
        public HomeController(NewsContext context)
        {
            this.postRepo = new PostRepository(context);
            this.unitOfWork = new UnitOfWork(context);
        }
        public IActionResult Index()
        {
            List<Post> posts = unitOfWork.PostRepository.GetAll();
            return View(posts);
        }
        [Route("post/{slug}-{id:int}")]
        public ViewResult ViewPost(int id)
        {
            return View(unitOfWork.PostRepository.FindByID(id));
        }

        public IActionResult Privacy([FromServices] NewsContext news)
        {
            return View(news.Posts.First());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
