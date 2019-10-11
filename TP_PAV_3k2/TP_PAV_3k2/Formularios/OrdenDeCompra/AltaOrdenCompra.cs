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

namespace TP_PAV_3k2.Formularios.OrdenDeCompra
{
    public partial class AltaOrdenCompra : Form
    {
        RepositorioEmpleado repositorioEmpleado;
        RepositorioEstacion repositorioEstacion;
        RepositorioProductos repositorioProductos;
        RepositorioOrdenDeCompra repositorio;
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

        private void grdProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = grdProductos.Rows[e.RowIndex];
            int cantidad = 0;
            if (!int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad))
            {
                fila.Cells["Cantidad"].Value = null;
                fila.Cells["Subtotal"].Value = null;
                ActualizarTotal();
                return;
            }
            var precioUnitario = float.Parse(fila.Cells["PrecioDeVenta"].Value.ToString());
            var subtotal = cantidad * precioUnitario;
            fila.Cells["Subtotal"].Value = subtotal;
            ActualizarTotal();
            return;
        }

        private void ActualizarTotal()
        {
            var filas = grdProductos.Rows;

            float total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                total += float.Parse(fila.Cells["Subtotal"].Value.ToString());
            }
            if (total != 0)
                TxtTotal.Text = total.ToString();
            else
                TxtTotal.Text = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var OrdenCompra = new OrdenDeCompraa()
                {
                    legajo = int.Parse(cmbEmpleados.SelectedValue.ToString()),
                    fecha = DateTime.Today,
                    cuitSolicitante= cmbCuits.SelectedValue.ToString(),
                    detalleOrdenCompra = PreparaDetallesOrden(),
                    MontoFinal = string.IsNullOrEmpty(TxtTotal.Text) ? 0 : float.Parse(TxtTotal.Text)
                };
                OrdenCompra.Validar();
                repositorio.Guardar(OrdenCompra);
                MessageBox.Show("La operación se realizó con exito");
                this.Dispose();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        public List<DetalleOrdenCompraa> PreparaDetallesOrden()
        {
            var detalles = new List<DetalleOrdenCompraa>();

            var filas = grdProductos.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                var detalle = new DetalleOrdenCompraa()
                {
                    Cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString()),
                    PrecioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value.ToString()),
                    Pelicula = new Pelicula() { Id = int.Parse(fila.Cells["Codigo"].Value.ToString()) }
                };
                detalles.Add(detalle);
            }
            return detalles;
        }
    }
}
