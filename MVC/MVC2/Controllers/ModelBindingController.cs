using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    [AllowAnonymous]
    public class ModelBindingController : Controller
    {
        /*
         Model Binding:
         1 - Segment. 
         2 - Query string.
         3 - Form tag.
         */

        [HttpGet]
        public IActionResult ReadStringUsingFormTag()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        /*
         ValidateAntiForgeryToken:
                Is responsible for check if the action is being called from external view not internal view.
         How is it working?
                MVC's anti-forgery support writes a unique value to an HTTP-only cookie 
                and then the same value is written to the form. When the page is submitted, 
                an error is raised if the cookie value doesn't match the form value.
         */
        public IActionResult ReadStringUsingFormTag(string Name)
        {
            // This way was used in the past.
            string Name2 = Request.Form["Name"]; // Will hold the data sent from input tag.

            // But now the model binder will bind the values for us.
            return Content(Name);
        }

        public IActionResult TestCustomBind([Bind(include: "ID,Name")] Product p)
        {
            return Content("Custom binding");
        }


    }
}
