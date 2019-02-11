using System;
using Softplayer.Calculadora.Repositorio;

namespace Softplayer.Calculadora.Servicos
{
    public class CalculadoraServico : ICalculadoraServico
    {
        private readonly ICalculoRepositorio _calculoRepositorio;
        public CalculadoraServico(ICalculoRepositorio calculoRepositorio)
        {
            _calculoRepositorio = calculoRepositorio;
        }
           
        /// <summary>
        /// Metodo responsavel por calcular juros compostos
        /// Valor Final = Valor Inicial * (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="capital">Capital inicial</param>
        /// <param name="tempo">Tempo</param>
        /// <returns>Montante</returns>
        public decimal CalcularJurosCompostos(decimal capital,int tempo)
        {   
            double taxa = _calculoRepositorio.ObterTaxa();
            decimal montante = capital *= (decimal)Math.Pow( 1 + taxa , tempo);
            return montante;
        }
    }
}