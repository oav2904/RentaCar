using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Vehículo
    {
        public int ID { get; set; }
        public int User { get; set; }
        public string NumPlaca { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public double CostoDia { get; set; }
        public bool Activo { get; set; }
    }
}
