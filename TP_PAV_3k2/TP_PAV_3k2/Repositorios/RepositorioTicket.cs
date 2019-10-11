using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2.Repositorios
{
    class RepositorioTicket
    {
        private accesoBD _BD;
        public RepositorioTicket()
        {
            _BD = new accesoBD();
        }

        /*public IList<Ticket> ObtenerTodos()
        {
            string sqltxt = "SELECT * FROM Ticket";

            var tmp = _BD.consulta(sqltxt);

            var tickets = new List<Ticket>();

            foreach (DataRow fila in tmp.Rows)
            {
                if (fila.HasErrors)
                    continue;
                var a = new Ticket()
                {
                    Id = int.Parse(fila.ItemArray[0].ToString()),
                    Cliente = fila.ItemArray[1]?.ToString(),
                    MontoFinal = decimal.Parse(fila.ItemArray[4]?.ToString()),
                };
                a.AsignarFechaDesde(fila.ItemArray[2]?.ToString());
                a.AsignarFechaHasta(fila.ItemArray[3]?.ToString());
                tickets.Add(a);
            }
            return tickets;
        }*/
    }
}
