using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_diarias.Capa_Entidad.Capa_Datos
{
    using System.Data.SqlClient;

    public class Conexion
    {
        private static string cadena = "Server=.;Database=PerrosDB;Trusted_Connection=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }

}
