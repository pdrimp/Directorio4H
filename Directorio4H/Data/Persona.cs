using System.ComponentModel.DataAnnotations;

namespace Directorio4H.Data
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        [Length(10, 10, ErrorMessage = "El teléfono de contener 10 dígitos")]
        public string? Telefono { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "La clasificación es obligatoria")]
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
    }
}
