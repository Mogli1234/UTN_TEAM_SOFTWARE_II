using System.ServiceModel;

namespace TEAM_SOFTWARE_II.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuariosWebService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuariosWebService
    {
        [OperationContract]
        void DoWork();
    }
}
