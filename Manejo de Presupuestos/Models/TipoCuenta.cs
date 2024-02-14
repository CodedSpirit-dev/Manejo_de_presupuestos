using Manejo_de_Presupuestos.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Manejo_de_Presupuestos.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Por favor, introduce el nombre del tipo de cuenta." )]
        [StringLength( maximumLength: 30, MinimumLength = 3, ErrorMessage = "El nombre del tipo de cuenta debe tener entre 3 y 30 caracteres." )]
        [Display( Name = "Nombre del tipo de la cuenta a crear" )]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

        [Required( ErrorMessage = "El ID del usuario es obligatorio." )]
        public int UsuarioId { get; set; }

        [Required( ErrorMessage = "Por favor, introduce un número de orden." )]
        [Range( 1, int.MaxValue, ErrorMessage = "El número de orden debe ser un número positivo." )]
        public int Orden { get; set; }

        [Required( ErrorMessage = "Por favor, introduce un correo electrónico." )]
        [EmailAddress( ErrorMessage = "Por favor, introduce un correo electrónico válido." )]
        public string Email { get; set; }

        [Required( ErrorMessage = "Por favor, introduce tu edad." )]
        [Range( minimum: 18, maximum: 120, ErrorMessage = "La edad debe estar entre 18 y 120 años." )]
        public int Edad { get; set; }

        [Required( ErrorMessage = "Por favor, introduce una URL." )]
        [Url( ErrorMessage = "Por favor, introduce una URL válida." )]
        public string URL { get; set; }

        [CreditCard( ErrorMessage = "Por favor, introduce un número de tarjeta de crédito válido." )]
        [Display( Name = "Tarjeta de crédito" )]
        public string TarjetaDeCredito { get; set; }


    }
}
