﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_View.Servicio;


namespace Project_View
{
    public partial class frm_ViewParticipantes : Form
    {
        Servicio.TEAM_SOFTWAREClient client = new Servicio.TEAM_SOFTWAREClient();
        
        public frm_ViewParticipantes()
        {
            InitializeComponent();
        }

        private void frm_ViewSport_Load(object sender, EventArgs e)
        {
           dtg_sport.DataSource = client.ChargeSportsList();
            dtg_sport.Columns[0].Visible =false;
            dtg_sport.Columns[3].Visible = false;
            dtg_sport.Columns[4].Visible = false;
            dtg_sport.Columns[2].HeaderText = "Descripción";
            dtg_sport.Columns[1].HeaderText = "Deporte";

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
