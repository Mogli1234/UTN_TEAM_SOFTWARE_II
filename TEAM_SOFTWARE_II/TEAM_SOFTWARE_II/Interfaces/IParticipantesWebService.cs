using System;
using System.ServiceModel;
using AccesoDatos;
using System.Collections.Generic;
using AccesoDatos.Modelo;


namespace TEAM_SOFTWARE_II.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IParticipantesWebService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IParticipantesWebService
    {
        [OperationContract]
        Boolean InsertarParticipante(participante oParticipante);

        [OperationContract]
        Boolean EditarParticipante(participante oParticipante);

        [OperationContract]
        Boolean EliminarParticipante(participante oParticipante);

        [OperationContract]
        List<participante> ListadoParticipantes();
    }
}
