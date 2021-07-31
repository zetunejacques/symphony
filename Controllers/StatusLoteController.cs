using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Symphony.Data;
using Symphony.Models;

namespace Symphony.Controllers
{
    [Route("statuslotes")]
    public class StatusLoteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<StatusLote>>> GetActionResultAsync([FromServices] DataContext context)
        {
            try
            {
                var statusLotes = await context.StatusLote.AsNoTracking().ToListAsync();
                return Ok(statusLotes);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível listar os registros" });
            }
        }
    }
}
