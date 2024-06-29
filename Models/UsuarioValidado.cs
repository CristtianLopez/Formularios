using System;
using System.ComponentModel.DataAnnotations;
namespace Formularios.Models
{
    public class UsuarioValidado
    {

        public int Id { get; set; }
         
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El país es obligatorio.")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [ValidaFecha]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(500, ErrorMessage = "Los comentarios no pueden exceder los 500 caracteres.")]
        public string? Comentarios { get; set; }

        [Required(ErrorMessage = "Debe aceptar los términos.")]
        public bool AceptoTerminos { get; set; }

        //public static ValidationResult ValidarFechaNacimiento(DateTime fechaNacimiento, ValidationContext context)
        //{
        //    if (fechaNacimiento > DateTime.Now)
        //    {
        //        return new ValidationResult("La fecha de nacimiento no puede ser en el futuro.");
        //    }

        //    if (fechaNacimiento < DateTime.Now.AddYears(-120))
        //    {
        //        return new ValidationResult("La fecha de nacimiento no puede ser mayor a 120 años.");
        //    }

        //    return ValidationResult.Success;
        //}

    }

    public class ValidaFecha : ValidationAttribute
    {
        protected override ValidationResult IsValid(UsuarioValidado, ValidationContext validationContext)
        {
            UsuarioValidado person = (UsuarioValidado)validationContext.ObjectInstance;

            if (person.FechaNacimiento > DateTime.Now)
            {
                return new ValidationResult("La fecha de nacimiento no puede ser en el futuro.");
            }
            return ValidationResult.Success;
        }
    }
}
