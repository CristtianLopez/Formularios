namespace Formularios.Models
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Comentarios { get; set; }
        public bool AceptoTerminos { get; set; }
    }
}
