using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Clases;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.Empleados
{
    public partial class ModificarEmpleado : Form
    {
        RepositorioEmpleado repositorio;
        Empleado empleado;
        RepositorioTiposDoc repositorioTiposDoc;

        public ModificarEmpleado(string legajo)
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleado();
            empleado = repositorio.ObtenerEmpleado(legajo);
            repositorioTiposDoc = new RepositorioTiposDoc();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            lblLegajo.Text =empleado.legajo.ToString();
            txtNombre.Text = empleado.nombre;
            txtApellido.Text = empleado.apellido;
            txtNumero.Text = empleado.nroDoc.ToString();
            dateFechaNacimiento.Value = empleado.fechaNacimiento;
            dateFechaAlta.Value = empleado.fechaAlta;
            DataTable tiposDoc;
            DataTable Legajos;
            tiposDoc = repositorioTiposDoc.ObtenerTiposDocumento();
            cmbTipoDoc.DataSource = tiposDoc;
            cmbTipoDoc.ValueMember = "idTipoDocumento";
            cmbTipoDoc.DisplayMember = "nombre";
            Legajos = repositorio.ObtenerLegajos();
            cmbLegajoSup.DataSource = Legajos;
            cmbLegajoSup.ValueMember = "legajo";
            cmbLegajoSup.DisplayMember = "legajo";
            cmbTipoDoc.SelectedText = empleado.tipoDoc;
            cmbLegajoSup.SelectedText = empleado.legajoSuperior.ToString();
            /*cmbTipoDoc
            txtCalle.Text = estacion.calle;
            fechaHabilitación.Value = estacion.fechaHabilitacion;*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
