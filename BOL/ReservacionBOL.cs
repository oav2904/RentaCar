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

        public void Guardar(Reservacion reservacion)
        {

            Validar(reservacion);

            if (reservacion.ID > 0)
            {
               // reserva.Actualizar(reservacion);
            }
            else
            {
               // reserva.Insertar(reservacion);

            }

        }


        public void Eliminar(Cliente reservacion)
        {
            if (reservacion.ID <= 0 || reservacion == null)
            {
                throw new Exception("Seleccione una reservacion");
            }
            //reserva.Eliminar(reservacion);
        }

        public void Validar(Reservacion reservacion)
        {
            if (reservacion == null)
            {
                throw new Exception("Seleccione una reservacion");
            }

            if (reservacion.Cliente == 0)
            {
                throw new Exception("Seleccione un cliente");
            }

            if (reservacion.Vehiculos == 0)
            {
                throw new Exception("Seleccione un vehiculo");
            }

            if (reservacion.Costo == 0)
            {
                throw new Exception("El costo de la reservacion no puede ser menor o igual a 0");
            }

        }



    }
}
