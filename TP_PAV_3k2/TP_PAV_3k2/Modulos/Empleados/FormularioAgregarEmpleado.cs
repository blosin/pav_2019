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
            this.Dispose();
        }

        private void BntAceptar_Click(object sender, EventArgs e)
        {
            //Valido los campos de texto
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
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Ingrese un número de documento.");
                txtNumero.Focus();
            }
            //Con los datos validados llegar la grilla

            //FormularioPrincipal.grillaEmpleados.Rows.Add(txtLegajo.Text, txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedItem.ToString(), txtNumero.Text, dateFechaNacimiento.Value.ToString(), dateFechaAlta.Value.ToString());
        }



        private void FormularioAgregarEmpleado_Load(object sender, EventArgs e)
        {   
            //LOAD: Inicializo los valores del combo Tipos de Documento.
            ArrayList listaTipoDoc = new ArrayList();
            listaTipoDoc.Add("DNI");
            listaTipoDoc.Add("Pasaporte");
            listaTipoDoc.Add("LE");
            cmbTipoDoc.DataSource = listaTipoDoc;
        }
    }
}
