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
        ServicioRutina.RutinasClient oClient = new ServicioRutina.RutinasClient();
        rutina oRutina = new rutina();
        public Create_Routine()
        {
            InitializeComponent();
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            oRutina.Rutina1 = txtRutina.Text;
            if (oClient.CrearRutina(oRutina))
            {
                MessageBox.Show("Se ha agregado con exito la rutina", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error a la hora de agregar la rutina", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Limpiar();
            }

        }

        public void Limpiar()
        {
            this.txtRutina.Clear();
            this.txtRutina.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Routine_Load(object sender, EventArgs e)
        {

        }

      
    }
}
