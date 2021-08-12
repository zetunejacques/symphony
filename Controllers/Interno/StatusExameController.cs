using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Symphony.Controllers.Interno
{
    [Route("interno/v2/statusexame")]
    public class StatusExameController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        //[Authorize(Roles = "admin")]
        public string Get()
        {
            // obter a lista de status exame
            return "Admin";
        }
        [HttpGet]
        [Route("{id:int}")]
        //[Authorize(Roles = "admin")]
        public string Get(int id)
        {
            // obtem o registro de um determinado status exame
            return $"GET {id}";
        }
    }
}