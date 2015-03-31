using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using AccesoDatos.Modelo;
using Project_View.Servicios;

namespace Project_View
{
    public partial class Create_Routine : Form
    {
        Servicios.TEAM_SOFTWAREClient oClient;
        rutina oRutina;
        public Create_Routine()
        {
            InitializeComponent();
            oClient = new TEAM_SOFTWAREClient();
            oRutina = new rutina();
        }

        private void Create_Routine_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu oMainMenu = new MainMenu();
            oMainMenu.Focus();
            this.Close();

        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            oRutina.Rutina1= txtRutina.Text;
            if (txtRutina.Text!=null)
            {
                MessageBox.Show("Se ha agregado con exito el deporte", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error a la hora de crear", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Limpiar();
            }
        }

        public void Limpiar()
        {
            this.txtRutina.Clear();
            this.txtRutina.Focus();
        }
    }
}
