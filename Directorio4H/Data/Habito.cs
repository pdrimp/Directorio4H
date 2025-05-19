using System.ComponentModel.DataAnnotations;

namespace Directorio4H.Data
{
    public class Habito
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string? Nombre { get; set; }
        public ICollection<Persona>? Personas { get; set; }
    }
}
