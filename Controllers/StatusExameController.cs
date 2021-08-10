
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Symphony.Data;
using Symphony.Models;

namespace Symphony.Controllers
{
    [Route("v1/interno/statusexames")]
    public class StatusExameController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<StatusExame>>> Get(
            [FromServices] DataContext context
        )
        {
            try
            {
                var statusExames = await context.StatusExame.AsNoTracking().ToListAsync();
                return Ok(statusExames);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível listar os registros" });
            }
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<StatusExame>> GetById(
            int id,
            [FromServices] DataContext context)
        {
            try
            {
                var statusExame = await context.StatusExame.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
                return Ok(statusExame);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível acessar o registro" });
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<StatusExame>> Post(
            [FromBody] StatusExame model,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                context.StatusExame.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível incluir o registro" });
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<StatusExame>> Put(
            int id,
            [FromBody] StatusExame model,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model.Id != id)
                return NotFound(new { message = "StatusExame não encontrado" });
            try
            {
                context.Entry<StatusExame>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Esse registro já foi atualizado" });
            }
            catch (System.Exception)
            {
                return BadRequest(new { message = "Não foi possível atualizar o registro" });
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> Delete(
            int id,
            [FromServices] DataContext context)
        {
            try
            {
                var statusExame = await context.StatusExame.FirstOrDefaultAsync(x => x.Id == id);
                if (statusExame == null)
                    return NotFound(new { message = "Registro não encontrado" });
                context.StatusExame.Remove(statusExame);
                await context.SaveChangesAsync();
                return Ok(new { message = "Registro removido com sucesso" });
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível excluir o registro" });
            }

        }
    }
}