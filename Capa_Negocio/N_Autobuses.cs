using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Capa_de_datos;
using Capa_de_entidad;


namespace Capa_de_negocios
{
    public class N_Autobuses
    {
        D_Autobuses objDatos = new D_Autobuses();

        public List<E_Autobuses> ListadoAutobuses(string buscar)
        {
            return objDatos.ListarAutobuses(buscar);
        }

        public void InsertarAutobuses(E_Autobuses autobuses)
        {
            objDatos.InsertarAutobuses(autobuses);
        }

        public void EditarAutobuses(E_Autobuses autobuses)
        {
            objDatos.EditarAutobuses(autobuses);
        }

        public void EliminarAutobuses(E_Autobuses autobuses)
        {
            objDatos.EliminarAutobuses(autobuses);
        }
    }
}

