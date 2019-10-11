using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    class DetalleTickett
    {
        public int nroDetalleTICKET { get; set; }

        public int nroTicket { get; set; }

        public int idProducto { get; set; }

        public int cantidad { get; set; }

        public float precio { get; set; }


        public void Validar()
        {
            if (string.IsNullOrEmpty(cantidad.ToString()) || cantidad < 0)
                throw new ApplicationException("Ingrese cantidad valida");

            if (string.IsNullOrEmpty(precio.ToString()) || precio < 0)
                throw new ApplicationException("Ingrese precio valido");
        }
    }
}
