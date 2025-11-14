using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inovatec.Modelos
{
    public class NodoJerarquico
    {
        public string Nombre { get; set; }

        public List<NodoJerarquico> Hijos { get; set; }

        public NodoJerarquico Padre { get; set; }

        public NodoJerarquico(string nombre)
        {
            Nombre = nombre?.Trim(); // normalizar eliminando espacios al inicio/fin
            Hijos = new List<NodoJerarquico>();
        }
    }
}
