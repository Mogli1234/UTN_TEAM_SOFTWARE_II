using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoDatos;
using AccesoDatos.Datos;
using AccesoDatos.Entidades;
using AccesoDatos.Modelo;
using TEAM_SOFTWARE_II.Interfaces;

namespace TEAM_SOFTWARE_II
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ParticipantesWebService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ParticipantesWebService.svc o ParticipantesWebService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ParticipantesWebService : IParticipantesWebService
    {
        private Participantes partis = new Participantes();

        public bool InsertarParticipante(participante oParticipante)
        {
            return partis.InsertarParticipante(oParticipante);
        }

        public bool EditarParticipante(participante oParticipante)
        {
            return partis.EditarParticipante(oParticipante);
        }

        public bool EliminarParticipante(participante oParticipante)
        {
            return partis.EliminarParticipante(oParticipante);
        }

        public List<participante> ListadoParticipantes()
        {
            return partis.CargarParticipantes();
        }

        public List<Participante> FiltList(Participante oparti)
        {
            return FiltList(oparti);
        }
    }
}
