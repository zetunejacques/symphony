
using Microsoft.AspNetCore.Mvc;

namespace Symphony.Controllers
{
    [Route("v1/ping")]
    public class HealthCheckController : ControllerBase
    {
        [Route("")]
        public string MeuMetodo()
        {
            return "Olá Mundo!";
        }
    }
}