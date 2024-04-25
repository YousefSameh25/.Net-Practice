using API_Project.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Repository.Data;

namespace API_Project.Controllers
{
    [ApiController]
    public class BuggyController : ControllerBase
    {
        private readonly StoreContext storeContext;

        public BuggyController(StoreContext storeContext)
        {
            this.storeContext = storeContext;
        }

        [HttpGet("NotFound")]
        public IActionResult GetNotFoundRequest()
        {
            var product = storeContext.Products.Find(100);
            if (product is null)
                return NotFound(new ApiResponse(404));
            return Ok(product);
        }

        [HttpGet("ServerError")]
        public IActionResult GetServerError()
        {
            var product = storeContext.Products.Find(100);
            var productToReturn = product.ToString();

            return Ok(productToReturn);
        }

        [HttpGet("BadRequest/{id}")]
        public IActionResult GetBadRequest(int id)
        {
            return Ok();
        }
    }
}
