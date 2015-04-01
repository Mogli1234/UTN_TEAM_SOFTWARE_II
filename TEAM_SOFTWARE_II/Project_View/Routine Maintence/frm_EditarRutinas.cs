using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_View
{
    public partial class frm_EditarRutinas : Form
    {

        public frm_EditarRutinas()
        {
            InitializeComponent();
        }

        private void EditarRutinas_Load(object sender, EventArgs e)
        {
            this.CargarRutina();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
              
        }

        private void dtgEditRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRutina.Text = dtgEditRutinas.CurrentRow.Cells[1].Value.ToString();
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            this.CargarRutina();
        }

        private void CargarRutina()
        {
            
            dtgEditRutinas.Columns[0].Visible = false;
            dtgEditRutinas.Columns[1].HeaderText = "Detalle de Rutina";
        }
    }
}
