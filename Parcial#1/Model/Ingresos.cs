﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial_1.Model
{
    public class Ingresos
    {
        [Key]
        public int IngresoId { get; set; }

        [Required(ErrorMessage = "Debe Contener una Fecha")]
        public String? Fecha { get; set; }

        [Required(ErrorMessage = " Debe Contener un Concepto")]
        public String? Concepto { get; set; }

        [Required(ErrorMessage = " Debe Contener un Monto")]
        public String? Monto { get; set; }
    }
}
