using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AccesoDatos;
using AccesoDatos.Modelo;
using TEAM_SOFTWARE_II.Interfaces;

namespace TEAM_SOFTWARE_II
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DeportesWebService : IDeportesWebService
    {
        Deportes deportes = new Deportes();
       
        public bool createSport(deporte sport)
        {
            return deportes.crearDeporte(sport);
        }

        public List<Sport> ChargeSportsList()
        {
            return deportes.Charge_Sports();
        }

        public bool DeleteSport(deporte oSport)
        {
            return deportes.DeleteSport(oSport);
        }

        public bool UpdateSport(deporte oSport)
        {
            return deportes.UpdateSport(oSport);
        }
    }
}
