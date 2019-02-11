namespace Softplayer.Calculadora.Servicos
{
    public interface ICalculadoraServico 
    {
         decimal CalcularJurosCompostos(decimal capital, int tempo);
    }
}