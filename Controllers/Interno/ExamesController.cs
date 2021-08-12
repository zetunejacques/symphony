
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers
{
    [Route("interno/v2/depara")]
    public class ExamesController : ControllerBase
    {
        [HttpGet]
        [Route("exames/recebidos")]
        [Authorize(Roles = "admin")]
        public string GetExamesRecebidos()
        {
            // obter a lista de exames recebidos pelo Symphony 
            return "Admin";
        }
        [HttpPost]
        [Route("exames/predicao")]
        [Authorize(Roles = "admin")]
        public string PostExamesPredicao()
        {
            // recebe a lista de exames com suas respectivas predições
            return "Admin";
        }
    }
}