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
    public class VehiculoDAL
    {
        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        readonly Vehiculo v = new Vehiculo();

        public DataTable Lista()
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand
                {
                    Connection = conexion.AbrirConexion(),
                    CommandText = "select id,dueño,num_placa,color,marca,modelo,anno,tipo,costo_dia,activo from vehiculos where activo =1"
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

        public void Actualizar(Vehiculo v)
        {
            try
            {
                string query = "Update vehiculos SET dueño = @nombre,num_placa =  @placa," +
                    " color = @color,marca = @marca,modelo = @modelo,anno = @anno,tipo = @tipo,costo_dia = @costo WHERE id = @id";

                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", v.ID);
                comanda.Parameters.AddWithValue("@nombre", v.User);
                comanda.Parameters.AddWithValue("@placa", v.NumPlaca);
                comanda.Parameters.AddWithValue("@color", v.Color);
                comanda.Parameters.AddWithValue("@marca", v.Marca);
                comanda.Parameters.AddWithValue("@modelo", v.Modelo);
                comanda.Parameters.AddWithValue("@anno", v.Año);
                comanda.Parameters.AddWithValue("@tipo", v.Tipo);
                comanda.Parameters.AddWithValue("@costo", v.CostoDia);

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
                e.Source = "Problemas al actualizar el vehiculo ";
            }
        }

        public void Eliminar(Vehiculo v)
        {
            try
            {
                string query = "UPDATE vehiculos  SET activo = 0 where id= @id";
                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id", v.ID);
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                e.Source = "Problemas al eliminar el vehiculo ";

            }
        }

        public void Insertar(Vehiculo v)
        {
            try
            {
                string query = "INSERT INTO vehiculos(dueño,num_placa,color,marca,modelo,anno,tipo,costo_dia)" +
                    " VALUES (@nombre, @placa,@color, @marca,@modelo,@anno,@tipo,@costo)";


                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };

                comanda.Parameters.AddWithValue("@nombre", v.User);
                comanda.Parameters.AddWithValue("@placa", v.NumPlaca);
                comanda.Parameters.AddWithValue("@color", v.Color);
                comanda.Parameters.AddWithValue("@marca", v.Marca);
                comanda.Parameters.AddWithValue("@modelo", v.Marca);
                comanda.Parameters.AddWithValue("@anno", v.Año);
                comanda.Parameters.AddWithValue("@tipo", v.Tipo);
                comanda.Parameters.AddWithValue("@costo", v.CostoDia);

                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                e.Source = "Problemas al Insertar el vehiculo ";

            }
        }


        public List<Usuario> ObtenerUser()
        {
            List<Usuario> listas = new List<Usuario>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id, usuario from usuarios where activo = 1 and dueño_veh = 1 ";
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Usuario c = new Usuario()
                {
                    ID = leer.GetInt32(0),
                    User = leer.GetString(1)
                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            return listas;
        }
    }

}
