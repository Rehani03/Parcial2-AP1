using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.Entidades
{
    public class DetalleVenta
    {
        [Key]
        public int DetalleVentaID { get; set; }
        public int VentaID { get; set; }
        public string ServicioCombo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public DetalleVenta()
        {
            DetalleVentaID = 0;
            VentaID = 0;
            ServicioCombo = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public DetalleVenta(int detalleVentaID, int ventaID, string servicioCombo, int cantidad, decimal precio, decimal importe)
        {
            DetalleVentaID = detalleVentaID;
            VentaID = ventaID;
            ServicioCombo = servicioCombo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
