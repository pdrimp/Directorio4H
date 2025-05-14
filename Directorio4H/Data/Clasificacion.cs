using System.ComponentModel.DataAnnotations;

namespace Directorio4H.Data
{
    public class Clasificacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? Nombre { get; set; }

        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
