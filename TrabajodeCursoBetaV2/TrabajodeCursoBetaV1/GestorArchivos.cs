using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TrabajodeCursoBetaV1
{
    public class GestorArchivos : IArchivo
    {
        public void GuardarEnArchivo(string ruta, List<Producto> productos)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine("Código,Nombre,Descripción,Precio,Stock");

                foreach (var producto in productos)
                {
                    contenido.AppendLine($"{producto.Codigo},{producto.Nombre},{producto.Descripcion},{producto.Precio},{producto.Stock}");
                }

                File.WriteAllText(ruta, contenido.ToString());
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al guardar en el archivo: {ex.Message}");
            }
        }

        public List<Producto> CargarDesdeArchivo(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    throw new FileNotFoundException("El archivo especificado no existe.");
                }

                var lineas = File.ReadAllLines(ruta);
                var productos = new List<Producto>();

                foreach (var linea in lineas.Skip(1)) // Saltar encabezado
                {
                    var datos = linea.Split(',');

                    if (datos.Length == 5)
                    {
                        productos.Add(new Producto
                        {
                            Codigo = datos[0].Trim(),
                            Nombre = datos[1].Trim(),
                            Descripcion = datos[2].Trim(),
                            Precio = decimal.Parse(datos[3].Trim()),
                            Stock = int.Parse(datos[4].Trim())
                        });
                    }
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new IOException($"Error al cargar desde el archivo: {ex.Message}");
            }
        }
    }
}
