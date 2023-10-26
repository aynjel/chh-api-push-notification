using chh_api_push_notification.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chh_api_push_notification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Chau Huynh", Age = 18 });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { Name = "Chau Huynh", Age = 18 });
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new { Message = "Delete success" });
        }
    }
}
