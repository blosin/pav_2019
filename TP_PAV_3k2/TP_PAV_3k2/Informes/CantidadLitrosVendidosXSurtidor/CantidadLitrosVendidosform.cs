﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor
{
    public partial class CantidadLitrosVendidosform : Form
    {
        public CantidadLitrosVendidosform()
        {
            InitializeComponent();
        }

        private void CantidadLitrosVendidosform_Load(object sender, EventArgs e)
        {

            this.rvVentasXSurtidor.RefreshReport();
        }
    }
}
