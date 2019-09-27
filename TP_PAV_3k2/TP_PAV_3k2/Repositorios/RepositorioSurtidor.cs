using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioSurtidor
    {
        private accesoBD _BD;

        public RepositorioSurtidor()
        {
            _BD = new accesoBD();
        }

        public DataTable ObtenerTiposCombustible()
        {
            string sqltxt = "SELECT * FROM dbo.TipoCombustible";

            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerEstados()
        {
            string sqltxt = "SELECT * FROM Estado";

            return _BD.consulta(sqltxt);
        }

        public DataTable ObtenerCuits()
        {
            string sqltxt = "SELECT * FROM dbo.Estacion";

            return _BD.consulta(sqltxt);
        }


    }
}
