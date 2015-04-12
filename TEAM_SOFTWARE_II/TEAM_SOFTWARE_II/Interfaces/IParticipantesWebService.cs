using System.ServiceModel;

namespace TEAM_SOFTWARE_II.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IParticipantesWebService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IParticipantesWebService
    {
        [OperationContract]
        void DoWork();
    }
}
