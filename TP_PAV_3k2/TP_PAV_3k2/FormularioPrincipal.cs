using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioAgregarEmpleado();
            formulario.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioAgregarEstacion();
            formulario.Show();
        }
    }
}
