
using Microsoft.AspNetCore.Mvc;

namespace Symphony.Controllers
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