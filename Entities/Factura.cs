using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Factura
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Vehiculo { get; set; }
        public int Costo { get; set; }
        public DateTime FechaInicio { get;set; }
        public DateTime FechaFinal { get; set; }

    }
}
