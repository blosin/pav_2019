using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.OrdenDeCompra
{
    public partial class AltaOrdenCompra : Form
    {
        RepositorioEmpleado repositorioEmpleado;
        RepositorioEstacion repositorioEstacion;
        RepositorioProductos repositorioProductos;
        public AltaOrdenCompra()
        {
            InitializeComponent();
            repositorioEmpleado = new RepositorioEmpleado();
            repositorioEstacion = new RepositorioEstacion();
            repositorioProductos = new RepositorioProductos();

        }

        private void AltaOrdenCompra_Load(object sender, EventArgs e)
        {
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
            DataTable legajos;
            DataTable cuit;
            legajos = repositorioEmpleado.ObtenerLegajos();
            cmbEmpleados.DataSource = legajos;
            cmbEmpleados.ValueMember = "legajo";
            cmbEmpleados.DisplayMember = "legajo";
            cuit = repositorioEstacion.ObtenerCuits();
            cmbCuits.DataSource = cuit;
            cmbCuits.ValueMember = "cuit";
            cmbCuits.DisplayMember = "cuit";

            cmbCuits.SelectedIndex = -1;
            cmbEmpleados.SelectedIndex = -1;

            ActualizarProductos();
        }

        public void ActualizarProductos()
        {
            grdProductos.Rows.Clear();
            var prodctos = repositorioProductos.ObtenerProductos().Rows;
            ActualizarGrilla(prodctos);
        }

        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    registro.ItemArray[0].ToString(),
                    registro.ItemArray[6].ToString(),
                    registro.ItemArray[1].ToString(),
                    registro.ItemArray[2].ToString(),
                    registro.ItemArray[3].ToString(),
                    registro.ItemArray[4].ToString(),
                    registro.ItemArray[5].ToString(),
                    registro.ItemArray[7].ToString(),


                };

                grdProductos.Rows.Add(fila);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
