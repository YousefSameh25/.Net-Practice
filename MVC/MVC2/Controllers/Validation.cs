using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class Validation : Controller
    {
        /*   
             Validation Types:
             1 - Client Side.
             2 - Server Side.
             3 - SQL Server "Constraint"


             Validate Data can be such as:
             1 - Required. -> [required]
             2 - Data Type.
             3 - Unique.
             4 - Compare.
             5 - Check data found in DB.
             6 - Pattern (Regular Expression).
             7 - Range (1, 10).
             8 - Min & Max Length.

            Note that: We can use Regular Expression for all validation.


             what if I want to create a type of validation which is not exist?
             We can use custom validation.

         */

        [HttpPost]
        public IActionResult ServerSideValidation(Product p)
        {
            /*
             Data life cycle in terms of server side validation:
             
             1 - Data is sent from view and stored in a object model.
             2 - Controller has a property (StateModel) which is a dictionary
                which indicates if the stored data is valid or not according to model constrains.

             The validation annotations should be added to the ViewModel to validate user data.
             Or can be added to Model to configure the attributes in tables in data base.

            We can track the ModelState using Watch in debug mode and see what exactly attributes are invalid.
             */

            Console.WriteLine(ModelState.ErrorCount);

            if (ModelState.IsValid)
            {
                /*      
                 what if the model is valid but an error occurred with database while inserting it?
                 */
                try
                {
                    // insert into database
                    // save changes.
                    return Content("Valid Data");
                }
                catch (Exception ex)
                {
                    // The ModelState takes a key and a value
                    // in our case the error was not with any attribute in the model so we create a new key and assign 
                    // the value to it.
                    ModelState.AddModelError(string.Empty, ex.Message); // Add custom error.
                    /*
                     The stateModel will be returned to the view to display the error.

                     - If key is name of a property model: the error will be shown in "span".
                     - If key not found in property list of the model: the error will be shown in "dev".
                     */
                }
            }
            return Content("Not valid data");
        }

        /*
         Custom validation

        Is useful in 2 cases:
        1 - Not found as built-in attribute.
        2 - Validate based on DB.

        Two types of custom validation:
        1- Validate attribute -> is server side.
        2 - Remote -> can used in client side but it use server validation.

        Validate attribute is to create new class and inherit from 'ValidationAttribute'
        then override IsValid method which has 2 parameters.

        Important note: The custom validation is used as server side validation only, Why?
        as there is no attribute will match it in 'Jquery.unobtrustive' package.

        Remote is called using ajax "Text change".

        when we write 
        [Remote("Action", "Controller")] that means when text changed call the following action which accepts Salary as an parameter.
        public int Salary {get; set;} 
        - Remote can take additional parameter.
        - one of Remote cons is that is that when property depends on another property it may not work 
          if you fill the value of the property that another on depends on it
          ex) Salary -> departmentId
          If we fill the salary first then departmentId the salary may have wrong value.
         
        */

    }
}
