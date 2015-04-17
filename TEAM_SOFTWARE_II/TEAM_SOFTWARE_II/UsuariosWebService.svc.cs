using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoDatos.Datos;
using AccesoDatos.Modelo;
using TEAM_SOFTWARE_II.Interfaces;

namespace TEAM_SOFTWARE_II
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuariosWebService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UsuariosWebService.svc o UsuariosWebService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuariosWebService : IUsuariosWebService
    {
        Usuarios user = new Usuarios();

        public int VerifyUsers(string username, string password)
        {
            return user.is_Admin(username , password );
        }

        public bool NewUser(user oUser)
        {
            return user.InsertarUsuario(oUser);
        }
    }
}
