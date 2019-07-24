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
    public class SedeDAL
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        readonly Sede s = new Sede();

        public DataTable Lista()
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand
                {
                    Connection = conexion.AbrirConexion(),
                    CommandText = "select id,nombre,cuidad, canton, provincia, pais,activo from sedes where activo =1"
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

        public void Actualizar(Sede s)
        {
            try
            {
                string query = "Update sedes SET nombre =@nombre,cuidad =@city, canton =@canton, provincia = @provincia, " +
                    "pais = @pais WHERE id = @id";

                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", s.ID);
                comanda.Parameters.AddWithValue("@nombre", s.Nombre);
                comanda.Parameters.AddWithValue("@city", s.Ciudad);
                comanda.Parameters.AddWithValue("@canton", s.Canton);
                comanda.Parameters.AddWithValue("@provincia", s.Provincia);
                comanda.Parameters.AddWithValue("@pais", s.Pais);   

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
                e.Source = "Problemas al actualizar la sede ";
            }
        }

        public void Eliminar(Sede s)
        {
            try
            {
                string query = "UPDATE sedes  SET activo = 0 where id= @id";
                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", s.ID);
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                e.Source = "Problemas al eliminar la sede ";

            }
        }

        public void Insertar(Sede s)
        {
            try
            {
                string query = "INSERT INTO sedes(nombre,cuidad,canton, provincia, pais)" +
                    " VALUES (@nombre, @city,@canton, @provi,@pais)";


                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };

                comanda.Parameters.AddWithValue("@nombre", s.Nombre);
                comanda.Parameters.AddWithValue("@city", s.Ciudad);
                comanda.Parameters.AddWithValue("@canton", s.Canton);
                comanda.Parameters.AddWithValue("@provi", s.Provincia);
                comanda.Parameters.AddWithValue("@pais", s.Pais);  

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                e.Source = "Problemas al Insertar la sede ";

            }
        }


    }
}
