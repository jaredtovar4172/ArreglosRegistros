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
    public partial class DialogBoxBuscarExistencia : Form
    {
        public DialogBoxBuscarExistencia()
        {
            InitializeComponent();
        }
        public string existenciaproducto
        {
            get { return (textBox1.Text); }
        }
        private void DialogBoxBuscarExistencia_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
