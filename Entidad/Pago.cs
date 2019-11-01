using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pago : Credito
    {
        public DateTime FechaPago { get; set; }
        public int MontoDineroCancelado { get; set; }

        //public ? PagoaTiempo { get; set; }
    }
}
