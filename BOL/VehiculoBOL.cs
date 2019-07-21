using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class VehiculoBOL
    {
        private VehiculoDAL vedal = new VehiculoDAL();

        public void Guardar(Vehiculo vehiculo)
        {

            validar(vehiculo);

            if (vehiculo.ID > 0)
            {
                vedal.Actualizar(vehiculo);
            }
            else
            {
                vedal.Insertar(vehiculo);

            }

        }
           
        public void Eliminar(Vehiculo vehiculo)
        {
            if (vehiculo.ID <= 0 || vehiculo == null)
            {
                throw new Exception("Seleccione un usuario");
            }
            vedal.Eliminar(vehiculo);
        }

        private void Validar(Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                throw new Exception("Favor seleccionar un vehiculo");
            }
            if (string.IsNullOrEmpty(vehiculo.Color.Trim()))
            {
                throw new Exception("Color requerido");
            }
            if (string.IsNullOrEmpty(vehiculo.Modelo.Trim()))
            {
                throw new Exception("Modelo requerido");
            }
            if (string.IsNullOrEmpty(vehiculo.NumPlaca.Trim()))
            {
                throw new Exception("Número de placa requerido");
            }

            if (vehiculo.User == 0)
            {
                throw new Exception("Usuario requerido");
            }

            if (vehiculo.CostoDia == 0)
            {
                throw new Exception("Digite un valor disponible");
            }

        }

    }
}
