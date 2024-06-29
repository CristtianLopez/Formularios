using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
    public class UsuarioDisplay
    {
        public int Id { get; set; }

        [Display(Name = "Nombre completo", Description = "Nombre completo del usuario")]
        public string Nombre { get; set; }

        [Display(Name = "Correo electrónico", Description = "Dirección de correo electrónico")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Pais { get; set; }

        [Display(Name = "Fecha de nacimiento", Description = "Fecha de nacimiento del usuario")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Comentarios")]
        public string Comentarios { get; set; }

        [Display(Name = "Acepto los términos y condiciones")]
        public bool AceptoTerminos { get; set; }
    }
}
