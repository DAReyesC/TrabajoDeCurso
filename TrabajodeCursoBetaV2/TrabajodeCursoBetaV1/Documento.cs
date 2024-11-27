using System;
using System.Collections.Generic;

namespace TrabajodeCursoBetaV1
{
    public abstract class Documento
    {
        public string Cliente { get; set; }
        public DateTime Fecha { get; protected set; } = DateTime.Now;

        public abstract decimal CalcularTotal(); // Método abstracto
    }
}
