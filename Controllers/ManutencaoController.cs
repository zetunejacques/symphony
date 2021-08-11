
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("v2/depara/manutencao/exames")]
    public class ManutencaoController : ControllerBase
    {
        [HttpPost]
        [Route("pre-configurados")]
        [Authorize(Roles = "lc")]
        public string Post()
        {
            return "POST";
        }
        [HttpDelete]
        [Route("exame")]
        [Authorize(Roles = "lc")]
        public string Delete()
        {
            return "GET";
        }
    }
}