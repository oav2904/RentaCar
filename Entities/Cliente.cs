using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Cliente
    {
        public int ID { set; get;}
        public string Nombre { set; get; }
        public string ApellidoUno { get; set; }
        public string ApellidoDos { get; set; }
        public int Cedula { get; set; }
    }
}
