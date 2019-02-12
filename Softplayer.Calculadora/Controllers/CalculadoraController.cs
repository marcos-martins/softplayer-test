using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Softplayer.Calculadora.Model;
using Softplayer.Calculadora.Servicos;

namespace Softplayer.Calculadora.Controllers
{
    [Route("v1/[controller]/[action]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadoraServico _calculadoraServico;
        public CalculadoraController(ICalculadoraServico calculadoraServico)
        {
            _calculadoraServico = calculadoraServico;
        }
       
        /// <summary>
        /// Calcula juros compostos
        /// </summary>
        /// <param name="queryCalculo"></param>
        /// <returns>Montante</returns>
        [HttpGet, ActionName("calculajuros")]
        public ActionResult<string> CalcularJuros([FromQuery] QueryCalculoJuros queryCalculo)
        {            
            if (ModelState.IsValid)
            {              
                decimal montante = _calculadoraServico.CalcularJurosCompostos(queryCalculo.valorinicial,queryCalculo.meses);
                return string.Format("{0:0.00}", montante);
            }

            return BadRequest(ModelState); 
        }        
    }
}
