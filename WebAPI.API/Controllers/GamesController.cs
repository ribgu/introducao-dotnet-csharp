using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.API.Entities;
using WebAPI.API.Persistence;

namespace WebAPI.API.Controllers
{
    [Route("api/[games]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        public GamesController(GamesDbContext context) 
        { 
        }
        [HttpGet]
        public IActionResult GetAll() 
        { 
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        { 
        }

        [HttpPost]
        public IActionResult Post(Game game) 
        { 
        }

        [HttpPut("{id}")]
        public IActionResult Update(Game game) 
        { 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Game game)
        {
        }
    }
}
