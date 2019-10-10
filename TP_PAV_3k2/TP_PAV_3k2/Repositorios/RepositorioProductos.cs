using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioProductos
    {
        private accesoBD _BD;

        public RepositorioProductos()
        {
            _BD = new accesoBD();
        }
        public DataTable ObtenerProductos()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.Producto";

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(Productoo producto)
        {
            string sqltxt = "";
            if (producto.UnidadMedida == null)
            {
                sqltxt = $"INSERT dbo.Producto (descripcion, stockActual, precioCompra, precioVenta, fechaUltimaActualizacion, nombre)" +
                    $"VALUES ('{producto.Descripcion}', '{producto.Stock}', '{producto.PrecioCompra}', '{producto.PrecioVenta}', '{producto.ReturnFechaActualizacion()}', '{producto.Nombre}')";
            }
            else
            {
                sqltxt = $"INSERT dbo.Producto (descripcion, stockActual, precioCompra, precioVenta, fechaUltimaActualizacion, nombre, unidadMedida)" +
                   $"VALUES ('{producto.Descripcion}', '{producto.Stock}', '{producto.PrecioCompra}', '{producto.PrecioVenta}', '{producto.ReturnFechaActualizacion()}', '{producto.Nombre}', '{producto.UnidadMedida}')";
            }
            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string productoID)
        {
            string sqltxt = $"DELETE FROM [dbo].[Producto] WHERE idProducto = {productoID}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public Productoo ObtenerProducto(string productoID)
        {
            string sqltxt = $"SELECT * FROM dbo.Producto WHERE idProducto={productoID}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var producto = new Productoo();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                DateTime fecha1;
                if (fila.HasErrors)
                    continue;
                producto.Id = int.Parse(fila.ItemArray[0].ToString());
                producto.Descripcion = fila.ItemArray[1].ToString();
                producto.Stock = int.Parse(fila.ItemArray[2].ToString());
                producto.PrecioCompra = float.Parse(fila.ItemArray[3].ToString());
                producto.PrecioVenta = float.Parse(fila.ItemArray[4].ToString());
                DateTime.TryParse(fila.ItemArray[5]?.ToString(), out fecha1);
                producto.FechaUltimaActualizacion = fecha1;
                producto.Nombre = fila.ItemArray[6].ToString();
                if(fila.ItemArray[7]==null)
                {
                    producto.UnidadMedida = "";
                }
                else
                producto.UnidadMedida = fila.ItemArray[7].ToString();
            }
            return producto;
        }

        public bool Actualizar(Productoo producto)
        {
            string sqltxt;
            if (producto.UnidadMedida == "")
            {
                sqltxt = $"UPDATE dbo.Producto SET nombre = '{producto.Nombre}', descripcion = '{producto.Descripcion}', " +
                    $"stockActual = '{producto.Stock}', precioCompra = '{producto.PrecioCompra}', " +
                    $"precioVenta = '{producto.PrecioVenta}', fechaUltimaActualizacion = '{producto.ReturnFechaActualizacion()}' " +
                    $"WHERE idProducto={producto.Id}";
            }
            else
            {
                sqltxt= $"UPDATE dbo.Producto SET nombre = '{producto.Nombre}', descripcion = '{producto.Descripcion}', " +
                    $"stockActual = '{producto.Stock}', precioCompra = '{producto.PrecioCompra}', " +
                    $"precioVenta = '{producto.PrecioVenta}', fechaUltimaActualizacion = '{producto.ReturnFechaActualizacion()}', " +
                    $"unidadMedida = '{producto.UnidadMedida}' " +
                    $"WHERE idProducto={producto.Id}";
            }


            return _BD.EjecutarSQL(sqltxt);
        }
        public bool ActualizarStock(Productoo producto)
        {
            string sqltxt = $"UPDATE dbo.Producto SET stockActual = '{producto.Stock}' WHERE idProducto='{producto.Id}'";
            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
