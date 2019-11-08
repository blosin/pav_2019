using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioDetalleTicket
    {
        private accesoBD _BD;

        public RepositorioDetalleTicket()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerDetalles(string numOrdenCompra)
        {
            string sqltxt = $"SELECT a.numDetalleOrden, b.nombre, a.cantidad, a.idUnidadMedida, a.precio, CAST(REPLACE(a.precio, ',', '.') as float)*a.cantidad as subtotal FROM DetalleOrdenCompra a, Producto b WHERE a.idProducto=b.idProducto AND numOrdenCompra='{numOrdenCompra}'";
            //falta.
            return _BD.consulta(sqltxt);
        }
    }
}
