using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Shared.Models
{
    public class Vehiculo
    {
        [Key] 
        public int VehiculoId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El Monto es Requerido")]
        public float Costo { get; set; }

        [Required(ErrorMessage = "El Monto es Requerido")]
        public float Gasto { get; set; }

        [ForeignKey("VehiculoId")]
        public ICollection<Vehiculos_Detalle> Detalle { get; set; } = new List<Vehiculos_Detalle>();




    }
}
