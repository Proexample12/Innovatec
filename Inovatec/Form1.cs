using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inovatec.Vista;

namespace Inovatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbol ventana = new FrmArbol();
            ventana.Show();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafo ventana = new FrmGrafo();
            ventana.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
