using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
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
                   var deleted = (from n in modelo.deportes where n.id == oSport.id select n).FirstOrDefault();

                   if (deleted != null)
                   {
                       modelo.deportes.Remove(deleted);
                       modelo.SaveChanges();
                       estado = true;     
                   }
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
                   modelo.deportes.AddOrUpdate(oSport);
                   modelo.SaveChanges();
                   estado = true;
               }
           }
           catch (Exception)
           {
               return estado;
           }
           return estado;
       }
       #endregion

       #region Charger Sport
       public List<Sport> Charge_Sports() 
       {
           List<Sport> sportsList = new List<Sport>();
           var queryAllSports = from sport in modelo.deportes
                                select sport;

           foreach (var data in queryAllSports.ToList())
           {
               sportsList.Add(new Sport()
               {
                   id = data.id,
                   deporte = data.Deporte1,
                   description = data.Descripcion
               });
           }
           return sportsList;
       }
       #endregion
    }
}
