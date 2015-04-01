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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITEAM_SOFTWARE
    {
        [OperationContract]
        string GetData(int value);

        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        Boolean createSport(deporte sport);
    }
    
}
