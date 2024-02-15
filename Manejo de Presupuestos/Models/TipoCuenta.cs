using Manejo_de_Presupuestos.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Manejo_de_Presupuestos.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Por favor, introduce el nombre del tipo de cuenta." )]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        //[Required( ErrorMessage = "El ID del usuario es obligatorio." )]
        public int UsuarioId { get; set; }

        [Required( ErrorMessage = "Por favor, introduce un número de orden." )]
        public int Orden { get; set; }
    }
}
