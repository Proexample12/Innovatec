using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inovatec.Modelos
{
    public class ArbolJerarquico
    {
        public NodoJerarquico Raiz { get; set; }

        public ArbolJerarquico(string nombreRaiz)
        {
            Raiz = new NodoJerarquico(nombreRaiz);
        }

        public NodoJerarquico Buscar(NodoJerarquico nodo, string nombre)
        {
            if (nodo == null) return null;

            if (nodo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                return nodo;

            foreach (var hijo in nodo.Hijos)
            {
                var encontrado = Buscar(hijo, nombre);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        public bool Insertar(string nombrePadre, string nombreHijo)
        {
            if (string.IsNullOrWhiteSpace(nombrePadre) || string.IsNullOrWhiteSpace(nombreHijo))
                return false;

            var nodoPadre = Buscar(Raiz, nombrePadre);
            if (nodoPadre == null) return false;

            // Evitar duplicados directos (opcional)
            foreach (var h in nodoPadre.Hijos)
            {
                if (string.Equals(h.Nombre, nombreHijo, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            var nuevo = new NodoJerarquico(nombreHijo);
            nuevo.Padre = nodoPadre;        // asignar padre
            nodoPadre.Hijos.Add(nuevo);
            return true;
        }

        // ObtenerTodos: llena una lista con todos los nombres del subárbol (preorden)
        public void ObtenerTodos(NodoJerarquico nodo, List<string> lista)
        {
            if (nodo == null) return;
            lista.Add(nodo.Nombre);
            foreach (var h in nodo.Hijos)
                ObtenerTodos(h, lista);
        }

        // EliminarNodo: elimina el nodo cuyo nombre coincide (borra el subárbol)
        // Devuelve true si se eliminó (eliminación del hijo en su lista del padre)
        public bool EliminarNodo(NodoJerarquico nodoActual, string nombreAEliminar)
        {
            if (nodoActual == null || string.IsNullOrWhiteSpace(nombreAEliminar)) return false;

            for (int i = 0; i < nodoActual.Hijos.Count; i++)
            {
                var hijo = nodoActual.Hijos[i];
                if (string.Equals(hijo.Nombre, nombreAEliminar, StringComparison.OrdinalIgnoreCase))
                {
                    // remover y listo (todo el subárbol del hijo se pierde)
                    nodoActual.Hijos.RemoveAt(i);
                    return true;
                }

                if (EliminarNodo(hijo, nombreAEliminar))
                    return true;
            }

            return false;
        }

    }
}
