using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;


namespace TP_PAV_3k2.Repositorios
{
    class RepositorioOrdenDeCompra
    {
        private accesoBD _BD;

        public RepositorioOrdenDeCompra()
        {
            _BD = new accesoBD();        }

        
        public DataTable ObtenerOrdenes()
        {            
            string sqltxt = "SELECT * FROM OrdenCompra";

            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerLegajos()
        {
            string sqltxt = "SELECT legajo FROM dbo.Empleado";

            return _BD.consulta(sqltxt);
        }

        public void Guardar(OrdenDeCompraa v)
        {
            using (var tx = _BD.IniciarTransaccion())
            {
                try
                {
                    string sqltxt = $"INSERT [dbo].[OrdenCompra] ([fecha], [legajo], [cuitSolicitante], [montoFinal])" +
                        $" VALUES ('{v.fecha}', '{v.legajo}', {v.cuitSolicitante}, {v.MontoFinal})";
                    v.numeroOrdenCompra = _BD.EjecutarTransaccion(sqltxt);
                    if (v.numeroOrdenCompra == 0)
                        throw new ApplicationException();

                    foreach (var d in v.detalleOrdenCompra)
                    {
                        sqltxt = $"INSERT [dbo].[DetalleOrdenCompra] " +
                            $"([numOrdenCompra], [idProducto], [Cantidad], [idUnidadMedida], [precio], [idUrgencia]) " +
                            $"VALUES ({v.numeroOrdenCompra}, {d.producto.Id}, {d.cantidad}, (SELECT idUnidadMedida FROM UnidadMedida WHERE nombre={d.unidadMedida}), {d.precio}, {d.urgencia.Id})";
                        _BD.EjecutarTransaccion(sqltxt);

                        sqltxt = $"SELECT stockActual FROM Producto WHERE idProducto={d.producto.Id}";

                        var stock =
                            int.Parse(_BD.ConsultaDuranteTransaccion(sqltxt).Rows[0]["stockActual"].ToString());

                        sqltxt = $"UPDATE [dbo].[Producto] SET stockActual = '{stock - d.cantidad}' WHERE id={d.producto.Id}";
                        _BD.EjecutarTransaccion(sqltxt);
                    }

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo guardar la orden de compra.");
                }
                finally
                {
                    _BD.cerrar();
                }
            }

        }

        /*public bool Eliminar(string legajo)
        {
            string sqltxt = $"DELETE FROM [dbo].[Empleado] WHERE legajo = {legajo}";

            return _BD.EjecutarSQL(sqltxt);
        } */

        
    
    }
}
