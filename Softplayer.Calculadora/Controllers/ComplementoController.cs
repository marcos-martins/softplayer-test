using Microsoft.AspNetCore.Mvc;

namespace Softplayer.Calculadora.Controllers
{
    [Route("v1/[controller]/[action]")]
    public class ComplementoController : ControllerBase
    {
        /// <summary>
        /// Retornar o caminho de onde se encontra o codigo
        /// </summary> 
        /// <returns>Caminho</returns>
        [HttpGet, ActionName("showmethecode")]
        public ActionResult<string> Get()
        {  
            return "https://github.com/marcos-martins/softplayer-test"; 
        }    
    }
}