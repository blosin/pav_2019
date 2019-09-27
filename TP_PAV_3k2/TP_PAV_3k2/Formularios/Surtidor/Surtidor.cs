using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.Surtidor
{
    public partial class Surtidor : Form
    {
        FormularioPrincipal _formularioPrincipal;
        RepositorioSurtidor repositorioSurtidor;
        public Surtidor()
        {
            InitializeComponent();
            repositorioSurtidor = new RepositorioSurtidor();
        }
        public Surtidor(FormularioPrincipal form)
        {
            InitializeComponent();
            repositorioSurtidor = new RepositorioSurtidor();
            _formularioPrincipal = form;
        }
        public void cargarComboTipoCombustible()
        {
            DataTable tablacombo = new DataTable();
            tablacombo=repositorioSurtidor.ObtenerTiposCombustible();
            cmbTipoCombustible.DataSource = tablacombo;
            cmbTipoCombustible.ValueMember = "idTipoCombustible";
            cmbTipoCombustible.DisplayMember = "nombre";
        }
        public void cargarComboEstado()
        {
            DataTable tablacombo = new DataTable();
            tablacombo = repositorioSurtidor.ObtenerEstados();
            cmbEstado.DataSource = tablacombo;
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.DisplayMember = "nombre";
        }
        public void cargarComboCuit()
        {
            DataTable tablacombo = new DataTable();
            tablacombo = repositorioSurtidor.ObtenerCuits();
            cmbCuit.DataSource = tablacombo;
            cmbCuit.ValueMember = "cuit";
            cmbCuit.DisplayMember = "cuit";
        }
        private void Surtidor_Load(object sender, EventArgs e)
        {
            cargarComboTipoCombustible();
            cargarComboEstado();
            cargarComboCuit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            _formularioPrincipal.Show();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }
    }
}
