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
    public partial class Edit_Sport : Form
    {
        
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
            txtSport.Text = dtgSports.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescription.Text = dtgSports.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            dtgSports.Columns[2].Visible = false;
            dtgSports.Columns[1].HeaderText = "Descripción";
            dtgSports.Columns[0].HeaderText = "Deporte";
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
           
            this.cargarTable();
        }

    }
}
