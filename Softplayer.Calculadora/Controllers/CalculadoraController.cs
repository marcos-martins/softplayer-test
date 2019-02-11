using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Softplayer.Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ActionName("calculajuros")]
        public ActionResult<IEnumerable<string>> CalcularJuros()
        {
            return new string[] { "value1", "value2" };
        }        
    }
}
