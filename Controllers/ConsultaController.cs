
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("v2/depara/consultas")]
    public class ConsultaController : ControllerBase
    {
        [HttpGet]
        [Route("historico/lotes/lotes-cadastrados")]
        [Authorize(Roles = "lc")]
        public string GetLotesCadastrados()
        {
            return "POST";
        }
        [HttpGet]
        [Route("historico/lotes/lote/exames-suspensos")]
        [Authorize(Roles = "lc")]
        public string GetExamesSuspensosPorLote()
        {
            return "POST";
        }
        [HttpGet]
        [Route("historico/exames/exames-cadastrados")]
        [Authorize(Roles = "lc")]
        public string GetExamesCadastrados()
        {
            return "POST";
        }
        [HttpGet]
        [Route("historico/exames/exames-suspensos")]
        [Authorize(Roles = "lc")]
        public string GetExamesSuspensos()
        {
            return "POST";
        }
        [HttpGet]
        [Route("consultas/status/lote")]
        [Authorize(Roles = "lc")]
        public string GetStatusLote()
        {
            return "POST";
        }
    }
}