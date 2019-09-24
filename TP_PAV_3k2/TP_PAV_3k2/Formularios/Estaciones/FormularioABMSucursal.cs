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
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BntAgregar_Click(object sender, EventArgs e)
        {

            FormularioAgregarEstacion form = new FormularioAgregarEstacion(this);
            form.ShowDialog();
                       
        }
    }
}
