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
using TP_PAV_3k2.Formularios.Surtidor;

namespace TP_PAV_3k2
{
    public partial class FormularioPrincipal : Form
    {
        PantallaLogIn Login = new PantallaLogIn();
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        //public static DataGridView grillaEmpleados = new DataGridView();
        public FormularioPrincipal(PantallaLogIn login)
        {
            InitializeComponent();
            Login = login;
        }
        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioABMEmpleado();
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }

        private void agregarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioABMSucursal();
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
        private void GrdEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarTipoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TipoCombustibleForm = new ABMTipoCombustible(this);
            TipoCombustibleForm.Show();
            this.Hide();
        }

        private void agregarUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var UnidadMedida = new ABMUnidadMedida(this);
            UnidadMedida.Show();
            this.Hide();
        }

        private void agregarUrgenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Urgencia = new ABMUrgencia(this);
            Urgencia.Show();
            this.Hide();
        }

        private void aBMSurtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var surtidor = new Surtidor(this);
            surtidor.Show();
            this.Hide();

        }
    }
}
