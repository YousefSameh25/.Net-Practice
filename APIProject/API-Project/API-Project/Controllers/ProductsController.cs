using API_Project.DTOs;
using API_Project.Errors;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entites;
using Talabat.Core.Repository;
using Talabat.Core.Specifications;

namespace API_Project.Controllers
{
    public class ProductsController : ApiBaseController
    {
        private readonly IGenericRepository<Product> ProductRepo;
        private readonly IMapper mapper;

        public ProductsController(IGenericRepository<Product> ProductRepo, IMapper mapper)
        {
            this.ProductRepo = ProductRepo;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var Spec = new ProductSpecification();

            var Products = await ProductRepo.GetAllWithSpecAsync(Spec);

            var MappedProducts = mapper.Map<IEnumerable<Product>, IEnumerable<ProductToReturnDTO>>(Products);

            return Ok(MappedProducts);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProductById(int Id)
        {
            var Spec = new ProductSpecification(Id);

            var product = await ProductRepo.GetByIdWithSpecAsync(Spec);

            if (product is null)
                return NotFound(new ApiResponse(404));

            var MappedProduct = mapper.Map<Product, ProductToReturnDTO>(product);

            return Ok(MappedProduct);
        }

    }
}
