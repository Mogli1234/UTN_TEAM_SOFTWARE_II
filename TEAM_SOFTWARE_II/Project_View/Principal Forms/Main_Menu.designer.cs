namespace Project_View
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeporte = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDeporte = new System.Windows.Forms.ToolStripMenuItem();
            this.verDeportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participante = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParticipante = new System.Windows.Forms.ToolStripMenuItem();
            this.verParticipantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRutina = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRutina = new System.Windows.Forms.ToolStripMenuItem();
            this.verRutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditSport = new System.Windows.Forms.ToolStripMenuItem();
            this.rutina = new System.Windows.Forms.ToolStripMenuItem();
            this.editparticipante = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRutinasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignar = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarDeporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAssigSport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStats = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeporte,
            this.participante,
            this.btnRutina,
            this.toolStripSeparator2,
            this.btnSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // btnDeporte
            // 
            this.btnDeporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDeporte,
            this.verDeportesToolStripMenuItem});
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(143, 22);
            this.btnDeporte.Text = "Deporte";
            // 
            // crearDeporte
            // 
            this.crearDeporte.Name = "crearDeporte";
            this.crearDeporte.Size = new System.Drawing.Size(147, 22);
            this.crearDeporte.Text = "Crear Deporte";
            this.crearDeporte.Click += new System.EventHandler(this.crearDeporteToolStripMenuItem_Click);
            // 
            // verDeportesToolStripMenuItem
            // 
            this.verDeportesToolStripMenuItem.Name = "verDeportesToolStripMenuItem";
            this.verDeportesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.verDeportesToolStripMenuItem.Text = "Ver Deportes";
            this.verDeportesToolStripMenuItem.Click += new System.EventHandler(this.verDeportesToolStripMenuItem_Click);
            // 
            // participante
            // 
            this.participante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnParticipante,
            this.verParticipantesToolStripMenuItem});
            this.participante.Name = "participante";
            this.participante.Size = new System.Drawing.Size(143, 22);
            this.participante.Text = "Participantes";
            // 
            // btnParticipante
            // 
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(182, 22);
            this.btnParticipante.Text = "Ingresar Participante";
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // verParticipantesToolStripMenuItem
            // 
            this.verParticipantesToolStripMenuItem.Name = "verParticipantesToolStripMenuItem";
            this.verParticipantesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.verParticipantesToolStripMenuItem.Text = "Ver Participantes";
            this.verParticipantesToolStripMenuItem.Click += new System.EventHandler(this.verParticipantesToolStripMenuItem_Click);
            // 
            // btnRutina
            // 
            this.btnRutina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRutina,
            this.verRutinasToolStripMenuItem});
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(143, 22);
            this.btnRutina.Text = "Rutina";
            // 
            // crearRutina
            // 
            this.crearRutina.Name = "crearRutina";
            this.crearRutina.Size = new System.Drawing.Size(139, 22);
            this.crearRutina.Text = "Crear Rutina";
            this.crearRutina.Click += new System.EventHandler(this.crearRutinaToolStripMenuItem_Click);
            // 
            // verRutinasToolStripMenuItem
            // 
            this.verRutinasToolStripMenuItem.Name = "verRutinasToolStripMenuItem";
            this.verRutinasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.verRutinasToolStripMenuItem.Text = "Ver Rutinas";
            this.verRutinasToolStripMenuItem.Click += new System.EventHandler(this.verRutinasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 22);
            this.btnSalir.Text = "&Cerrar Sesion";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditSport,
            this.rutina,
            this.editparticipante});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // btnEditSport
            // 
            this.btnEditSport.Name = "btnEditSport";
            this.btnEditSport.Size = new System.Drawing.Size(137, 22);
            this.btnEditSport.Text = "Deporte";
            this.btnEditSport.Click += new System.EventHandler(this.dtnEditSport_Click);
            // 
            // rutina
            // 
            this.rutina.Name = "rutina";
            this.rutina.Size = new System.Drawing.Size(137, 22);
            this.rutina.Text = "Rutina";
            this.rutina.Click += new System.EventHandler(this.rutinaToolStripMenuItem_Click);
            // 
            // editparticipante
            // 
            this.editparticipante.Name = "editparticipante";
            this.editparticipante.Size = new System.Drawing.Size(137, 22);
            this.editparticipante.Text = "Participante";
            this.editparticipante.Click += new System.EventHandler(this.participanteToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarRutinasToolStripMenuItem1,
            this.asignarDeporteToolStripMenuItem,
            this.btnStats});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // asignarRutinasToolStripMenuItem1
            // 
            this.asignarRutinasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAsignar});
            this.asignarRutinasToolStripMenuItem1.Name = "asignarRutinasToolStripMenuItem1";
            this.asignarRutinasToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.asignarRutinasToolStripMenuItem1.Text = "Asignar Rutinas";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(114, 22);
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click_1);
            // 
            // asignarDeporteToolStripMenuItem
            // 
            this.asignarDeporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAssigSport});
            this.asignarDeporteToolStripMenuItem.Name = "asignarDeporteToolStripMenuItem";
            this.asignarDeporteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.asignarDeporteToolStripMenuItem.Text = "Asignar Deporte";
            // 
            // btnAssigSport
            // 
            this.btnAssigSport.Name = "btnAssigSport";
            this.btnAssigSport.Size = new System.Drawing.Size(164, 22);
            this.btnAssigSport.Text = "Assignar Deporte";
            this.btnAssigSport.Click += new System.EventHandler(this.btnAssigSport_Click);
            // 
            // btnStats
            // 
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(159, 22);
            this.btnStats.Text = "Estaditicas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.acercadeToolStripMenuItem,
            this.enviarInformacionToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // enviarInformacionToolStripMenuItem
            // 
            this.enviarInformacionToolStripMenuItem.Name = "enviarInformacionToolStripMenuItem";
            this.enviarInformacionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enviarInformacionToolStripMenuItem.Text = "Enviar Informacion";
            this.enviarInformacionToolStripMenuItem.Click += new System.EventHandler(this.enviarInformacionToolStripMenuItem_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Project_View.Properties.Resources._02_nobm9_AnimeAngel1;
            this.ClientSize = new System.Drawing.Size(798, 514);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDeporte;
        private System.Windows.Forms.ToolStripMenuItem verDeportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participante;
        private System.Windows.Forms.ToolStripMenuItem btnRutina;
        private System.Windows.Forms.ToolStripMenuItem btnEditSport;
        private System.Windows.Forms.ToolStripMenuItem rutina;
        private System.Windows.Forms.ToolStripMenuItem editparticipante;
        private System.Windows.Forms.ToolStripMenuItem btnParticipante;
        private System.Windows.Forms.ToolStripMenuItem verParticipantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRutina;
        private System.Windows.Forms.ToolStripMenuItem verRutinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRutinasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAsignar;
        private System.Windows.Forms.ToolStripMenuItem asignarDeporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAssigSport;
        private System.Windows.Forms.ToolStripMenuItem btnStats;
        private System.Windows.Forms.ToolStripMenuItem enviarInformacionToolStripMenuItem;

    }
}