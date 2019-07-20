using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoUno { get; set; }
        public string ApellidoDos { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
        public bool AdminSede { get; set; }
        public bool Admin { get; set; }
        public bool DueñoVehiculo { get; set; }
    }
}
