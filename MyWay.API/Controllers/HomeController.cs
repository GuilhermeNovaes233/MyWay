using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay.Domain;
using MyWay.Repository;

namespace MyWay.API.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public readonly MyWayContext _context;
        public HomeController(MyWayContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try{
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch(System.Exception){
                  return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Evento>> Get(int id)
        {
            return await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
