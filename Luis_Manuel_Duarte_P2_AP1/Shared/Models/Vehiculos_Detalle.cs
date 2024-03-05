using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Vehiculos_Detalle
    {
        [Key] 
        public int Id { get; set; }

        [ForeignKey("VehiculoId") ] 
        public int VehiculoId { get; set;}

        [ForeignKey("AccesorioId")]
        public int AccesorioId { get; set; }

        public int Valor { get; set; }

    }
}
