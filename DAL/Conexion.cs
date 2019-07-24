using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class Conexion
    {

        private static readonly string CadenaConexion = "Data Source=.;Initial Catalog=ProyectoRentACar;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;

        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;

        }
    }

}
