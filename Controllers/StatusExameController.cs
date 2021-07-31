
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Symphony.Models;

namespace Symphony.Controllers
{
    [Route("statusexames")]
    public class StatusExameController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<StatusExame>>> Get()
        {
            return new List<StatusExame>();
        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<StatusExame>> GetById(int id)
        {
            return new StatusExame();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<StatusExame>> Post([FromBody] StatusExame model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<StatusExame>> Put(int id, [FromBody] StatusExame model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model.Id != id)
                return NotFound(new { message = "StatusExame não encontrado" });

            return Ok(model);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}