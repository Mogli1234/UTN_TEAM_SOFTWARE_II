using System;
using System.ServiceModel;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II.Interfaces
{
    [ServiceContract]
    public interface IRutinas
    {

        //[OperationContract]
        //string GetData(int value);

        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        Boolean CrearRutina(rutina Rutinas);

        [OperationContract]
        Boolean EditarRutina(rutina oRutinas);
    }
}
