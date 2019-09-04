using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2
{
    class RepositorioTipoCombustible
    {
        private accesoBD _BD;

        public RepositorioTipoCombustible()
        {
            _BD = new accesoBD();
        }

        public DataTable ObtenerTiposCombustible()
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = "SELECT * FROM dbo.TipoCombustible";

            return _BD.consulta(sqltxt);
        }

        public bool Guardar(TipoCombustible tipoCombustible)
        {
            string sqltxt = $"INSERT dbo.TipoCombustible (Nombre) " +
                $"VALUES ({tipoCombustible.Nombre}";               

            return _BD.EjecutarSQL(sqltxt);
        }

        public bool Eliminar(string TipoCombustibleID)
        {
            string sqltxt = $"DELETE FROM [dbo].[TipoCombustible] WHERE id = {TipoCombustibleID}";

            return _BD.EjecutarSQL(sqltxt);
        }

        public TipoCombustible ObtenerTipoCombustible(string TipoCombustibleId)
        {
            string sqltxt = $"SELECT * FROM dbo.TipoCombustible WHERE id={TipoCombustibleId}";
            var tablaTemporal = _BD.consulta(sqltxt);

            if (tablaTemporal.Rows.Count == 0)
                return null;
            var tipoCombustible = new TipoCombustible();
            foreach (DataRow fila in tablaTemporal.Rows)
            {
                if (fila.HasErrors)
                    continue;
                tipoCombustible.Id = int.Parse(fila.ItemArray[0].ToString());
                tipoCombustible.Nombre = fila.ItemArray[1].ToString();
            }
            return tipoCombustible;
        }

        public bool Actualizar(TipoCombustible tipoCombustible)
        {
            string sqltxt = $"UPDATE dbo.TipoCombustible SET Nombre = '{tipoCombustible.Nombre}' WHERE id={tipoCombustible.Id}";

            return _BD.EjecutarSQL(sqltxt);
        }
    }
}
