using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Pruebas_diarias.Capa_Entidad.Capa_Datos;
using Pruebas_diarias.Capa_Entidad;

public class PerroDAO
{
    public static void Agregar(Perro p)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("sp_AgregarPerro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Raza", p.Raza);
            cmd.Parameters.AddWithValue("@Edad", p.Edad);
            cmd.Parameters.AddWithValue("@Vacunas", p.Vacunas);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static void Editar(Perro p)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("sp_EditarPerro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", p.Id);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Raza", p.Raza);
            cmd.Parameters.AddWithValue("@Edad", p.Edad);
            cmd.Parameters.AddWithValue("@Vacunas", p.Vacunas);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static void Eliminar(int id)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarPerro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static List<Perro> Buscar(string nombre)
    {
        List<Perro> lista = new List<Perro>();
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("sp_BuscarPerro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Perro
                {
                    Id = (int)dr["Id"],
                    Nombre = dr["Nombre"].ToString(),
                    Raza = dr["Raza"].ToString(),
                    Edad = (int)dr["Edad"],
                    Vacunas = dr["Vacunas"].ToString()
                });
            }
        }
        return lista;
    }

    public static List<Perro> Listar()
    {
        List<Perro> lista = new List<Perro>();
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("sp_ListarPerros", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Perro
                {
                    Id = (int)dr["Id"],
                    Nombre = dr["Nombre"].ToString(),
                    Raza = dr["Raza"].ToString(),
                    Edad = (int)dr["Edad"],
                    Vacunas = dr["Vacunas"].ToString()
                });
            }
        }
        return lista;
    }
}
