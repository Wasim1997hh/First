using Microsoft.AspNetCore.Mvc;
using OOPTest.Dtos;
using OOPTest.Service;

namespace OOPTest.Controllers
{
    public class TestController : Controller
    {
        [HttpPost]
        public IActionResult Sum([FromBody]SumDto dto)
        {
            var math = new MathService();
            var response = new APIResponseDto();
            response.Status = true;
            response.Message = "Hello";
            response.Data = math.Sum(dto.Number1, dto.Number2);



            return Ok(response);
        }
    }
}
