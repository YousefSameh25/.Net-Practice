using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class StateManagementController : Controller
    {
        // State management:
        /*
         When we send a request to the server:
         1 - The application use ControllerFactory to create an object from wanted controller.
         2 - Call wanted method, return result.
         3 - destroy the controller object.
         */


        /*
         Full process when a client sends a request to the server:

        1 - The server creates a session with sessionId between itself and the browser.
        2 - The sessionId will be kept in a cookie with the client browser.
        3 - To keep save some data from being destroyed we can use many ways:
             1 - Session.
             2 - Cookies.
             3 - Temp data.
             4 - Query string.
             5 - Hidden field.
             All this ways are used in state management as the HTTP protocol is stateless protocol.
          https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-8.0
         */

        /*
         State management types:
        **************** Temp data ****************:
        *
          - Is stored in a cookie with the browser by default but we can store it in session.
          - Inherited property from Controller class.
          - Dictionary <string, object?>.
          - The data inside temp data will be valid until be read or session ends.
        Ex:
         */
        public IActionResult SetTempData()
        {
            TempData["msg"] = "Hello from temp data!";
            return Content("Data saved!");
        }

        public IActionResult GetTempDataThenDelete()
        {
            string msg = TempData["msg"]?.ToString()!;
            return Content(msg);
        }

        public IActionResult GetTempData()
        {
            string msg = TempData.Peek("msg")?.ToString()!;
            return Content(msg);
        }

        /*
         *************** Session *************
         
        1 - Is a property in HttpContext.
        2 - Is stored in server side.
        3 - We must enable session in the pipeline.
         */

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Yousef");
            HttpContext.Session.SetInt32("Age", 22);

            return Content("Session data saved!");
        }

        public IActionResult GetSessionData()
        {
            string Data = $"{HttpContext.Session.GetString("Name")!} , {HttpContext.Session.GetInt32("Age")!}";
            return Content(Data);
        }

        /*
            *************** Cookies *************

        1 - Is a property in Response.
        2 - Is stored in client side.
        3 - The client stores the cookies inside the request which will be sent to the server.
        4 - Cookies time = session time by default.
        5 - Is used in remember me feature.
        */

        public IActionResult SetCookie()
        {
            Response.Cookies.Append("Name", "Yousef"); // Session cookie.
            Response.Cookies.Append("Age", "30"); // Session cookie.

            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddHours(1);
            
            Response.Cookies.Append("Title", ".Net developer", cookieOptions); // Persistent cookie.
            
            return Content("Cookie has been saved!");
            // What if we want to store an object not string?
            // We can use JsonConvert.SerializeObject(obj);
        }

        public IActionResult GetCookieData()
        {
            string Data = $"{Request.Cookies["Name"]!} , {Request.Cookies["Age"]!}";
            return Content(Data);
            // What if we want to read an object not string?
            // We can use JsonConvert.DeSerializeObject<MyType>(str);
        }
    }
}
