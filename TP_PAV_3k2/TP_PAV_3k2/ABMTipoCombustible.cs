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
    public partial class ABMTipoCombustible : Form
    {
        RepositorioTipoCombustible _repositorioTipoCombustible;
        FormularioPrincipal _formularioPrincipal;

        public ABMTipoCombustible()
        {
            InitializeComponent();
            _repositorioTipoCombustible = new RepositorioTipoCombustible();
        }

        public ABMTipoCombustible(FormularioPrincipal _formPrincipal)
        {
            InitializeComponent();
            _repositorioTipoCombustible = new RepositorioTipoCombustible();
            _formularioPrincipal = _formPrincipal;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventana = new AltaTipoCombustible();
            ventana.ShowDialog();
            //ActualizarUnidadesMedida();
        }
    }
}
