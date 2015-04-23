namespace Project_View
{
    partial class frm_ViewParticipante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewParticipante));
            this.dtg_Participantes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAceptarSalir = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Participantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Participantes
            // 
            this.dtg_Participantes.AllowUserToAddRows = false;
            this.dtg_Participantes.AllowUserToDeleteRows = false;
            this.dtg_Participantes.AllowUserToResizeColumns = false;
            this.dtg_Participantes.AllowUserToResizeRows = false;
            this.dtg_Participantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Participantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Participantes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_Participantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Participantes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Participantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtg_Participantes.Location = new System.Drawing.Point(12, 34);
            this.dtg_Participantes.MultiSelect = false;
            this.dtg_Participantes.Name = "dtg_Participantes";
            this.dtg_Participantes.ReadOnly = true;
            this.dtg_Participantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Participantes.Size = new System.Drawing.Size(645, 227);
            this.dtg_Participantes.TabIndex = 0;
            // 
            // btnAceptarSalir
            // 
            this.btnAceptarSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptarSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptarSalir.Image = global::Project_View.Properties.Resources._1395628811_cancel;
            this.btnAceptarSalir.Location = new System.Drawing.Point(293, 267);
            this.btnAceptarSalir.Name = "btnAceptarSalir";
            this.btnAceptarSalir.Size = new System.Drawing.Size(75, 60);
            this.btnAceptarSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptarSalir.TabIndex = 1;
            this.btnAceptarSalir.Click += new System.EventHandler(this.btnAceptarSalir_Click);
            // 
            // frm_ViewParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 331);
            this.Controls.Add(this.btnAceptarSalir);
            this.Controls.Add(this.dtg_Participantes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ViewParticipante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de Participantes";
            this.Load += new System.EventHandler(this.frm_ViewParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Participantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtg_Participantes;
        private DevComponents.DotNetBar.ButtonX btnAceptarSalir;
    }
}