namespace Project_View
{
    partial class frm_VerRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgRutinas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRutinas
            // 
            this.dtgRutinas.AllowUserToAddRows = false;
            this.dtgRutinas.AllowUserToDeleteRows = false;
            this.dtgRutinas.AllowUserToResizeColumns = false;
            this.dtgRutinas.AllowUserToResizeRows = false;
            this.dtgRutinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRutinas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRutinas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRutinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRutinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgRutinas.Location = new System.Drawing.Point(22, 9);
            this.dtgRutinas.MultiSelect = false;
            this.dtgRutinas.Name = "dtgRutinas";
            this.dtgRutinas.ReadOnly = true;
            this.dtgRutinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRutinas.Size = new System.Drawing.Size(645, 227);
            this.dtgRutinas.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(272, 279);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 36);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frm_VerRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 327);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgRutinas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_VerRutinas";
            this.Text = "Ver Rutinas Existentes";
            this.Load += new System.EventHandler(this.frm_VerRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgRutinas;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
    }
}