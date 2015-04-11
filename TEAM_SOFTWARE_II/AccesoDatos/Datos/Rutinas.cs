using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelo;
using System.Windows;

namespace AccesoDatos
{
    public class Rutinas
    {
        UTN_SPORTS_ModelContainer oUtnSportsContainer = new UTN_SPORTS_ModelContainer();
        private Boolean estado = false;

        #region Insertar o crear una rutina
        public Boolean InsertarRutina(rutina oRutina)
        {
            try
            {
                if (oRutina != null)
                {
                    oUtnSportsContainer.rutinas.Add(oRutina);
                    oUtnSportsContainer.SaveChanges();
                    this.estado = true;
                }
            }
            catch (Exception e)
            {
               // throw e;
                return estado;
            }
            return estado;
        }
        #endregion

        #region Editar Una rutina
        public Boolean Editarrutina(rutina oRutina)
        {
            try
            {
                oUtnSportsContainer.rutinas.AddOrUpdate(oRutina);
                oUtnSportsContainer.SaveChanges();
                estado = true;
            }
            catch (Exception e)
            {
                throw e;
                return estado;
            }
            return estado;
        }
        #endregion

        #region Eliminar una rutina localizandola por su "id"
        public Boolean EliminarRutina(rutina oRutina)
        {
            try
            {
                oUtnSportsContainer.rutinas.Remove(oRutina);
            oUtnSportsContainer.SaveChanges();
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
    }
}
