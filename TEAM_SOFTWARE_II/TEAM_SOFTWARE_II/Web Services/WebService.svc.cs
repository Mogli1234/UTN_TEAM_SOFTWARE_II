using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AccesoDatos;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WebService : ITEAM_SOFTWARE
    {
        Deportes deportes = new Deportes();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool createSport(deporte sport)
        {
            return deportes.crearDeporte(sport);
        }

        public List<deporte> ChargeSportsList()
        {
            return deportes.Charge_Sports();
        }

        
    }
}
