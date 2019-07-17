using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public bool AdminSede { get; set; }
        public bool Admin { get; set; }
        public bool DueñoVehiculo { get; set; }
    }
}
