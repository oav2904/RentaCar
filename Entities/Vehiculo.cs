using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehiculo
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string NumPlaca { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public double CostoDia { get; set; }
        public bool Activo { get; set; }
    }
}
