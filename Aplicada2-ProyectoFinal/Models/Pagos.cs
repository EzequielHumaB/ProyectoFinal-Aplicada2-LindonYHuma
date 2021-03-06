﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2_ProyectoFinal.Models
{
    public class Pagos
    {
        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int PagoId { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        public DateTime PagoFecha { get; set; }
        public decimal PagoTotal { get; set; }

        [ForeignKey("PagosId")]
        public virtual List<PagosDetalle> PagosDetalles { get; set; }

        public Pagos()
        {
            PagoId = 0;
            PagoFecha = DateTime.Now;
            PagoTotal = 0;

            PagosDetalles = new List<PagosDetalle>();
        }
    }
}
