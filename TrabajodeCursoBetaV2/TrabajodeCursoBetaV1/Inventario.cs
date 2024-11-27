using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabajodeCursoBetaV2
{
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }


        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        
        public void AgregarProducto(Producto producto)
        {
            if (productos.Any(p => p.Codigo == producto.Codigo))
            {
                throw new InvalidOperationException("El código del producto ya existe.");
            }
            productos.Add(producto);
        }

        
        public void EditarProducto(string codigo, Producto productoActualizado)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto == null)
            {
                throw new KeyNotFoundException("Producto no encontrado.");
            }

            producto.Nombre = productoActualizado.Nombre;
            producto.Descripcion = productoActualizado.Descripcion;
            producto.Precio = productoActualizado.Precio;
            producto.Stock = productoActualizado.Stock;
        }

        
        public void EliminarProducto(string codigo)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                productos.Remove(producto);
            }
            else
            {
                throw new KeyNotFoundException("Producto no encontrado.");
            }
        }

        
        public List<Producto> BuscarProductos(string criterio, bool buscarPorCodigo)
        {
            return buscarPorCodigo
                ? productos.Where(p => p.Codigo.Contains(criterio)).ToList()
                : productos.Where(p => p.Nombre.Contains(criterio)).ToList();
        }
    }
}
