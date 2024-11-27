namespace TrabajodeCursoBetaV1
{
    public interface IArchivo
    {
        void GuardarEnArchivo(string ruta, List<Producto> productos);
        List<Producto> CargarDesdeArchivo(string ruta);
    }
}
