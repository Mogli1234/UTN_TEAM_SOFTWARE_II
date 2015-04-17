using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelo;
using System.Windows;
using AccesoDatos.Entidades;

namespace AccesoDatos
{
    public class Rutinas
    {
        UTN_SPORTS_ModelContainer oRutinasContainer = new UTN_SPORTS_ModelContainer();
        private Boolean estado = false;

        #region Insertar o crear una rutina
        public Boolean InsertarRutina(rutina oRutina)
        {
            try
            {
                if (oRutina != null)
                {
                    oRutinasContainer.rutinas.Add(oRutina);
                    oRutinasContainer.SaveChanges();
                    this.estado = true;
                }
            }
            catch (Exception)
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
                oRutinasContainer.rutinas.AddOrUpdate(oRutina);
                oRutinasContainer.SaveChanges();
                estado = true;
            }
            catch (Exception )
            {
                
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
                oRutinasContainer.rutinas.Remove(oRutina);
            oRutinasContainer.SaveChanges();
                estado = true;
            }
            catch (Exception)
            {

                
                return estado;
            }
            return estado;
        }
        #endregion

        #region Cargar lista con tabla de base datos
        public List<Rutina> Charge_Sports()
        {
            List<Rutina> listaRutinas = new List<Rutina>();
            var queryAllRutinas = from rutin in oRutinasContainer.rutinas
                                 select rutin;

            foreach (var data in queryAllRutinas)
            {
                listaRutinas.Add(new Rutina()
                {
                    id = data.id,
                    rutina = data.Rutina1
                });
            }
            return listaRutinas;
        }
        #endregion
    }
}