using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Order has been loaded.");
        }
        [HttpGet]
        public IActionResult Get(int id) 
        {
            return Ok(id);
        }
        [HttpPost]
        public IActionResult Add(string name)
        {
            return Ok("Order has been created "+name);
        }
    }
}
