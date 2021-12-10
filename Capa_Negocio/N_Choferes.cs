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
    public class N_Choferes
    {
        D_Choferes objDatos = new D_Choferes();

        public List<E_Choferes> ListadoChoferes(string buscar)
        {
            return objDatos.ListarChoferes(buscar);
        }

        public void InsertarChoferes(E_Choferes choferes)
        {
            objDatos.InsertarChoferes(choferes);
        }

        public void EditarChoferes(E_Choferes choferes)
        {
            objDatos.EditarChoferes(choferes);
        }

        public void EliminarChoferes(E_Choferes choferes)
        {
            objDatos.EliminarChoferes(choferes);
        }
    }
}

