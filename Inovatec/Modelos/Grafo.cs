using System;
using System.Collections.Generic;
using System.Linq;

namespace Inovatec.Modelos
{
    public class Grafo
    {
        private readonly Dictionary<string, List<string>> adj;

        public Grafo()
        {
            adj = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        }

        public bool AgregarNodo(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            nombre = nombre.Trim();
            if (adj.ContainsKey(nombre)) return false;
            adj[nombre] = new List<string>();
            return true;
        }

        public bool Conectar(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return false;
            a = a.Trim(); b = b.Trim();
            if (string.Equals(a, b, StringComparison.OrdinalIgnoreCase)) return false;
            if (!adj.ContainsKey(a) || !adj.ContainsKey(b)) return false;

            if (!adj[a].Contains(b)) adj[a].Add(b);
            if (!adj[b].Contains(a)) adj[b].Add(a);
            return true;
        }

        // BFS para ruta mínima (por número de aristas). Devuelve null si no hay ruta.
        public List<string> EncontrarRutaBFS(string origen, string destino)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino)) return null;
            origen = origen.Trim(); destino = destino.Trim();
            if (!adj.ContainsKey(origen) || !adj.ContainsKey(destino)) return null;

            var padre = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var visitado = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var cola = new Queue<string>();
            cola.Enqueue(origen);
            visitado.Add(origen);
            padre[origen] = null;

            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();
                if (string.Equals(actual, destino, StringComparison.OrdinalIgnoreCase)) break;

                List<string> vecinos;
                if (!adj.TryGetValue(actual, out vecinos)) continue;

                foreach (var vecino in vecinos)
                {
                    if (visitado.Contains(vecino)) continue;
                    visitado.Add(vecino);
                    padre[vecino] = actual;
                    cola.Enqueue(vecino);
                }
            }

            if (!visitado.Contains(destino)) return null;

            var ruta = new List<string>();
            var cur = destino;
            while (cur != null)
            {
                ruta.Add(cur);
                cur = padre.ContainsKey(cur) ? padre[cur] : null;
            }
            ruta.Reverse();
            return ruta;
        }

        public bool EsConexo()
        {
            if (adj.Count == 0) return false;
            var inicio = adj.Keys.First();
            var visitado = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var cola = new Queue<string>();
            cola.Enqueue(inicio);
            visitado.Add(inicio);

            while (cola.Count > 0)
            {
                var n = cola.Dequeue();
                List<string> vecinos;
                if (!adj.TryGetValue(n, out vecinos)) continue;

                foreach (var v in vecinos)
                {
                    if (!visitado.Contains(v))
                    {
                        visitado.Add(v);
                        cola.Enqueue(v);
                    }
                }
            }

            return visitado.Count == adj.Count;
        }

        public IEnumerable<string> GetNodos() => adj.Keys.OrderBy(k => k);

        // Exponer adyacencias para mostrar en UI (referencia directa)
        public IDictionary<string, List<string>> ObtenerAdyacencias() => adj;
    }
}
