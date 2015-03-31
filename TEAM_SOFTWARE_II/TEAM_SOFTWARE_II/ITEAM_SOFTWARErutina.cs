using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II
{
    [ServiceContract]
    public interface ITEAM_SOFTWARErutina
    {

        [OperationContract]
        string GetData(int value);

        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        Boolean CrearRutina(Rutinas oRutinas);

        [OperationContract]
        Boolean EditarRutina(Rutinas oRutinas);
    }
}
