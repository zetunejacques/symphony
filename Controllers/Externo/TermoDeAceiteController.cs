
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers.Externo
{
    [Route("v2/depara/Termo-de-aceite")]
    public class TermoDeAceiteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [Authorize(Roles = "lc")]
        public string Get()
        {
            return "GET";
        }
    }
}