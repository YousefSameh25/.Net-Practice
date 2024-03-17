using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class ProductController : Controller
    {

        #region First Part
        /*
         
         
         //Actions can not be 
         //1- private 
         //2- static
         //3- overloaded except one case.
        

        // When we write at the browser Product/ShowMsg
        // The CLR will create an object from ProductController class and call ShowMsg action (dependency injection).
        public string ShowMsg()
        {
            return "Hello From First Action";
        }

        
         //Types of returned value from an action
         //1- Content "String" ==> ContentResult
         //2- View "HTML"  ==> ViewResult
         //3- JS ==> JavascriptResult
         //4- Json ==> JsonResult
         //5- NotFound ==> NotFoundResult
         //6- File ==> FileResult
         

        public ContentResult ShowMsg2()
        {
            // Declare object
            ContentResult CR = new ContentResult();
            // Set the data
            CR.Content = "Hello from ShowMsg2";
            // return the result
            return CR;
        }

        public ViewResult ShowView()
        {
            // Declare object
            ViewResult VR = new ViewResult();
            // Set the data
            VR.ViewName = "View1";
            // return the result
            //return VR;

            // Or (To reduce the lines of code) 
            return base.View("View1");
            // The View function is inherited from Controller class.
            // is virtual to enable the modifications on it.
        }

        //public override ViewResult View()
        //{
        //    return base.View();
        //}

        public JsonResult ShowJson()
        {
            JsonResult JR = new JsonResult(
                new List<dynamic> {
                new {
                    ID = 1,
                    Name = "Yousef Sameh"
                },
                new {
                    ID = 2,
                    Name = "Moumen Sameh"
                },
            });
            return JR;

            // Or (To reduce the lines of code) 
            // return Json(new {...});
            // The Json function is inherited from Controller class.
        }

        
         //Passing parameters:
         //1- Product/ShowMix/10 [segment]
         //2- Product/ShowMix?id=10&age=22 [Query String]
         

        // Why we used IActionResult not ActionResult?
        // dependency inversion principle (SOLID)
        // Rely on interface is better, why?
        // As if i rely on abstract class then the subclasses must inherit from it so what if a subclass has already a parent class!
        public IActionResult ShowMix(int id, int age)
        {
            // What if the action will return different types of result?
            // So return the interface type
            if ((id & 1) == 1) // Is odd
                return Content("Show Mix");

            return new JsonResult(new { Id = id, Age = age });
        }
         
         
         */
        #endregion

        public IActionResult GetProductDetails(int id)
        {
            ProductsSampleData PSD = new ProductsSampleData();
            // Passing the view name and the model
            return View("ProductDetails", PSD.GetById(id));
        }

        public IActionResult GetAllProducts()
        {
            ProductsSampleData PSD = new ProductsSampleData();
            // Passing the view name and the model
            return View("AllProducts", PSD.GetAll());
        }

    }
}
