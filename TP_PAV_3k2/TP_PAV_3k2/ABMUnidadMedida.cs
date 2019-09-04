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
    public partial class ABMUnidadMedida : Form
    {
        RepositorioUnidadDeMedida _repositorioUnidadMedida;
        FormularioPrincipal _formularioPrincipal;
        public ABMUnidadMedida()
        {
            InitializeComponent();
            _repositorioUnidadMedida = new RepositorioUnidadDeMedida();
        }

        public ABMUnidadMedida(FormularioPrincipal _formPrincipal)
        {
            InitializeComponent();
            _repositorioUnidadMedida = new RepositorioUnidadDeMedida();
            _formularioPrincipal = _formPrincipal;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventana = new AltaUnidadDeMedida();
            ventana.ShowDialog();
            //ActualizarUnidadesMedida();
        }
    }
}
