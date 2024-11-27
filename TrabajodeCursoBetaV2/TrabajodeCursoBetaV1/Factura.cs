using System.Collections.Generic;
using System.Linq;

namespace TrabajodeCursoBetaV1
{
    public class Factura : Documento
    {
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

        public override decimal CalcularTotal() => Detalles.Sum(d => d.Total);

        public decimal Subtotal => CalcularTotal();
        public decimal IVA => Subtotal * 0.16m;
        public decimal Total => Subtotal + IVA;
    }
}
