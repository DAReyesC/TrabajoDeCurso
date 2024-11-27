namespace TrabajodeCursoBetaV1
{
    public class DetalleFactura
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total => Precio * Cantidad;
    }
}
