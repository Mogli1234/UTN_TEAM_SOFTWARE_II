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
using Project_View.ServicioDeporte;


namespace Project_View
{
    public partial class Edit_Sport : Form
    {
        ServicioDeporte.DeportesWebServiceClient client = new ServicioDeporte.DeportesWebServiceClient();
        deporte osport = new deporte();
        
        public Edit_Sport()
        {
            InitializeComponent();
        }

        private void Edit_Sport_Load(object sender, EventArgs e)
        {
            this.LimpiarTextFlieds();
            this.cargarTable();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgSports_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSport.Text = dtgSports.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dtgSports.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            txtSport.Enabled = true;
            txtDescription.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            this.LimpiarTextFlieds();
            this.cargarTable();

        }
        private void cargarTable()
        {
            dtgSports.DataSource = client.ChargeSportsList();
            dtgSports.Columns[0].Visible = false;
            dtgSports.Columns[2].HeaderText = "Descripción";
            dtgSports.Columns[1].HeaderText = "Deporte";
        }
        private void LimpiarTextFlieds() 
        {
            txtSport.Enabled = false;
            txtDescription.Enabled = false;
            txtSport.Clear();
            txtDescription.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (client.DeleteSport(osport))
            {
                MessageBox.Show("El deporte a sido eliminado exitosamente", "SUCESS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ah ocurrido un problema a la hora de eliminar su deporte", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cargarTable();
        }

        private void dtgSports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            osport.id = Convert.ToInt16(dtgSports.Rows[e.RowIndex].Cells[0].Value);
            osport.Deporte1 = dtgSports.Rows[e.RowIndex].Cells[1].Value.ToString();
            osport.Descripcion = dtgSports.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

    }
}
