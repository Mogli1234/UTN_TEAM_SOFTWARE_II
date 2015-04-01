namespace Project_View
{
    partial class frm_AssingRutina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AssingRutina));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtgParticipantes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbSports = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbRutina = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAgregar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(117, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Seleccione el deporte: ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(215, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(127, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Seleccione la rutina:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(7, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(144, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Seleccione el participante:";
            // 
            // dtgParticipantes
            // 
            this.dtgParticipantes.AllowUserToAddRows = false;
            this.dtgParticipantes.AllowUserToDeleteRows = false;
            this.dtgParticipantes.AllowUserToResizeColumns = false;
            this.dtgParticipantes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgParticipantes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgParticipantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgParticipantes.Location = new System.Drawing.Point(7, 212);
            this.dtgParticipantes.MultiSelect = false;
            this.dtgParticipantes.Name = "dtgParticipantes";
            this.dtgParticipantes.ReadOnly = true;
            this.dtgParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParticipantes.Size = new System.Drawing.Size(439, 168);
            this.dtgParticipantes.TabIndex = 3;
            this.dtgParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantes_CellClick);
            // 
            // cmbSports
            // 
            this.cmbSports.DisplayMember = "Text";
            this.cmbSports.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSports.FormattingEnabled = true;
            this.cmbSports.ItemHeight = 14;
            this.cmbSports.Location = new System.Drawing.Point(13, 85);
            this.cmbSports.Name = "cmbSports";
            this.cmbSports.Size = new System.Drawing.Size(121, 20);
            this.cmbSports.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSports.TabIndex = 4;
            // 
            // cmbRutina
            // 
            this.cmbRutina.DisplayMember = "Text";
            this.cmbRutina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRutina.FormattingEnabled = true;
            this.cmbRutina.ItemHeight = 14;
            this.cmbRutina.Location = new System.Drawing.Point(206, 85);
            this.cmbRutina.Name = "cmbRutina";
            this.cmbRutina.Size = new System.Drawing.Size(231, 20);
            this.cmbRutina.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbRutina.TabIndex = 5;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Location = new System.Drawing.Point(157, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgregar.Image = global::Project_View.Properties.Resources._1395628239_save;
            this.btnAgregar.Location = new System.Drawing.Point(544, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 75);
            this.btnAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::Project_View.Properties.Resources._1395628427_delete1;
            this.btnCancel.Location = new System.Drawing.Point(544, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 75);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_AssingRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 429);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbRutina);
            this.Controls.Add(this.cmbSports);
            this.Controls.Add(this.dtgParticipantes);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AssingRutina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Rutina";
            this.Load += new System.EventHandler(this.frm_AssingRutina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgParticipantes;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSports;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRutina;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.ButtonX btnAgregar;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}