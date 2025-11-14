using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inovatec.Modelos;

namespace Inovatec.Vista
{
    public partial class FrmArbol : Form
    {
        private ArbolJerarquico arbol;

        public FrmArbol()
        {
            InitializeComponent();

            arbol = new ArbolJerarquico("Innovatec");
            tvArbol.Nodes.Clear();
            tvArbol.Nodes.Add(arbol.Raiz.Nombre);

            // Rellenar combos iniciales
            ActualizarComboEliminar();
            ActualizarComboPadre();

            // Sincronizar selección del TreeView con cbPadre
            tvArbol.AfterSelect += TvArbol_AfterSelect;
        }

        private void TvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e?.Node == null) return;
            var texto = e.Node.Text?.Trim() ?? string.Empty;

            if (!cbPadre.Items.Contains(texto))
                cbPadre.Items.Add(texto);

            cbPadre.SelectedItem = texto;
        }

        private TreeNode BuscarTreeNode(TreeNodeCollection nodes, string texto)
        {
            if (texto == null) texto = string.Empty;
            var textoBuscado = texto.Trim();

            foreach (TreeNode tn in nodes)
            {
                if (tn.Text?.Trim().Equals(textoBuscado, StringComparison.OrdinalIgnoreCase) == true)
                    return tn;

                var encontrado = BuscarTreeNode(tn.Nodes, texto);
                if (encontrado != null) return encontrado;
            }
            return null;
        }
        private void AgregarNodoTreeView(string nombrePadre, string nombreHijo)
        {
            var nodoPadreTV = BuscarTreeNode(tvArbol.Nodes, nombrePadre);
            if (nodoPadreTV != null)
            {
                nodoPadreTV.Nodes.Add(nombreHijo);
                nodoPadreTV.Expand();
            }
            else
            {
                // Si no encontró (caso raro), añadir en raíz
                tvArbol.Nodes.Add(nombreHijo);
            }
        }

        private void ActualizarComboEliminar()
        {
            cbEliminar.Items.Clear();
            List<string> lista = new List<string>();
            arbol.ObtenerTodos(arbol.Raiz, lista);

            foreach (var item in lista)
                cbEliminar.Items.Add(item);
        }

        private void ActualizarComboPadre()
        {
            cbPadre.Items.Clear();
            List<string> lista = new List<string>();
            arbol.ObtenerTodos(arbol.Raiz, lista);

            foreach (var item in lista)
            {
                if (!cbPadre.Items.Contains(item))
                    cbPadre.Items.Add(item);
            }

            // Seleccionar la raíz por defecto si existe
            if (cbPadre.Items.Count > 0)
                cbPadre.SelectedItem = arbol.Raiz.Nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmArbol_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener padre desde cbPadre (seleccionado o texto manual)
            string padre = (cbPadre.SelectedItem != null)
                ? cbPadre.SelectedItem.ToString().Trim()
                : cbPadre.Text.Trim();

            string hijo = tbCargo.Text.Trim();

            if (string.IsNullOrWhiteSpace(padre) || string.IsNullOrWhiteSpace(hijo))
            {
                MessageBox.Show("Rellena ambos campos (padre y nuevo cargo).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar insertar en la estructura
            bool ok = arbol.Insertar(padre, hijo);
            if (!ok)
            {
                MessageBox.Show("No se pudo insertar. Verifica que el cargo padre exista y que el hijo no esté repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar TreeView
            AgregarNodoTreeView(padre, hijo);

            // Actualizar Combos
            ActualizarComboEliminar();

            // Añadir hijo a cbPadre para que pueda ser seleccionado como padre más adelante
            if (!cbPadre.Items.Contains(hijo))
                cbPadre.Items.Add(hijo);

            // Limpiar campos
            tbCargo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cargo para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nombre = cbEliminar.SelectedItem.ToString();

            // Evitar eliminar la raíz si no quieres (opcional)
            if (nombre.Equals(arbol.Raiz.Nombre, StringComparison.OrdinalIgnoreCase))
            {
                var respuesta = MessageBox.Show("¿Deseas eliminar la raíz y todo su subárbol? (Suele ser irreversible)", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.No) return;
                // Si confirma, podrías reiniciar el árbol; aquí no lo permitiré por simplicidad:
                MessageBox.Show("Eliminar la raíz no está permitido en esta versión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Confirmación para evitar borrados accidentales
            var conf = MessageBox.Show($"¿Seguro que deseas eliminar '{nombre}'? (Si es padre se eliminarán sus subordinados)", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf != DialogResult.Yes) return;

            // Eliminar de la estructura
            bool eliminado = arbol.EliminarNodo(arbol.Raiz, nombre);
            if (!eliminado)
            {
                MessageBox.Show("No se encontró el cargo o no se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eliminar del TreeView
            TreeNode nodoTV = BuscarTreeNode(tvArbol.Nodes, nombre);
            if (nodoTV != null) nodoTV.Remove();

            // Actualizar Combos
            ActualizarComboEliminar();
            ActualizarComboPadre();

            MessageBox.Show("Cargo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
