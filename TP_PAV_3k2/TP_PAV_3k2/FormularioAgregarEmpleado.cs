using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TP_PAV_3k2
{
    public partial class FormularioAgregarEmpleado : Form
    {
        public FormularioAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El Nombre no puede quedar vacío.");
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("El Apellido está vacío.");
                txtApellido.Focus();
            }

        }

        private void FormularioAgregarEmpleado_Load(object sender, EventArgs e)
        {
            ArrayList listaTipoDoc = new ArrayList();
            listaTipoDoc.Add("DNI");
            listaTipoDoc.Add("Pasaporte");
            listaTipoDoc.Add("LE");
            cmbTipoDoc.DataSource = listaTipoDoc;
        }
    }
}
