using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class ClienteBOL
    {
        private ClienteDAL usdao = new ClienteDAL();

        public void Guardar(Cliente us)
        {

            Validar(us);
            
            if (us.ID > 0)
            {
             //   usdao.Actualizar(us);
            }
            else
            {
               // usdao.Insertar(us);

            }

        }


        public void Eliminar(Cliente us)
        {
            if (us.ID <= 0 || us == null)
            {
                throw new Exception("Seleccione un cliente");
            }
            //usdao.Eliminar(us);
        }
        private void Validar(Cliente u)
        {
            if (u == null)
            {
                throw new Exception("Favor seleccionar un cliente");
            }
            if (string.IsNullOrEmpty(u.Nombre.Trim()))
            {
                throw new Exception("Nombre requerido");
            }
            if (string.IsNullOrEmpty(u.ApellidoUno.Trim()))
            {
                throw new Exception("Primer apellido requerido");
            }
            if (string.IsNullOrEmpty(u.ApellidoDos.Trim()))
            {
                throw new Exception("Segundo apellido requerido");
            }

            if (u.Cedula == 0)
            {
                throw new Exception("Cédula requerida");
            }
        }
    }
}
