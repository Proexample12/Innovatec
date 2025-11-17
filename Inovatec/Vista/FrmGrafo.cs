using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using Inovatec.Modelos;

namespace Inovatec.Vista
{
    public partial class FrmGrafo : Form
    {
        // Inicializar en tiempo de ejecución (no en diseño)
        private Grafo grafo;

        public FrmGrafo()
        {
            InitializeComponent();
            grafo = new Grafo();
            // Evitar ejecutar lógica de inicialización cuando el diseñador de Visual Studio
            // instancia el formulario (evita que el diseñador "se rompa")
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                grafo = new Grafo();

                // Conectar manejadores
                btnAgregar.Click += BtnAgregar_Click;
                btnConectar.Click += BtnConectar_Click;
                btnBuscarRuta.Click += BtnBuscarRuta_Click;
                btnConexidad.Click += BtnConexidad_Click;

                // Refrescar UI inicial
                RefrescarUI();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var nombre = (tbEdificio.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce un nombre de edificio válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!grafo.AgregarNodo(nombre))
            {
                MessageBox.Show("El edificio ya existe o nombre inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEdificio.Clear();
                return;
            }

            tbEdificio.Clear();
            RefrescarUI();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            var a = (cbA.SelectedItem ?? cbA.Text ?? string.Empty).ToString().Trim();
            var b = (cbB.SelectedItem ?? cbB.Text ?? string.Empty).ToString().Trim();

            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            {
                MessageBox.Show("Selecciona (o escribe) ambos nodos A y B.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!grafo.Conectar(a, b))
            {
                MessageBox.Show("No se pudo conectar (nodos iguales, inexistentes o ya conectados).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RefrescarUI();
        }

        private void BtnBuscarRuta_Click(object sender, EventArgs e)
        {
            var origen = (cbOrigen.SelectedItem ?? cbOrigen.Text ?? string.Empty).ToString().Trim();
            var destino = (cbDestino.SelectedItem ?? cbDestino.Text ?? string.Empty).ToString().Trim();

            lbRuta.Items.Clear();

            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                MessageBox.Show("Selecciona origen y destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ruta = grafo.EncontrarRutaBFS(origen, destino);
            if (ruta == null || ruta.Count == 0)
            {
                MessageBox.Show("No existe ruta entre los nodos seleccionados.", "Sin ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var nodo in ruta)
                lbRuta.Items.Add(nodo);
        }

        private void BtnConexidad_Click(object sender, EventArgs e)
        {
            lbConexiones.Items.Clear();

            if (grafo == null || !grafo.GetNodos().Any())
            {
                MessageBox.Show("El grafo está vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar lista de adyacencias
            foreach (var kv in grafo.ObtenerAdyacencias().OrderBy(k => k.Key))
            {
                var line = kv.Key + ": " + (kv.Value.Count == 0 ? "(sin conexiones)" : string.Join(", ", kv.Value.OrderBy(x => x)));
                lbConexiones.Items.Add(line);
            }

            bool esConexo = grafo.EsConexo();
            MessageBox.Show(esConexo ? "El grafo es conexo." : "El grafo NO es conexo (varios componentes).", "Conexidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Refresca ListBox y ComboBox con los nodos actuales
        private void RefrescarUI()
        {
            if (grafo == null) return;

            lbEdificios.Items.Clear();
            foreach (var nodo in grafo.GetNodos())
                lbEdificios.Items.Add(nodo);

            void RellenarCombo(ComboBox cb)
            {
                var seleccion = cb.SelectedItem;
                cb.Items.Clear();
                foreach (var nodo in grafo.GetNodos())
                    cb.Items.Add(nodo);
                if (seleccion != null && cb.Items.Contains(seleccion)) cb.SelectedItem = seleccion;
            }

            RellenarCombo(cbA);
            RellenarCombo(cbB);
            RellenarCombo(cbOrigen);
            RellenarCombo(cbDestino);

            lbConexiones.Items.Clear();
            foreach (var kv in grafo.ObtenerAdyacencias().OrderBy(k => k.Key))
            {
                var line = kv.Key + ": " + (kv.Value.Count == 0 ? "(sin conexiones)" : string.Join(", ", kv.Value.OrderBy(x => x)));
                lbConexiones.Items.Add(line);
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        
        private void FrmGrafo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
