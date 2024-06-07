using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class RouteController : Controller
    {
        /*
         When a request sent from client to server as an URL:
         The Router middle ware extracts the action, controller from URL then match the data with data 
         at End Point middle ware then the End Point execute the route.


         "{controller=Home}/{action=Index}/{id?}"

         Route is consists of some segments Controller/Action/Parameters (3 segments).

         "controller", "action" are reserved words in URL.

        "{controller=Home}/{action=Index:int}/{id:int?}/{name:alpha}" -> specify the data type
        and when we send wrong parameters a not found page will be returned.

        There are some constrains for route.

        There are 3 ways to call an action:
        1) controller/action
        2) Custom route which is in main function.
        3) Route attribute (Highest priority) ignores the previous 2 ways.
         */

        [Route("Main/Home")]
        // We can use [HttpGet] with route -> [HttpGet("Main/Home")]
        public IActionResult Index()
        {
            // Look at main function.
            return Content("This action can be called from 3 different routes");
        }
    }
}
