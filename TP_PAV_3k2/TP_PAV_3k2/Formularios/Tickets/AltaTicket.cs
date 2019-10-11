using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2.Formularios.Tickets
{
    public partial class AltaTicket : Form
    {
        public AltaTicket()
        {
            InitializeComponent();
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void AltaTicket_Load(object sender, EventArgs e)
        {
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
