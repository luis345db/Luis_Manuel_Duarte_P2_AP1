
using System.ComponentModel.DataAnnotations;


namespace Shared.Models
{
    public class Accesorios
    {
        [Key] 
        public int AccesorioId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }

    }
}
