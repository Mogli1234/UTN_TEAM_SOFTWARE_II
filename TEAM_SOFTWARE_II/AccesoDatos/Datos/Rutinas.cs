using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelo;
using System.Windows;
using System.Windows.Forms;
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
                estado = false;
            }
            return estado;
        }
        #endregion

        #region Editar Una rutina
        public Boolean EditarRutina(rutina oRutina)
        {
            try
            {
                oRutinasContainer.rutinas.AddOrUpdate(oRutina);
                oRutinasContainer.SaveChanges();
                estado = true;
            }
            catch (Exception)
            {
                estado = false;
            }
            return estado;
        }
        #endregion

        #region Eliminar una rutina localizandola por su "id"
        public Boolean EliminarRutina(rutina oRutina)
        {
            try
            {
                if (oRutina != null)
                {
                    var delRutina = (from r in oRutinasContainer.rutinas where r.id == oRutina.id select r).FirstOrDefault();
                    if (delRutina != null)
                    {
                        oRutinasContainer.rutinas.Remove(delRutina);
                        oRutinasContainer.SaveChanges();
                        estado = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return estado;
        }
        #endregion

        #region Cargar lista con tabla de base datos
        public List<Rutina> Charge_Rutinas()
        {
            List<Rutina> listaRutinas = new List<Rutina>();
            try
            {
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
            }
            catch (Exception)
            {
                estado = false;
            }
            return listaRutinas;
        }
        #endregion
    }
}