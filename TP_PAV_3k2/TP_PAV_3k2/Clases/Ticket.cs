using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Clases
{
    class Ticket
    {
        public int numeroOrdenCompra { get; set; }

        public DateTime fecha { get; set; }

        public int legajo { get; set; }

        public string cuitSolicitante { get; set; }

        public IList<DetalleTickett> detalleTicket { get; set; }

        public decimal MontoFinal { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(legajo.ToString()))
                throw new ApplicationException("Ingrese legajo valido");
            if (string.IsNullOrEmpty(cuitSolicitante))
                throw new ApplicationException("Ingrese cuit valido");
            if (detalleTicket == null || detalleTicket.Count == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
            else
                foreach (var da in detalleTicket)
                    da.Validar();
            if (MontoFinal == 0)
                throw new ApplicationException("Al menos se requiere un detalle");
        }

        public string ObtenerFecha()
        {
            return fecha.ToString("dd/MM/yyyy");
        }


        
    }
}
