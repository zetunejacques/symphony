
using Microsoft.AspNetCore.Mvc;

namespace Symphony.Controllers.Externo
{
    [Route("v2/depara/ping")]
    public class HealthCheckController : ControllerBase
    {
        [Route("")]
        public string MeuMetodo()
        {
            return "Olá Mundo!";
        }
    }
}