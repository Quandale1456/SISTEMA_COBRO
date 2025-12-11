using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_COBRO
{
    public class DatosGetUsuarios
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public DatosGetUsuarios()
        {
            Codigo = 0;
            Nombre = "";
            Correo = "";
            Contraseña= "";
        }

        public DatosGetUsuarios(int PCodigo, string PNombre, string PCorreo, string PContraseña)
        {
            Codigo = PCodigo;
            Nombre = PNombre;
            Correo = PCorreo;
            Contraseña = PContraseña;
        }

    }
}
