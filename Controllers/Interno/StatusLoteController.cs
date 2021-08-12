using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers.Interno
{
    [Route("interno/v2/statuslote")]
    public class StatusLoteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [Authorize(Roles = "admin")]
        public string Get()
        {
            // obter a lista de status lote
            return "Admin";
        }
        [HttpGet]
        [Route("{int:id}")]
        [Authorize(Roles = "admin")]
        public string Get(int id)
        {
            // obtem o registro de um determinado status
            return "Admin";
        }
    }
}