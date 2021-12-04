using APIMUSICA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancionesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CancionesController(ApplicationDBContext applicationDBContext)
        {
            _context = applicationDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Canciones>>> Get()
        {
            var response = await _context.Canciones.ToListAsync();
            if (response == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Canciones>> Get(int id)
        {
            var response = await _context.Canciones.FindAsync(id);
            if (response == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Canciones>> Post(Canciones cancion)
        {
            _context.Canciones.Add(cancion);
            await _context.SaveChangesAsync();
            return cancion;
        }
    }
}
