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
    public partial class frm_assignar_sport : Form
    {
        
        public frm_assignar_sport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_assignar_sport_Load(object sender, EventArgs e)
        {
            this.ChargeControls();
        }

        #region Cargar Controles
        void ChargeControls() 
        {
            //Cargo los deportes
            
            cmbSport.DisplayMember = "Deporte";

            //Cargo las rutinas en este 
          
            cmbRutine.DisplayMember = "Rutina";
            cmbSport.ValueMember = "Id";
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }
    }
}
