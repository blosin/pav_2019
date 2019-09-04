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
    public partial class FormularioAgregarEstacion : Form
    {
        public FormularioAgregarEstacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void BntAceptar_Click(object sender, EventArgs e)
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
        }
    }
}
