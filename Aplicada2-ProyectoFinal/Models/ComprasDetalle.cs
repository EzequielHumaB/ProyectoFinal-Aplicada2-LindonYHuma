﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2_ProyectoFinal.Models
{
    public class ComprasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal SubTotal { get; set; }

        public ComprasDetalle()
        {
            Id = 0;
            CompraId = 0;
            Nombre = string.Empty;
            ProductoId = 0;
            Cantidad = 0;
            PrecioCompra = 0;
            SubTotal = 0;
        }
    }
}
