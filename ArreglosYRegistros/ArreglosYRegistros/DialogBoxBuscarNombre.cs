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
    public partial class DialogBoxBuscarNombre : Form
    {
        public string nombreproducto
        {
            get { return (textBox1.Text); }
        }
        public DialogBoxBuscarNombre()
        {
            InitializeComponent();
        }

        private void DialogBoxBuscarNombre_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
