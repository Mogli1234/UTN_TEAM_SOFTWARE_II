using System;
using System.Collections.Generic;
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

       #region Metodo de insertar deportes
       //Metodo de insertar deportes
       public Boolean crearDeporte(deporte sport)
       {
           bool estado = false;
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


    }
}
