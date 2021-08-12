
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("interno/v2/depara")]
    public class LotesController : ControllerBase
    {
        [HttpGet]
        [Route("lote/exames/predicao")]
        [Authorize(Roles = "admin")]
        public string GetExamesPredicao()
        {
            // obter a lista de exames de um determinado lote com as respectivas predições
            return "Admin";
        }
        [HttpGet]
        [Route("lote/exames/auditados")]
        [Authorize(Roles = "admin")]
        public string GetExamesAuditados()
        {
            // obter a lista de exames auditados de um determinado lote
            return "Admin";
        }
        [HttpPost]
        [Route("lote/exames/auditados")]
        [Authorize(Roles = "admin")]
        public string PostExamesAuditados()
        {
            // recebe a lista de exames auditados de um determinado lote
            return "Admin";
        }
        [HttpPatch]
        [Route("lote/exames/informacoes-complementares")]
        [Authorize(Roles = "admin")]
        public string PatchInformacoesComplementares()
        {
            // recebe a lista de exames com informações complementares
            return "Admin";
        }
        [HttpGet]
        [Route("lotes/status")]
        [Authorize(Roles = "admin")]
        public string GetLotesPorStatus()
        {
            // obter a lista de lotes através do status fornecido
            return "Admin";
        }
    }
}