namespace Project_View
{
    partial class frm_EditarRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditarRutinas));
            this.dtgEditRutinas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblRutina = new DevComponents.DotNetBar.LabelX();
            this.txtRutina = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEditRutinas
            // 
            this.dtgEditRutinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEditRutinas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEditRutinas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEditRutinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEditRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEditRutinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEditRutinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgEditRutinas.Location = new System.Drawing.Point(395, 22);
            this.dtgEditRutinas.MultiSelect = false;
            this.dtgEditRutinas.Name = "dtgEditRutinas";
            this.dtgEditRutinas.ReadOnly = true;
            this.dtgEditRutinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEditRutinas.Size = new System.Drawing.Size(283, 162);
            this.dtgEditRutinas.TabIndex = 0;
            this.dtgEditRutinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEditRutinas_CellClick);
            this.dtgEditRutinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEditRutinas_CellDoubleClick);
            // 
            // lblRutina
            // 
            // 
            // 
            // 
            this.lblRutina.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRutina.Location = new System.Drawing.Point(12, 12);
            this.lblRutina.Name = "lblRutina";
            this.lblRutina.Size = new System.Drawing.Size(107, 27);
            this.lblRutina.TabIndex = 1;
            this.lblRutina.Text = "Detalle Rutina";
            // 
            // txtRutina
            // 
            // 
            // 
            // 
            this.txtRutina.Border.Class = "TextBoxBorder";
            this.txtRutina.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutina.Location = new System.Drawing.Point(12, 45);
            this.txtRutina.Multiline = true;
            this.txtRutina.Name = "txtRutina";
            this.txtRutina.Size = new System.Drawing.Size(333, 93);
            this.txtRutina.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.AutoSize = true;
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Image = global::Project_View.Properties.Resources._1395628239_save;
            this.btnEditar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEditar.Location = new System.Drawing.Point(12, 193);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 84);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Image = global::Project_View.Properties.Resources._1395628811_cancel;
            this.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSalir.Location = new System.Drawing.Point(603, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 84);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = global::Project_View.Properties.Resources._1395628427_delete1;
            this.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEliminar.Location = new System.Drawing.Point(126, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 84);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frm_EditarRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 289);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtRutina);
            this.Controls.Add(this.lblRutina);
            this.Controls.Add(this.dtgEditRutinas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditarRutinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Rutinas";
            this.Load += new System.EventHandler(this.EditarRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditRutinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgEditRutinas;
        private DevComponents.DotNetBar.LabelX lblRutina;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutina;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
    }
}