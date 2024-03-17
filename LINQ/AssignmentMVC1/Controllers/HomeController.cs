using AssignmentMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssignmentMVC1.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult GetMovie(int id, Employee employee)
        //{
        //    return Content($"Id is {id}, Name = {employee.Name}");
        //}

        //public IActionResult Index()
        //{
        //    return new ContentResult
        //    {
        //        Content = "Hello from index",
        //        ContentType = "text/html"
        //    };
        //}

        //public IActionResult Test()
        //{
        //    //return new RedirectResult("http://localhost:13801/Home/Index");
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
