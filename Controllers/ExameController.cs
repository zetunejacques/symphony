using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Symphony.Models;

namespace Symphony.Controllers
{
    [Route("v1/exame")]
    public class ExameController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Exame exame)
        {
            var validator = new ExameValidator();
            var result = await validator.ValidateAsync(exame);
            if (!result.IsValid)
            {
                var mensagem = new List<SymphonyError>();
                foreach (var erro in result.Errors)
                {
                    mensagem.Add(new SymphonyError
                    {
                        Propriedade = erro.PropertyName,
                        Mensagem = erro.ErrorMessage
                    });
                }
                return BadRequest(mensagem);
            }
            return Ok(exame);
        }
    }
    public class SymphonyError
    {
        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
    }
}