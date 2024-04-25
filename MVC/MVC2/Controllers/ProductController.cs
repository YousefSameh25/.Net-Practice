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



        // We can bind data from actions to view (C# -> View) using some ways:
        // 1 - Model (dynamic).
        // 2 - ViewData (Dictionary <string, object?>).
        // 3 - ViewBag (Dynamic ViewData)
        // 4 - ViewModel (Mix of some models).

        // Look at this action for all details:
        public IActionResult GetProductDetails(int id)
        {

            ProductsSampleData PSD = new ProductsSampleData();

            // ProductController inherits ViewData from Controller Class.
            // View inherits ViewData from RazorPage.
            // When we call the view the compiler takes a clone from VD in controller to VD in View.
            // Is used to send extra information.
            // key -> string, Value -> object.
            ViewData["Message"] = "Data from ViewData";


            // ViewBag is a dynamic ViewData.
            // Contains a ViewData inside it.
            // It is not a new property, it just read and write in ViewData property.
            // You can see this when we write here in ViewData and read from ViewBag in the view.
            ViewBag.Message = "Data from ViewBag";

            // ViewModel
            // Is to create a temporary class which will include a data not represented in database,
            // Ex) Department, Employee.
            // It is a best practice to make all ViewModels in a separated project.
            // Now I realize the difference between model in MVC and model in DataAccessLayer.


            // Passing the view name and the model
            // When we create a view, compiler does the following:
            // Create a class which inherits from RazorPage<T> class which has T Model as a property.
            // So I have to determine the T when I create a view? No, as by default Microsoft made T = dynamic.
            // And I can only specify the type of T in view using "@model List<int>".
            return View("ProductDetails", PSD.GetById(id)); // Passing model to the view.
        }

        public IActionResult GetAllProducts()
        {
            ProductsSampleData PSD = new ProductsSampleData();
            // Passing the view name and the model
            return View("AllProducts", PSD.GetAll());
        }




    }
}
