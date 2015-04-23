using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Modelo;
using Project_View.ServicioRutina;


namespace Project_View
{
    public partial class frm_EditarRutinas : Form
    {
        private RutinasClient oRutinasClient;
        private rutina oRutina;

        public frm_EditarRutinas()
        {
            InitializeComponent();
            oRutinasClient = new RutinasClient();
            oRutina = new rutina();
        }

        private void EditarRutinas_Load(object sender, EventArgs e)
        {
            this.LimpiarObjetosFormulario();
            this.CargarRutinas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Main_Menu oMainMenu = new Main_Menu(1);
            this.Close();
            oMainMenu.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oRutina.Rutina1 = txtRutina.Text;
            if (oRutinasClient.EditarRutina(oRutina))
            {
                MessageBox.Show("Actualizacion de Rutina Exitosa", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Error al intentar actualizar la informacion de la rutina seleccionada", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.LimpiarObjetosFormulario();
            this.CargarRutinas();
        }



        #region Accion de btnEliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (oRutinasClient.EliminarRutina(oRutina))
            {
                MessageBox.Show("Se ha eliminado la rutina exitosamente", "SUCESS", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar la rutina seleccionada", "FAILED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            this.CargarRutinas();
            this.LimpiarObjetosFormulario();

        }
        #endregion

        #region Funciones basicas de limpieza y visual
        private void CargarRutinas()
        {
            dtgEditRutinas.DataSource = oRutinasClient.ChargerRutinas();
            dtgEditRutinas.Columns[0].Visible = false;
            dtgEditRutinas.Columns[1].HeaderText = "Detalle de Rutina";

        }

        public void LimpiarObjetosFormulario()
        {
            txtRutina.Clear();
            txtRutina.Enabled = false;
        }
        #endregion

        #region Eventos Click y DobleClick en una celda del dtgEditRutinas
        private void dtgEditRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oRutina.id = Convert.ToInt32(dtgEditRutinas.Rows[e.RowIndex].Cells[0].Value);
            oRutina.Rutina1 = dtgEditRutinas.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dtgEditRutinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRutina.Text = dtgEditRutinas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRutina.Enabled = true;
        }
        #endregion
    }
}