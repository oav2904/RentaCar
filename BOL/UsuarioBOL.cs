using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BOL
{
    public class UsuarioBOL
    {
        UsuarioDAL usdao = new UsuarioDAL();

        public void guardar(Usuario us, string repass)
        {

            validar(us, repass);
            //us.Password = md5(us.Password);
            if (us.ID > 0)
            {
                usdao.Actualizar(us);
            }
            else
            {
                usdao.Insertar(us);

            }

        }

        public Usuario Iniciar(Usuario u)

        {
            if (String.IsNullOrEmpty(u.User) || String.IsNullOrEmpty(u.Password))
            {
                throw new Exception("Usuario y Contraseña requeridos");
            }



            return usdao.Iniciar(u);
        }
        public void eliminar(Usuario us)
        {
            if (us.ID <= 0 || us == null)
            {
                throw new Exception("Seleccione un usuario");
            }
            usdao.Eliminar(us);
        }
        private void validar(Usuario u, string repass)
        {
            if (u == null)
            {
                throw new Exception("Favor seleccionar un usuario");
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
            
            if (string.IsNullOrEmpty(u.User.Trim()))
            {
                throw new Exception("Usuario requerido");
            }
            if (string.IsNullOrEmpty(u.Password.Trim()) || !u.Password.Equals(repass) || u.Password.Length < 8)
            {
                throw new Exception("Contraseña invàlida o su contraseña es menor a 8 caracteres, favor intentelo de nuevo");
            }
        }

    }
}
