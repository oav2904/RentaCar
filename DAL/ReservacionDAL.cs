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
    public class ReservacionDAL
    {

        private Conexion conexion = new Conexion();
        private SqlDataReader leer;
        private SqlDataReader leer2;
        readonly Vehiculo v = new Vehiculo();

        public void Guardar(Reservacion r)
        {
            try
            {
                string query = "INSERT INTO reservaciones(vehiculo,fecha_inicio,fecha_final,cliente,costo)" +
                    " VALUES (@vehiculo, @fechaI,@fechaD, @cliente,@costo)";


                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };

                comanda.Parameters.AddWithValue("@vehiculo",r.Vehiculos);
                comanda.Parameters.AddWithValue("@fechaI",r.FechaInicio);
                comanda.Parameters.AddWithValue("@fechaD", r.FechaFinal);
                comanda.Parameters.AddWithValue("@cliente", r.Cliente);
                comanda.Parameters.AddWithValue("@costo", r.Costo);
               


                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
                leer.Close();

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                e.Source = "Problemas al crear la reservacion ";

            }
        }

        public void Facturar(int id)
        {
            try
            {
                string query = "UPDATE reservaciones  SET activo = 0 where id= @id";
                SqlCommand comanda = new SqlCommand(query)
                {
                    Connection = conexion.AbrirConexion()
                };
                comanda.Parameters.AddWithValue("@id",id);
                comanda.ExecuteNonQuery();
                comanda.Parameters.Clear();
                comanda.Connection = conexion.CerrarConexion();
                leer.Close();

            }
            catch (Exception e)
            {
                e.Source = "Problemas al facturar la reservación ";

            }
        }

        public object ObtenerUser()
        {
            List<Cliente> listas = new List<Cliente>();
            SqlCommand comando = new SqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "select id, nombre from clientes where activo = 1"
            };
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Cliente c = new Cliente ()
                {
                    ID = leer.GetInt32(0),
                    Nombre = leer.GetString(1)
                };
                listas.Add(c);
            }
            leer.Close();
            comando.Connection = conexion.CerrarConexion();
            return listas;
        }

        public object ObtenerVehiculo()
        {
            List<Vehiculo> listas = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "select marca from vehiculos where activo = 1 "
            };
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Vehiculo c = new Vehiculo()
                {
                    Marca = leer.GetString(0)
                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            leer.Close();
            return listas;
        }

        public DataTable Lista()
        {
            
                DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "select * from reservaciones where activo = 1",
               
            };
            leer = comando.ExecuteReader();
                tabla.Load(leer);
                leer.Close();
                comando.Connection = conexion.CerrarConexion();
            leer.Close();
                return tabla;
          
        }

    

        public object ObtenerCosto(string m)
        {
            List<Vehiculo> listas = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select costo_hora from vehiculos where activo = 1 and marca like @dato";
            
            Console.WriteLine(m + " Im here");
            comando.Parameters.AddWithValue("@dato", m);
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Vehiculo c = new Vehiculo()
                {
                    CostoDia = leer.GetInt32(0)

                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            leer.Close();
            return listas;
        }

        public object ObtenerModelo(string v)
        {
            List<Vehiculo> listas = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "select modelo from vehiculos where activo = 1 and marca like @dato"
            };
            comando.Parameters.AddWithValue("@dato", v);
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Vehiculo c = new Vehiculo()
                {
                    Modelo = leer.GetString(0)
                   
                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            leer.Close();

            return listas;
        }
    }
}
