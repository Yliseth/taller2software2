using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Identificacion 
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
    }
}
