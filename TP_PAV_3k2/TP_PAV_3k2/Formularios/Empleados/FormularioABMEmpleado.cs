using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //Para el uso de los ArrayLists como data Source del Combo.

namespace TP_PAV_3k2
{
    public partial class FormularioABMEmpleado : Form
    {
        public FormularioABMEmpleado()
        {
            InitializeComponent();
        }

        private void AbmEmpleado_Load(object sender, EventArgs e)
        {
            //Inicializo las columnas de la grid de Empleados.
            grdEmpleados.Columns.Add("clmLegajo", "Legajo");
            grdEmpleados.Columns.Add("clmNombre", "Nombre");
            grdEmpleados.Columns.Add("clmApellido", "Apellido");
            grdEmpleados.Columns.Add("clmTipoDoc", "Tipo Documento");
            grdEmpleados.Columns.Add("clmNumeroDoc", "Número Documento");
            grdEmpleados.Columns.Add("clmFechaNac", "Fecha de Nacimiento");
            grdEmpleados.Columns.Add("clmFechaAlta", "Fecha de Alta");

            //Inicializo los valores del Combo de tipo de documento.
            ArrayList listaTipoDoc = new ArrayList();
            listaTipoDoc.Add("DNI");
            listaTipoDoc.Add("Pasaporte");
            listaTipoDoc.Add("LE");
            cmbTipoDoc.DataSource = listaTipoDoc;
        }

        private void BntAgregar_Click(object sender, EventArgs e)
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
            grdEmpleados.Rows.Add(txtNombre.Text, txtApellido.Text, cmbTipoDoc.SelectedItem.ToString(), txtNumero.Text, dateFechaNacimiento.Value.ToString(), dateFechaAlta.Value.ToString());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
