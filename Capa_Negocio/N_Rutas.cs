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
    public class N_Rutas
    {
        D_Rutas objDatos = new D_Rutas();

        public List<E_Rutas> ListadoRutas(string buscar)
        {
            return objDatos.ListarRutas(buscar);
        }

        public void InsertarRutas(E_Rutas rutas)
        {
            objDatos.InsertarRutas(rutas);
        }

        public void EditarRutas(E_Rutas rutas)
        {
            objDatos.EditarRutas(rutas);
        }

        public void EliminarRutas(E_Rutas rutas)
        {
            objDatos.EliminarRutas(rutas);
        }
    }
}
