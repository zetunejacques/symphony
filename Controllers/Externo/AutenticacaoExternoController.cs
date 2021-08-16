
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("v2/depara/autenticacao")]
    public class AutenticacaoExternoController : ControllerBase
    {

        [Route("software-house")]
        [AllowAnonymous]
        public string LoginSoftwareHouse()
        {
            // autentica a sh e retorna um token
            return "Admin";
        }

        [Route("laboratorio-conveniado")]
        [Authorize(Roles = "admin")]
        public string ObtemTokenLc([FromQuery] int codigoLC)
        {
            // retorna um token para um LC
            return "Admin";
        }

    }
}