using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelo;

namespace AccesoDatos
{
   public class Deportes
    {
       UTN_SPORTS_ModelContainer modelo = new UTN_SPORTS_ModelContainer();
       private bool estado = false;
       

        #region Metodo de insertar deportes
       //Metodo de insertar deportes
       public Boolean crearDeporte(deporte sport)
       {
           try
           {
               if (sport != null)
               {
                   modelo.deportes.Add(sport);
                   modelo.SaveChanges();
                   estado = true;
               }
           }
           catch (ModelValidationException e)
           {
               throw e;
           }
           return estado;
       }
       #endregion

        #region Metodo de Eliminar los deportes
       public Boolean DeleteSport(deporte oSport)
       {
           try
           {
               if (oSport != null)
               {
                   modelo.deportes.Remove(oSport);
                   estado = true;
               }

           }
           catch (ModelValidationException e)
           {
               throw e;
           }
           return estado;
       }
       #endregion

        #region Metodo de actualizar

       public Boolean UpdateSport(deporte oSport)
       {
           try
           {
               if (oSport != null)
               {
                   modelo.deportes.Add(oSport);
                   modelo.SaveChanges();
                   estado = true;
               }
           }
           catch (Exception e)
           {

               return estado;
           }
           return estado;
       }

       #endregion

       public List<Modelo.deporte> Charge_Sports()
       {
           List<deporte> sportsList = new List<deporte>();
           var queryAllSports = from sport in modelo.deportes
                                select sport;
           foreach (var datos in queryAllSports)
           {
               sportsList.Add(datos);
           }
           return sportsList;

       }
    }
}
