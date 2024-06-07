using Microsoft.AspNetCore.Mvc;
using MVC2.Data;

namespace MVC2.Controllers
{
    public class AjaxController : Controller
    {
        /*
         Ajax -> Asynchronous JavaScript And XML.

         Ajax: JS + CSS + Dom + XMLHttpRequest.

         Normal scenario:
         - Send request and a HTML response will be retrieved.

         Ajax scenario:
        - Send XMLHttpRequest and a XML or Json file will be retrieved.
        - Dom will take the returned data and place it in HTML page.

        Why this feature is important?
        - As we can get some data without refreshing the page and that is more better for user experience.

        Note: Ajax may call an action that return view or partial view then parse it within the current HTML page.
         
         */

        public IActionResult GetDepartments()
        {
            StaticData staticData = new StaticData();
            return View(staticData.Departments);
        }

        public IActionResult GetEmployees(int deptId)
        {
            StaticData staticData = new StaticData();
            return Json(staticData.Employees.Where(E => E.Department.Id == deptId));
        }
    }
}
