using System.ComponentModel.DataAnnotations;

namespace Softplayer.Calculadora.Model
{
    public class QueryCalculoJuros
    {
        [Required(ErrorMessage="Valor inicial obrigatorio.")]
        public decimal valorinicial {get;set;}
        [Required(ErrorMessage="Meses obrigatorio.")]
        public int meses {get;set;}

    }
}