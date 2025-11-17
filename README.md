Descripción General 
El sistema Innovatec resuelve el problema práctico de gestionar estructuras jerárquicas y conexiones espaciales en contextos empresariales. Por un lado, 
permite modelar organigramas corporativos donde cada empleado tiene un jefe directo y subordinados. Por otro, facilita la planificación de rutas entre 
edificios conectados, útil para logística o navegación interna. La aplicación ofrece una interfaz visual intuitiva para que usuarios no técnicos puedan 
manipular estas estructuras complejas sin necesidad de conocer algoritmos subyacentes.

Details
El sistema se inicia a través del punto de entrada principal [1a] que lanza el formulario menú Form1. Este menú presenta dos módulos independientes:

Módulo Árbol Jerárquico: Accesible mediante el menú [1b], implementa una estructura de árbol para organigramas empresariales con raíz fija "Innovatec". 
Utiliza recursividad para búsquedas y mantiene relaciones padre-hijo bidireccionales.

Módulo Sistema de Grafos: Accesible mediante [1c], gestiona conexiones entre edificios usando una lista de adyacencia. Implementa algoritmos de BFS para 
encontrar rutas óptimas y verifica la conexidad del grafo.

Ambos módulos siguen el patrón MVC con separación clara entre modelos de datos y vistas de usuario, permitiendo operaciones CRUD completas con validación de entrada y sincronización automática entre la estructura interna y la representación visual.
Sistema de Árbol Jerárquico: Gestión de jerarquías organizacionales (estructura empresarial) FrmArbol.cs:22
Sistema de Grafos: Visualización de redes de rutas entre edificios FrmGrafo.cs:18

Notas 
Ambos sistemas no tienen persistencia de datos; los datos se pierden al cerrar la aplicación.
El sistema de árbol previene la eliminación del nodo raíz. FrmArbol.cs:171-178
Las búsquedas son case-insensitive en ambos sistemas. ArbolJerarquico.cs:22 Grafo.cs:13
El grafo implementa conexiones no dirigidas (bidireccionales). Grafo.cs:32-33
