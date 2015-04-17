using System;
using System.Collections.Generic;
using System.ServiceModel;
using AccesoDatos;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDeportesWebService
    {
        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        Boolean createSport(deporte sport);

        [OperationContract]
        List<Sport> ChargeSportsList();

        [OperationContract]
        Boolean DeleteSport(deporte oSport);



    }
    
}
