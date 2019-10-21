using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2_AP1.Entidades;

namespace Parcial2_AP1.Entidades
{
    public class Venta
    {
        [Key]
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public string Estudiante { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleVenta> Servicios { get; set; }

        public Venta()
        {
            VentaID = 0;
            Fecha = DateTime.Now;
            Estudiante = string.Empty;
            Total = 0;
            Servicios = new List<DetalleVenta>();

        }
    }
}
