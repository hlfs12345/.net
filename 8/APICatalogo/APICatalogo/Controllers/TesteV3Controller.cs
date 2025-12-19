using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/teste")]
    [ApiController]
    [ApiVersion("3")]
    [ApiVersion("4")]
    public class TesteV3Controller : ControllerBase
    {
        [MapToApiVersion(3)]
        [HttpGet]
        public String GetVersion3()
        {
            return "Teste V3 - GET - Api Versão 3.0";
        }

        [MapToApiVersion(4)]
        [HttpGet]
        public String GetVersion4()
        {
            return "Teste V4 - GET - Api Versão 4.0";
        }
    }
}
