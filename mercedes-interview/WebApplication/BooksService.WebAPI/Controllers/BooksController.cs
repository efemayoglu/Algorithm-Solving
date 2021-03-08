using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BooksService.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BooksService.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BooksController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Validate(Book book)
        {
            if(ModelState.IsValid)
            {
                return Ok(JsonConvert.SerializeObject(book));

            }
            return BadRequest();
        }
        [HttpPost("/books")]
        public async Task<IActionResult> books(Book book)
        {
            if (ModelState.IsValid)
            {
                return Ok(JsonConvert.SerializeObject(book));

            }
            var a = ModelState.Values.FirstOrDefault();
            return Ok();
        }


        
    }
}
