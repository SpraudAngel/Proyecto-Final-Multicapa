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
    public class D_Rutas
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
        public List<E_Rutas> ListarRutas(string buscar)
        {
            SqlDataReader Leerfilas;
            SqlCommand comand = new SqlCommand("SP_BUSCARRUTAS", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@BUSCAR", buscar);

            Leerfilas = comand.ExecuteReader();

            List<E_Rutas> Listar = new List<E_Rutas>();

            while (Leerfilas.Read())
            {
                Listar.Add(new E_Rutas
                {
                    IdRuta1 = Leerfilas.GetInt32(0),
                    NombreRuta1 = Leerfilas.GetString(1),
                    ComienzoRuta1 = Leerfilas.GetString(2),
                    FinRuta1 = Leerfilas.GetString(3),
                });
            }
            Conexion.Close();
            Leerfilas.Close();

            return Listar;

        }

        public void InsertarRutas(E_Rutas rutas)
        {
            SqlCommand comand = new SqlCommand("SP_INSERTARRUTAS", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@NOMBRE", rutas.NombreRuta1);
            comand.Parameters.AddWithValue("@COMIENZO", rutas.ComienzoRuta1);
            comand.Parameters.AddWithValue("@FIN", rutas.FinRuta1);

            comand.ExecuteNonQuery();
            Conexion.Close();

        }

        public void EditarRutas(E_Rutas rutas)
        {
            SqlCommand comand = new SqlCommand("SP_EDITARRUTAS", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDRUTA", rutas.IdRuta1);
            comand.Parameters.AddWithValue("@NOMBRE", rutas.NombreRuta1);
            comand.Parameters.AddWithValue("@COMIENZO", rutas.ComienzoRuta1);
            comand.Parameters.AddWithValue("@FIN", rutas.FinRuta1);

            comand.ExecuteNonQuery();
            Conexion.Close();

        }

        public void EliminarRutas(E_Rutas rutas)
        {
            SqlCommand comand = new SqlCommand("SP_ELIMINARRUTAS", Conexion);
            comand.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            comand.Parameters.AddWithValue("@IDCHOFER", rutas.IdRuta1);

            comand.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
