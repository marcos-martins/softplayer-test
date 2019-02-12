using System;

namespace Softplayer.Calculadora.Servicos
{
    public class CalculadoraServico : ICalculadoraServico
    {      
       
        /// <summary>
        /// Metodo responsavel por calcular juros compostos
        /// Valor Final = Valor Inicial * (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="capital">Capital inicial</param>
        /// <param name="taxa">Taxa</param>
        /// <param name="tempo">Tempo em meses</param>
        /// <returns>Montante</returns>
        public decimal CalcularJurosCompostos(decimal capital,double taxa, int tempo)
        {   
            decimal montante = capital *= (decimal)Math.Pow( 1 + taxa , tempo);
            return montante;
        }
    }
}