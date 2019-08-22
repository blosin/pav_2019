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

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            //Inicializo las columnas de la grid de Estaciones Registradas.
            grdEstaciones.Columns.Add("clmCUIT","CUIT");
            grdEstaciones.Columns.Add("clmRazonSocial", "Razon Social");
            grdEstaciones.Columns.Add("clmCalle", "Calle");
            grdEstaciones.Columns.Add("clmNumero", "Numero");
            grdEstaciones.Columns.Add("clmFechaHablilitacion", "Fecha de Habilitación");

            //Inicializo las columnas de la grid de Empleados.
            grdEmpleados.Columns.Add("clmLegajo","Legajo");
            grdEmpleados.Columns.Add("clmNombre", "Nombre");
            grdEmpleados.Columns.Add("clmApellido", "Apellido");
            grdEmpleados.Columns.Add("clmTipoDoc", "Tipo Documento");
            grdEmpleados.Columns.Add("clmNumeroDoc", "Número Documento");
            grdEmpleados.Columns.Add("clmFechaNac", "Fecha de Nacimiento");
            grdEmpleados.Columns.Add("clmFechaAlta", "Fecha de Alta");
        }
    }
}
