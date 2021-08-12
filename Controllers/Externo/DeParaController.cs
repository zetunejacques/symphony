
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers.Externo
{
    [Route("v2/depara")]
    public class DeParaController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        [Authorize(Roles = "lc")]
        public string Post()
        {
            return "POST";
        }
        [HttpGet]
        [Route("")]
        [Authorize(Roles = "lc")]
        public string Get()
        {
            return "GET";
        }
    }
}