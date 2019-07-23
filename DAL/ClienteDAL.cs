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
    public class ClienteDAL
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        Cliente c = new Cliente();

        public DataTable Lista()
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select * from clientes where activo =1";
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

        public void Actualizar(Cliente c)
        {
            try
            {
                string query = "Update clientes SET nombre = @nombre,primer_apellido =  @ape1," +
                    " segundo_apellido = @ape2,cedula = @cedula WHERE id = @id";

                SqlCommand comanda = new SqlCommand(query);
                comanda.Connection = conexion.AbrirConexion();
                comanda.Parameters.AddWithValue("@id", c.ID);
                comanda.Parameters.AddWithValue("@nombre", c.Nombre);
                comanda.Parameters.AddWithValue("@ape1", c.ApellidoUno);
                comanda.Parameters.AddWithValue("@ape2", c.ApellidoDos);
                comanda.Parameters.AddWithValue("@cedula", c.Cedula);
                
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
                e.Source = "Problemas al actualizar el cliente ";
            }
        }

        public void Eliminar(Cliente c)
        {
            try
            {
                string query = "UPDATE clientes  SET activo = 0 where id= @id";
                SqlCommand comanda = new SqlCommand(query);
                comanda.Connection = conexion.AbrirConexion();
                comanda.Parameters.AddWithValue("@id", c.ID);
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                e.Source = "Problemas al eliminar el cliente ";

            }
        }

        public void Insertar(Cliente c)
        {
            try
            {
                string query = "INSERT INTO clientes(nombre,primer_apellido,segundo_apellido,cedula)" +
                    " VALUES (@nombre, @ape1,@ape2, @cedula)";

                SqlCommand comanda = new SqlCommand(query);
                comanda.Connection = conexion.AbrirConexion();
                comanda.Parameters.AddWithValue("@nombre", c.Nombre);
                comanda.Parameters.AddWithValue("@ape1", c.ApellidoUno);
                comanda.Parameters.AddWithValue("@ape2", c.ApellidoDos);
                comanda.Parameters.AddWithValue("@cedula", c.Cedula);

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                e.Source = "Problemas al Insertar el cliente ";

            }
        }
    }
}
