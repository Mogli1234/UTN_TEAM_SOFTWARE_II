using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  AccesoDatos.Modelo;

namespace AccesoDatos.Datos
{
    class Users
    {
        UTN_SPORTS_ModelContainer oModelContainer = new UTN_SPORTS_ModelContainer();
        private bool estado = false;

        #region Creacion de un usuario
        public Boolean CrearUsuario(user oUser)
        {
            try
            {
                oModelContainer.users.Add(oUser);
                oModelContainer.SaveChanges();
                estado = true;
            }
            catch (Exception error)
            {
                
                throw error;
                return estado;
            }
            return estado;
        }
        #endregion

        #region Editar un usuario
        public Boolean EditarUsuario(user oUser)
        {
            try
            {
                oModelContainer.users.AddOrUpdate(oUser);
                oModelContainer.SaveChanges();
                estado = true;
            }
            catch (Exception error)
            {

                throw error;
                return estado;
            }
            return estado;
        }
        #endregion

        #region Eliminar un usuario
        public Boolean EliminarUsuario(user oUser)
        {
            try
            {
                oModelContainer.users.Remove(oUser);
                oModelContainer.SaveChanges();
                estado = true;
            }
            catch (Exception error)
            {

                throw error;
                return estado;
            }
            return estado;
        }
        #endregion

        #region Consultar un usuario

        public Boolean ConsultaUsuario()
        {

            //  oModelContainer.users.Select();
            estado = true;

            return estado;
        }
        #endregion

    }
}
