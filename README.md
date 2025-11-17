📝 README — Sistema de Gestión de Jerarquía Empresarial y Rutas del Parque (Árbol + Grafo)
📌 Descripción del Proyecto
Este proyecto implementa dos estructuras fundamentales de teoría de datos dentro de una aplicación Windows Forms en C#:

Árbol Jerárquico Empresarial
Permite gestionar cargos dentro de una organización mediante nodos padre–hijo.

Grafo de Rutas del Parque
Simula un sistema de edificios conectados mediante caminos con distancias (ponderaciones), permitiendo buscar rutas, verificar conexiones y visualizar adyacencias.

El programa fue desarrollado como parte de una asignación académica enfocada en manejo de estructuras de datos, programación orientada a objetos y diseño de interfaces gráficas.

🚀 Características Principales
🌳 1. Módulo del Árbol Jerárquico

Incluye:

Agregar cargos (nodos) indicando "Padre" e "Hijo".

Eliminar cargos.

Buscar un cargo específico.

Mostrar diversos recorridos.

Contar la cantidad total de cargos.

Mostrar los niveles existentes dentro del árbol.

Interfaz organizada en paneles para mejor usabilidad.

Clases utilizadas

NodoJerarquico

ArbolJerarquico

🗺️ 2. Módulo del Grafo — Sistema de Rutas del Parque

Representa edificios conectados por caminos con distancias.

Incluye:

Agregar edificios (nodos)

Conectar edificios (aristas no dirigidas con peso)

Mostrar lista de conexiones (adyacencias)

Verificar si el grafo es conexo

Calcular rutas:

BFS → ruta simple

Dijkstra → ruta más corta (usando distancias)

Visualización en controles tipo ListBox

Clases utilizadas

Grafo

NodoGrafo

Métodos internos para:

Agregar nodos

Agregar aristas

Obtener adyacencias

BFS

Dijkstra

Validación de conexidad

🖥️ Interfaz Gráfica (WinForms)

El programa contiene dos formularios principales:

✔ FrmArbol

Para el módulo jerárquico, incluyendo:

GroupBox de agregar y eliminar

ListBox para recorridos

Búsqueda de nodos

Conteo

Niveles del árbol

✔ FrmGrafo

Para el sistema de rutas del parque, incluyendo:

GroupBox para agregar edificios

GroupBox para agregar conexiones

Búsqueda de rutas (BFS/Dijkstra)

Conexidad

Lista de adyacencias

Lista de edificios

Diseñado para ser visual, ordenado y simple de usar.

🏗️ Estructura del Proyecto
Proyecto/
│
├── Modelos/
│   ├── NodoJerarquico.cs
│   ├── ArbolJerarquico.cs
│   ├── NodoGrafo.cs
│   └── Grafo.cs
│
├── Formularios/
│   ├── FrmArbol.cs
│   ├── FrmArbol.Designer.cs
│   ├── FrmGrafo.cs
│   └── FrmGrafo.Designer.cs
│
├── Program.cs
└── README.md

🧠 Conceptos Aplicados

Programación Orientada a Objetos (POO)

Árboles jerárquicos

Grafos no dirigidos y ponderados

Estructuras de datos (Listas, Diccionarios)

Algoritmos:

BFS (Breadth-First Search)

Validación de conexidad en grafos

Interfaz de usuario mediante Windows Forms

🧪 Cómo Ejecutar el Proyecto

Abrir la solución .sln en Visual Studio.

Revisar que esté seleccionado el proyecto principal.

Presionar Start / F5.

Utilizar los formularios disponibles desde el menú principal.

🙌 Autor

Proyecto desarrollado por: Kenneth Zamora
Aplicación creada con fines educativos para el estudio y comprensión de estructuras de datos.

📄 Licencia

Este proyecto está disponible para uso académico o personal.
