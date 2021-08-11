
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("v2/depara/recursos/tabelalhpv2")]
    public class Tabelalhpv2Controller : ControllerBase
    {
        [HttpGet]
        [Route("atualizados")]
        [Authorize(Roles = "lc,softwarehouse")]
        public string ObtemAtualizados()
        {
            return "POST";
        }
        [HttpGet]
        [Route("cadastrados")]
        [Authorize(Roles = "lc")]
        public string ObtemCadastrados()
        {
            return "POST";
        }
        [HttpGet]
        [Route("contratados")]
        [Authorize(Roles = "lc")]
        public string ObtemContratados()
        {
            return "POST";
        }
        [HttpGet]
        [Route("exame")]
        [Authorize(Roles = "lc,softwarehouse")]
        public string ObtemExame()
        {
            return "POST";
        }
    }
}