using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Capa_de_entidad;

namespace Capa_de_datos
{
    public class D_Choferes
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public List<E_Choferes> ListarChoferes(string buscar)
        {
            SqlDataReader Leerfilas;
            SqlCommand comand = new SqlCommand("SP_BUSCARCHOFERES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@BUSCAR", buscar);

            Leerfilas = comand.ExecuteReader();

            List<E_Choferes> Listar = new List<E_Choferes>();

            while (Leerfilas.Read())
            {
                Listar.Add(new E_Choferes
                {
                    IdChofer1 = Leerfilas.GetInt32(0),
                    NombreChofer1 = Leerfilas.GetString(1),
                    ApellidoChofer1 = Leerfilas.GetString(2),
                    FechaNacimientoChofer1 = Leerfilas.GetString(3),
                    CedulaChofer1 = Leerfilas.GetString(4)
                });
            }
            Conexion.Close();
            Leerfilas.Close();

            return Listar;

        }

        public void InsertarChoferes(E_Choferes choferes)
        {
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
            SqlCommand comand = new SqlCommand("SP_INSERTARCHOFERES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@NOMBRE", choferes.NombreChofer1);
            comand.Parameters.AddWithValue("@APELLIDO", choferes.ApellidoChofer1);
            comand.Parameters.AddWithValue("@FECHANACIMIENTO", choferes.FechaNacimientoChofer1);
            comand.Parameters.AddWithValue("@CEDULA", choferes.CedulaChofer1);

            comand.ExecuteNonQuery();
            Conexion.Close();

        }

        public void EditarChoferes(E_Choferes choferes)
        {
            SqlCommand comand = new SqlCommand("SP_EDITARCHOFERES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDCHOFER", choferes.IdChofer1);
            comand.Parameters.AddWithValue("@NOMBRE", choferes.NombreChofer1);
            comand.Parameters.AddWithValue("@APELLIDO", choferes.ApellidoChofer1);
            comand.Parameters.AddWithValue("@FECHANACIMIENTO", choferes.FechaNacimientoChofer1);
            comand.Parameters.AddWithValue("@CEDULA", choferes.CedulaChofer1);

            comand.ExecuteNonQuery();
            Conexion.Close();
        }


        public void EliminarChoferes(E_Choferes choferes)
        {
            SqlCommand comand = new SqlCommand("SP_ELIMINARCHOFERES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDCHOFER", choferes.IdChofer1);

            comand.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}

