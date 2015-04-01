using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoDatos;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RutinasWebService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RutinasWebService.svc o RutinasWebService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RutinasWebService : IRutinas
    {
        Rutinas oRutinas = new Rutinas(); 

        public bool CrearRutina(rutina rutinas)
        {
            return oRutinas.InsertarRutina(rutinas);
        }

        public bool EditarRutina(rutina oRutinas)
        {
            throw new NotImplementedException();
        }

    }
}
