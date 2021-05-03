using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosYRegistros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto[] A;
        Producto x = new Producto();
        int cont = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            A = new Producto[50];
            for (int i = 0; i < 50; i++)
            {
                A[i] = new Producto();
            }
        }
        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarDatos(A, cont);
            cont++;
        }

        private void todosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarTodos(A, listView1);
        }

        private void porNombreDelProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarNombreProducto(A, listView1);
        }

        private void porPrecioDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarPrecioProducto(A, listView1);
        }

        private void porExistenciaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarExistenciaProducto(A, listView1);
        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.EliminarDatos(A);
            x.MostrarTodos(A, listView1);
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.ModificarProducto(A);
            x.MostrarTodos(A, listView1);
        }

        private void mostrarLosProductosConExistenciaParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarExistenciaPar(A, listView1);
        }

        private void mostrarLosProductosConExistenciaImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarExistenciaImpar(A, listView1);
        }

        private void mostrarElProductoDeMayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarMayorPrecio(A, listView1);
        }

        private void mostrarElProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarPromedioPrecio(A, listView1);
        }
    }
}

