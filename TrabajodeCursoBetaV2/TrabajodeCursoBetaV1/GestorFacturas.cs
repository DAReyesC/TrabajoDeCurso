using System;
using System.IO;
using System.Windows.Forms;

namespace TrabajodeCursoBetaV1
{
    public class GestorFacturas : IGenerarDocumento
    {
        public void GenerarDocumento(Documento documento)
        {
            Factura factura = documento as Factura;
            if (factura != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt",
                    Title = "Guardar factura"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine($"Cliente: {factura.Cliente}");
                        writer.WriteLine($"Fecha: {factura.Fecha}");
                        writer.WriteLine("Detalles:");
                        foreach (var detalle in factura.Detalles)
                        {
                            writer.WriteLine($"{detalle.CodigoProducto}, {detalle.NombreProducto}, {detalle.Cantidad}, {detalle.Precio:C2}, {detalle.Total:C2}");
                        }
                        writer.WriteLine($"Subtotal: {factura.Subtotal:C2}");
                        writer.WriteLine($"IVA: {factura.IVA:C2}");
                        writer.WriteLine($"Total: {factura.Total:C2}");
                    }
                }
            }
        }
    }
}
