using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2
{
    public partial class FormularioABMSucursal : Form
    {
        public FormularioABMSucursal()
        {
            InitializeComponent();
        }

        private void AbmSucursales_Load(object sender, EventArgs e)
        {
            //Inicializo las columnas de la grid de Estaciones Registradas.
            grdEstaciones.Columns.Add("clmCUIT", "CUIT");
            grdEstaciones.Columns.Add("clmRazonSocial", "Razon Social");
            grdEstaciones.Columns.Add("clmCalle", "Calle");
            grdEstaciones.Columns.Add("clmNumero", "Numero");
            grdEstaciones.Columns.Add("clmFechaHablilitacion", "Fecha de Habilitación");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntAgregar_Click(object sender, EventArgs e)
        {
            //Valido los campos de texto
            if (txtCUIT.Text == "")
            {
                MessageBox.Show("Ingrese un Número de CUIT");
                txtCUIT.Focus();
            }
            else if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de Razon Social");
                txtRazonSocial.Focus();
            }
            else if (txtCalle.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de Calle");
                txtCalle.Focus();
            }
            else if (txtNumeroCalle.Text == "")
            {
                MessageBox.Show("Ingrese un número de calle");
                txtNumeroCalle.Focus();
            }
            //Validados los datos se agregan a la grilla.
            grdEstaciones.Rows.Add(txtCUIT.Text, txtRazonSocial.Text, txtCalle.Text, txtNumeroCalle.Text, fechaHabilitación.Value.ToString());
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //LLamar a AgregarEstacion con los datos seleccionados e la grilla
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar los datos seleccionados.
        }
    }
}
