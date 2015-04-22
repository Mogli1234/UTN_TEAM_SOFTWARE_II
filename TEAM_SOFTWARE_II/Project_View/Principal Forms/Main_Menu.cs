using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Entidades;
using Project_View.Principal_Forms;

namespace Project_View
{
    public partial class Main_Menu : Form
    {
        private int is_admin = 0;
        public Main_Menu(int admin)
        {
            InitializeComponent();
            is_admin = admin;
            
        }

        private void crearDeporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Sport de = new Create_Sport();
            de.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frm_Login lo = new frm_Login();
            lo.Show();
            this.Hide();
        }

        private void verDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewParticipantes view = new frm_ViewParticipantes();
            view.ShowDialog();
        }

        private void crearRutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Routine oRut = new Create_Routine();
            oRut.ShowDialog();
        }

        private void verRutinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_VerRutinas oVr = new frm_VerRutinas();
            oVr.ShowDialog();
        }

        private void rutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EditarRutinas oEdRutinas = new frm_EditarRutinas();
            oEdRutinas.ShowDialog();
        }

        private void dtnEditSport_Click(object sender, EventArgs e)
        {
            Edit_Sport edi = new Edit_Sport();
            edi.ShowDialog();
        }


        private void btnAsignar_Click(object sender, EventArgs e)
        {
            frm_AssingRutina assign = new frm_AssingRutina();
            assign.ShowDialog();
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            frm_AssingRutina assing = new frm_AssingRutina();
            assing.ShowDialog();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            frm_Participante parti = new frm_Participante();
            parti.ShowDialog();
        }

        private void btnAssigSport_Click(object sender, EventArgs e)
        {
            frm_assignar_sport assig = new frm_assignar_sport();
            assig.ShowDialog();
        }

        private void enviarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sed_Mail mail = new Sed_Mail();
            mail.ShowDialog();
        }

        private void participanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Participante oPartic = new frm_Participante();
            oPartic.ShowDialog();
        }

        private void verParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewParticipante oVerPartic = new frm_ViewParticipante();
            oVerPartic.ShowDialog();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            if (is_admin == 0)
            {
                crearDeporte.Enabled = false;
                btnParticipante.Enabled = false;
                crearRutina.Enabled = false;
                btnEditSport.Enabled = false;
                rutina.Enabled = false;
                editparticipante.Enabled = false;
            }
        }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
