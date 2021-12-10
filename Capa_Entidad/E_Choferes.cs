using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_entidad
{
    public class E_Choferes
    {
        private int IdChofer;
        private string NombreChofer;
        private string ApellidoChofer;
        private string FechaNacimientoChofer;
        private string CedulaChofer;

        public int IdChofer1 { get => (int)IdChofer; set => IdChofer = value; }
        public string NombreChofer1 { get => NombreChofer; set => NombreChofer = value; }
        public string ApellidoChofer1 { get => ApellidoChofer; set => ApellidoChofer = value; }
        public string FechaNacimientoChofer1 { get => FechaNacimientoChofer; set => FechaNacimientoChofer = value; }
        public string CedulaChofer1 { get => CedulaChofer; set => CedulaChofer = value; }
    }


}