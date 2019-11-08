using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2.Formularios.detalleTicket
{
    public partial class DetalleTicket : Form
    {
        public DetalleTicket(string numTicket, decimal monto)
        {
            InitializeComponent();
            //falta aca;
        }

        private void DetalleTicket_Load(object sender, EventArgs e)
        {
            //ActualizarDetalle();
            //lblTotal.Text = MontoTotal.ToString();
        }
    }
}
