using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class ReservacionBOL
    {
        private ReservacionDAL reserva = new ReservacionDAL();

    
        public void Guardar(Reservacion r)
        {
            reserva.Guardar(r);
        }

        public void Facturar(int id)
        {
            reserva.Facturar(id);
        }
    }
}
