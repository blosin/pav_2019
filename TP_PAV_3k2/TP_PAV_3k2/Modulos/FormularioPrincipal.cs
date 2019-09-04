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
        //public static DataGridView grillaEmpleados = new DataGridView();
        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioABMEmpleado();
            formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
        private void GrdEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Modulos.AdministrarSoporte();
            formulario.ShowDialog();
        }

        private void NivelDeUrgenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Modulos.AdministrarSoporte();
            formulario.ShowDialog();
        }

        private void TipoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Modulos.AdministrarSoporte();
            formulario.ShowDialog();
        }
    }
}
