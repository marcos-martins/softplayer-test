namespace Softplayer.Calculadora.Servicos
{
    public interface ICalculadoraServico 
    {
         decimal CalcularJurosCompostos(decimal capital, double taxa, int tempo);
    }
}