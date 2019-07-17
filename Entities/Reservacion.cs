using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Reservacion
    {
        public int ID { get; set; }
        public int Vehículo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int Cliente { get; set; }
        public bool Activo { get; set; }
        public string Estado { get; set; }
        public double Costo { get; set; }

    }
}
