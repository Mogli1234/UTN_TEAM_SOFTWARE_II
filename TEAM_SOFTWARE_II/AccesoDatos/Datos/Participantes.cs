using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using AccesoDatos.Modelo;

namespace AccesoDatos.Datos
{
   public class Participantes
    {
       UTN_SPORTS_ModelContainer oModelContainer = new UTN_SPORTS_ModelContainer();
       private bool estado = false;

        #region Insertar participantes
       public Boolean InsertarParticipante(participante oParticipante)
       {
           try
           {
               if (oParticipante != null)
               {
                   oModelContainer.participantes.Add(oParticipante);
                   oModelContainer.SaveChanges();
                   estado = true;
               }
           }
           catch (Exception error)
           {
               
               throw error;
               return estado;
           }
           return estado;
       }
        #endregion

        #region Modificar un participante
       public Boolean EditarParticipante(participante oParticipante)
       {
           try
           {
               if (oParticipante !=null)
               {
                   oModelContainer.participantes.AddOrUpdate(oParticipante);
                   oModelContainer.SaveChanges();
                   estado = true;
               }
           }
           catch (Exception error)
           {

               throw error;
               return estado;
           }
           return estado;
       }
        #endregion

       #region Eliminar participantes
       public Boolean EliminarParticipante(participante oParticipante)
       {
           try
           {
               if (oParticipante != null)
               {
                   oModelContainer.participantes.Remove(oParticipante);
                   oModelContainer.SaveChanges();
                   estado = true;
               }
           }
           catch (Exception error)
           {
               
               throw error;
               return estado;
           }
           return estado;
       }
       #endregion

       /*
       #region Cargar participantes....
       public Boolean ConsultaParticipantes(participante oParticipante)
       {
           var query = from oParticipante in oModelContainer.participantes
                       where oParticipante.id = oModelContainer.participantes.Select(oParticipante);
                       select oParticipante;
           estado = true;
           IEnumerable<participante> participantes = query.ToList();
           return estado;
       }
       #endregion 
       */

    }
}
