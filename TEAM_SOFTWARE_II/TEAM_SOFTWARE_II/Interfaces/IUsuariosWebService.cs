﻿using System;
using System.ServiceModel;
using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.Entidades;
using AccesoDatos.Modelo;

namespace TEAM_SOFTWARE_II.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuariosWebService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuariosWebService
    {
        [OperationContract]
        Boolean NewUser(user oUser);
        [OperationContract]
        int VerifyUsers(string username, string password);

        [OperationContract]
        List<User> ChargeList();
    }
}
