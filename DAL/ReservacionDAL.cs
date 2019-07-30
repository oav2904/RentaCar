using System;
using System.Collections.Generic;
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
        Vehiculo v = new Vehiculo();


        public object ObtenerUser()
        {
            List<Cliente> listas = new List<Cliente>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id, nombre from clientes where activo = 1";
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
            comando.Connection = conexion.CerrarConexion();
            return listas;
        }

        public object ObtenerVehiculo()
        {
            List<Vehiculo> listas = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id, marca from vehiculos where activo = 1 ";
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Vehiculo c = new Vehiculo()
                {
                    ID = leer.GetInt32(0),
                    Marca = leer.GetString(1)
                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            return listas;
        }

        public object ObtenerModelo(string v)
        {
            List<Vehiculo> listas = new List<Vehiculo>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select id, modelo from vehiculos where activo = 1 and marca like '@dato'";
            comando.Parameters.AddWithValue("@dato", v);
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Vehiculo c = new Vehiculo()
                {
                    ID = leer.GetInt32(0),
                    Modelo = leer.GetString(1)
                   
                };
                listas.Add(c);
            }
            comando.Connection = conexion.CerrarConexion();
            return listas;
        }
    }
}
