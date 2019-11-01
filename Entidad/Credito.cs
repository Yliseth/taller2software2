using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Credito
    {
        public string Tipo { get; set; }
        public Double MontoTotalCredito { get; set; }
        public int PlazoPagoMeses { get; set; }
        public DateTime FechaInicio { get; set; }
        public List<Pago> Pagos { get; set; }

    }
}
