using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelo;

namespace AccesoDatos.Entidades
{
    public class Usuario
    {
        public int id { get; set; }

        public String Nombre { get; set; }

        public String Apellido1 { get; set; }

        public String Apellido2 { get; set; }

        public String Email { get; set; }

        public sbyte Role { get; set; }

    }
}
