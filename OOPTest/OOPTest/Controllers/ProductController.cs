using Microsoft.AspNetCore.Mvc;
using OOPTest.Dtos;
using OOPTest.Service;

namespace OOPTest.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
       public IActionResult GetAll()
        {
            var productService = new ProductService();
            var result = new APIResponseDto()
            {
                Status = true,
                Message = "Hi",
                Data = productService.GetAll()

            };
  
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create([FromBody]CreateDto dto)
        {
            var productService = new ProductService();
            
            var result = new APIResponseDto()
            {
                Status = true,
                Message = "Hi",
                Data = productService.Create(dto.Name, dto.Price)

            };

            return Ok(result);


        }

    }
}
