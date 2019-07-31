using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class UsuarioDAL
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        readonly Usuario u = new Usuario();

        public DataTable Lista()
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand
                {
                    Connection = conexion.AbrirConexion(),
                    CommandText = "select id,nombre,primer_apellido,segundo_apellido,usuario,contrasenna,administrador_sede," +
                    "dueño_veh,administrador,activo from usuarios where activo = 1"
                };
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                leer.Close();
                conexion.CerrarConexion();
                return tabla;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception("Problemas");
            }

        }

        public void Actualizar(Usuario u)
        {
            try
            {
                string query = "Update usuarios SET nombre = @nombre,primer_apellido =  @papellido," +
                    " segundo_apellido = @sapellido,usuario = @user,contrasenna = @contrasenna," +
                    "administrador_sede = @adminsede,dueño_veh = @dveh, administrador = @admin WHERE id = @id";

                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", u.ID);
                comanda.Parameters.AddWithValue("@nombre", u.Nombre);
                comanda.Parameters.AddWithValue("@papellido", u.ApellidoUno);
                comanda.Parameters.AddWithValue("@sapellido", u.ApellidoDos);
                comanda.Parameters.AddWithValue("@user", u.User);
                comanda.Parameters.AddWithValue("@contrasenna", u.Password);
                comanda.Parameters.AddWithValue("@adminsede", u.AdminSede);
                comanda.Parameters.AddWithValue("@dveh", u.DueñoVehiculo);
                comanda.Parameters.AddWithValue("@admin", u.Admin);

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
                e.Source = "Problemas al actualizar el usuario ";
            }
        }

        public void Eliminar(Usuario u)
        {
            try
            {
                string query = "UPDATE usuarios  SET activo = 0 where id= @id";
                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", u.ID);
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                e.Source = "Problemas al eliminar el usuario ";

            }
        }

        public void Insertar(Usuario u)
        {
            try
            {
                string query = "INSERT INTO usuarios(nombre,primer_apellido,segundo_apellido,usuario,contrasenna,administrador_sede, dueño_veh, administrador)" +
                    " VALUES (@nombre, @pape,@sape, @user,@contra,@adminse,@dveh,@admin)";


                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };

                comanda.Parameters.AddWithValue("@nombre", u.Nombre);
                comanda.Parameters.AddWithValue("@pape", u.ApellidoUno);
                comanda.Parameters.AddWithValue("@sape", u.ApellidoDos);
                comanda.Parameters.AddWithValue("@user", u.User);
                comanda.Parameters.AddWithValue("@contra", u.Password);
                comanda.Parameters.AddWithValue("@adminse", u.AdminSede);
                comanda.Parameters.AddWithValue("@dveh", u.DueñoVehiculo);
                comanda.Parameters.AddWithValue("@admin", u.Admin);


                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                e.Source = "Problemas al Insertar el usuario ";

            }
        }


    public Usuario Iniciar(Usuario u)
    {
        SqlCommand comando = new SqlCommand();
        comando.Connection = conexion.AbrirConexion();
        comando.CommandText = "select id_usuario,usuario,contrasenna,activo,administrador, administrador_sede, dueño_veh from usuarios where (usuario like @usuario) and (contrasenna like  @contrasenna)";
        comando.Parameters.AddWithValue("@usuario", u.User);
        comando.Parameters.AddWithValue("@contrasenna", u.Password);
        SqlDataReader rs = comando.ExecuteReader();

        if (rs.Read())
        {
            u = Carga(rs);
        }
        conexion.CerrarConexion();
        return u;
    }
    private Usuario Carga(SqlDataReader rs)
    {
        Usuario usu = new Usuario
        {
            ID = rs.GetInt32(0),
            User = rs.GetString(1),
            Password = rs.GetString(2),
            Activo = rs.GetBoolean(3),
            Admin = rs.GetBoolean(4),
            AdminSede = rs.GetBoolean(5),
            DueñoVehiculo = rs.GetBoolean(6)


        };
        return usu;
    }

}

}
