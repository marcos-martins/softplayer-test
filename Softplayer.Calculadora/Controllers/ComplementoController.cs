using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Softplayer.Calculadora.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class ComplementoController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ComplementoController(IConfiguration config)
        {
            _config = config;
        }
       

        /// <summary>
        /// Retornar o caminho de onde se encontra o codigo
        /// </summary> 
        /// <returns>Caminho</returns>
        [HttpGet, ActionName("showmethecode")]
        public ActionResult<string> Get()
        {  
            return _config["SourceCode"]; 
        }    
    }
}