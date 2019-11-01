using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClientePlata : Cliente
    {
        public Identificacion Identificacion { get; set; }
        public string NombresApellidos  { get; set; }
        public List<Credito> Creditos { get; set; }
    }
}
