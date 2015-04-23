using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Entidades;
using AccesoDatos.Modelo;

namespace AccesoDatos.Datos
{
    public class Participantes
    {
        private UTN_SPORTS_ModelContainer oModelContainer;
        private bool estado;

        public Participantes()
        {
            oModelContainer = new UTN_SPORTS_ModelContainer();
            estado = false;
        }

        #region Insertar paticipante
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return estado;
        }
        #endregion

        #region Editar participante
        public Boolean EditarParticipante(participante oParticipante)
        {
            try
            {
                if (oParticipante != null)
                {
                    oModelContainer.participantes.AddOrUpdate(oParticipante);
                    oModelContainer.SaveChanges();
                    estado = true;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString());
            }
            return estado;
        }
        #endregion

        #region Eliminar un participante
        public Boolean EliminarParticipante(participante oParticipante)
        {
            try
            {
                if (oParticipante != null)
                {
                    var elimParti = (from p in oModelContainer.participantes where p.id == oParticipante.id select p).FirstOrDefault();
                    if (elimParti != null)
                    {
                        oModelContainer.participantes.Remove(elimParti);
                        oModelContainer.SaveChanges();
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

        #region Crear lista con participantes
        public List<participante>CargarParticipantes()
        {
            List<participante> oList = new List<participante>();
            try
            {
                if (oList!=null)
                {
                    var todosParticipantes = from p in oModelContainer.participantes select p;
                    foreach (var parti in todosParticipantes.ToList())
                    {
                        oList.Add(new participante()
                        {
                            id = parti.id,
                            Nombre = parti.Nombre,
                            Primer_Apellido = parti.Primer_Apellido,
                            Segundo_Apellido = parti.Segundo_Apellido,
                            Edad = parti.Edad,
                            Fecha_Ingreso = parti.Fecha_Ingreso
                        });
                    }
                }
                estado = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return oList;
        }
        #endregion


    }
}
