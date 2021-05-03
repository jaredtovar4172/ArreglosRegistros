using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ArreglosYRegistros
{
    class Producto
    {
        public int Id;
        public string NombreProducto;
        public double PrecioProducto;
        public int ExistenciaProducto;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string nombreproducto
        {
            get { return NombreProducto; }
            set { NombreProducto = value; }
        }
        public double precioproducto
        {
            get { return PrecioProducto; }
            set { PrecioProducto = value; }
        }
        public int existenciaproducto
        {
            get { return ExistenciaProducto; }
            set { ExistenciaProducto = value; }
        }
        public Producto()
        {
            Id = 0;
            NombreProducto = "";
            PrecioProducto = 0;
            ExistenciaProducto = 0;
        }
        public Producto[] AgregarDatos(Producto[] A, int i)
        {
            DialogBoxCapture captura = new DialogBoxCapture();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Id = int.Parse(captura.id);
                A[i].NombreProducto = captura.nombre;
                A[i].PrecioProducto = double.Parse(captura.precio);
                A[i].ExistenciaProducto = int.Parse(captura.existencia);
                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }
        public void MostrarTodos(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)
                {
                    ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                    lista.SubItems.Add(A[i].NombreProducto);
                    lista.SubItems.Add(A[i].PrecioProducto.ToString());
                    lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                    caja.Items.Add(lista);
                }
            }
        }
        public void MostrarNombreProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro en los datos el nombre del producto", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarPrecioProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            DialogBoxBuscarPrecio busca = new DialogBoxBuscarPrecio();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].PrecioProducto == double.Parse(busca.precioproducto))
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro en los datos el nombre del producto", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarExistenciaProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            DialogBoxBuscarExistencia busca = new DialogBoxBuscarExistencia();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].ExistenciaProducto == double.Parse(busca.existenciaproducto))
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro en los datos el nombre del producto", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public Producto[] EliminarDatos(Producto[] A)
        {
            bool sw = false;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        A[i].Id = 0;
                        A[i].NombreProducto = "";
                        A[i].PrecioProducto = 0;
                        A[i].ExistenciaProducto = 0;
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("El producto que se quiere borrar no existe", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El producto que se elimino de los datos del arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return A;
        }
        public Producto[] ModificarProducto(Producto[] A)
        {
            bool sw = false;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            DialogBoxCapture captura = new DialogBoxCapture();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        if (captura.ShowDialog() == DialogResult.OK)
                        {
                            A[i].Id = int.Parse(captura.id);
                            A[i].NombreProducto = captura.nombre;
                            A[i].PrecioProducto = double.Parse(captura.precio);
                            A[i].ExistenciaProducto = int.Parse(captura.existencia);
                        }
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("El producto que deseas modificar no existe", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos del producto se modificaron", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return (A);
        }
        public void MostrarExistenciaPar(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)
                {
                    if (A[i].ExistenciaProducto % 2 == 0)
                    {
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
        }
        public void MostrarExistenciaImpar(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)
                {
                    if (A[i].ExistenciaProducto % 2 != 0)
                    {
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
        }
        public void MostrarMayorPrecio(Producto[] A, ListView caja)
        {
          
        }
        public void MostrarPromedioPrecio(Producto[] A, ListView caja)
        {
            double prom = 0;
            double suma = 0;
            for (int i = 0; i < 50; i++)
            {
                suma = suma + A[i].PrecioProducto;
                prom = suma / 2;
                
            }
            MessageBox.Show("La suma de los numeros del arreglo es: " + suma + "\n" + "El promedio de los numeros del arreglo es: " + prom, "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
  }

