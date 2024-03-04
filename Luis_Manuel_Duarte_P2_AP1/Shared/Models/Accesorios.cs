﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
