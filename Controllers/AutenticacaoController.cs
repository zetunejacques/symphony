
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("v2/depara/autenticacao")]
    public class AutenticacaoController : ControllerBase
    {
        [HttpGet]
        [Route("admin")]
        [AllowAnonymous]
        public string LoginAdmin()
        {
            // autentica o admin e retorna um token
            return "Admin";
        }
        [Route("software-house")]
        [AllowAnonymous]
        public string LoginSoftwareHouse()
        {
            // autentica a sh e retorna um token
            return "Admin";
        }

        [Route("laboratorio-conveniado")]
        [Authorize(Roles = "admin")]
        public string ObtemTokenLc()
        {
            // retorna um token para um LC
            return "Admin";
        }

        [HttpGet]
        [Route("predicao")]
        [Authorize(Roles = "admin")]
        public string GetPredicao()
        {
            return "Olá Mundo!";
        }
        [HttpPut]
        [Route("predicao")]
        public string PutPredicao()
        {
            return "Olá Mundo!";
        }
        [HttpGet]
        [Route("mypardini")]
        public string GetMyPardini()
        {
            return "Olá Mundo!";
        }
        [HttpPut]
        [Route("mypardini")]
        public string PutMyPardini()
        {
            return "Olá Mundo!";
        }

    }
}