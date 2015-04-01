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
    public partial class frm_Participante : Form
    {
        
        public frm_Participante()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Participante_Load(object sender, EventArgs e)
        {
            dt_fecha.Enabled = false;
            dt_fecha.Value = DateTime.Today;
        }

        private void btn_GuardarParticipante_Click(object sender, EventArgs e)
        {
            
            this.Limpiar_cajas();
        }

        #region Limpiar
        public void Limpiar_cajas() 
        {
            txt_Nombre.Clear();
            intEdad.Value = 1;
            txt_PrimerApellido.Clear();
            txt_SegundoApellido.Clear();
            txt_Nombre.Focus();
        }
        #endregion
    }
}
