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
    public class D_Autobuses
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public List<E_Autobuses> ListarAutobuses(string buscar)
        {
            SqlDataReader Leerfilas;
            SqlCommand comand = new SqlCommand("SP_BUSCARAUTOBSUES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@BUSCAR", buscar);

            Leerfilas = comand.ExecuteReader();

            List<E_Autobuses> Listar = new List<E_Autobuses>();

            while (Leerfilas.Read())
            {
                Listar.Add(new E_Autobuses
                {
                    IdAutobus1 = Leerfilas.GetInt32(0),
                    MarcaAutobus1 = Leerfilas.GetString(1),
                    ModeloAutobus1 = Leerfilas.GetString(2),
                    MatriculaAutobus1 = Leerfilas.GetString(3),
                    ColorAutobus1 = Leerfilas.GetString(4),
                    AnoAutobus1 = Leerfilas.GetString(5)
                });
            }
            Conexion.Close();
            Leerfilas.Close();

            return Listar;

        }

        public void InsertarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand comand = new SqlCommand("SP_INSERTARAUTOBUSES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@MARCA", autobuses.MarcaAutobus1);
            comand.Parameters.AddWithValue("@MODELO", autobuses.ModeloAutobus1); ;
            comand.Parameters.AddWithValue("@MATRICULA", autobuses.MatriculaAutobus1);
            comand.Parameters.AddWithValue("@COLOR", autobuses.ColorAutobus1);
            comand.Parameters.AddWithValue("@ANO", autobuses.AnoAutobus1);

            comand.ExecuteNonQuery();
            Conexion.Close();

        }

        public void EditarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand comand = new SqlCommand("SP_EDITARAUTOBUSES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDAUTOBUSES", autobuses.IdAutobus1);
            comand.Parameters.AddWithValue("@MARCA", autobuses.MarcaAutobus1);
            comand.Parameters.AddWithValue("@MODELO", autobuses.ModeloAutobus1); ;
            comand.Parameters.AddWithValue("@MATRICULA", autobuses.MatriculaAutobus1);
            comand.Parameters.AddWithValue("@COLOR", autobuses.ColorAutobus1);
            comand.Parameters.AddWithValue("@ANO", autobuses.AnoAutobus1);

            comand.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarAutobuses(E_Autobuses autobuses)
        {
            SqlCommand comand = new SqlCommand("SP_ELIMINARAUTOBUSES", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDAUTOBUS", autobuses.IdAutobus1);

            comand.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}

