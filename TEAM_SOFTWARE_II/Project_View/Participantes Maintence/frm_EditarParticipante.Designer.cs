namespace Project_View.Participantes_Maintence
{
    partial class frm_EditarParticipante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.txtNombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtApellido2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtApellido1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtgParticipantes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblTablaParticipantes = new DevComponents.DotNetBar.LabelX();
            this.lblNombre = new DevComponents.DotNetBar.LabelX();
            this.lblApellido1 = new DevComponents.DotNetBar.LabelX();
            this.lblApellido2 = new DevComponents.DotNetBar.LabelX();
            this.lblFechaNacimiento = new DevComponents.DotNetBar.LabelX();
            this.dtFechaNacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalir.Image = global::Project_View.Properties.Resources._1395628427_delete1;
            this.btnSalir.Location = new System.Drawing.Point(820, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 65);
            this.btnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Image = global::Project_View.Properties.Resources._1395628627_delete_user;
            this.btnEliminar.Location = new System.Drawing.Point(823, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 65);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Image = global::Project_View.Properties.Resources._1395628632_edit_user;
            this.btnEditar.Location = new System.Drawing.Point(823, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 65);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.Border.Class = "TextBoxBorder";
            this.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNombre.Location = new System.Drawing.Point(15, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido2
            // 
            // 
            // 
            // 
            this.txtApellido2.Border.Class = "TextBoxBorder";
            this.txtApellido2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApellido2.Location = new System.Drawing.Point(314, 50);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(125, 20);
            this.txtApellido2.TabIndex = 19;
            // 
            // txtApellido1
            // 
            // 
            // 
            // 
            this.txtApellido1.Border.Class = "TextBoxBorder";
            this.txtApellido1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApellido1.Location = new System.Drawing.Point(164, 50);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(125, 20);
            this.txtApellido1.TabIndex = 21;
            // 
            // dtgParticipantes
            // 
            this.dtgParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgParticipantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgParticipantes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgParticipantes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgParticipantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgParticipantes.Location = new System.Drawing.Point(12, 186);
            this.dtgParticipantes.MultiSelect = false;
            this.dtgParticipantes.Name = "dtgParticipantes";
            this.dtgParticipantes.ReadOnly = true;
            this.dtgParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParticipantes.Size = new System.Drawing.Size(732, 274);
            this.dtgParticipantes.TabIndex = 23;
            this.dtgParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantes_CellClick);
            this.dtgParticipantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantes_CellDoubleClick);
            // 
            // lblTablaParticipantes
            // 
            // 
            // 
            // 
            this.lblTablaParticipantes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTablaParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaParticipantes.Location = new System.Drawing.Point(58, 137);
            this.lblTablaParticipantes.Name = "lblTablaParticipantes";
            this.lblTablaParticipantes.Size = new System.Drawing.Size(616, 23);
            this.lblTablaParticipantes.TabIndex = 25;
            this.lblTablaParticipantes.Text = "TABLA DE PARTICIPANTES";
            this.lblTablaParticipantes.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblNombre
            // 
            // 
            // 
            // 
            this.lblNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNombre.Location = new System.Drawing.Point(29, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 23);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblApellido1
            // 
            // 
            // 
            // 
            this.lblApellido1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblApellido1.Location = new System.Drawing.Point(178, 21);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(100, 23);
            this.lblApellido1.TabIndex = 27;
            this.lblApellido1.Text = "Primer Apellido";
            this.lblApellido1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblApellido2
            // 
            // 
            // 
            // 
            this.lblApellido2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblApellido2.Location = new System.Drawing.Point(323, 21);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(106, 23);
            this.lblApellido2.TabIndex = 28;
            this.lblApellido2.Text = "Segundo Apellido";
            this.lblApellido2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblFechaNacimiento
            // 
            // 
            // 
            // 
            this.lblFechaNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(463, 21);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(112, 23);
            this.lblFechaNacimiento.TabIndex = 29;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            this.lblFechaNacimiento.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dtFechaNacimiento
            // 
            // 
            // 
            // 
            this.dtFechaNacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFechaNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFechaNacimiento.ButtonDropDown.Visible = true;
            this.dtFechaNacimiento.IsPopupCalendarOpen = false;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(463, 50);
            // 
            // 
            // 
            this.dtFechaNacimiento.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaNacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtFechaNacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            this.dtFechaNacimiento.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFechaNacimiento.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFechaNacimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtFechaNacimiento.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(112, 20);
            this.dtFechaNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFechaNacimiento.TabIndex = 30;
            // 
            // frm_EditarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 472);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTablaParticipantes);
            this.Controls.Add(this.dtgParticipantes);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Name = "frm_EditarParticipante";
            this.Text = "frm_EditarParticipante";
            this.Load += new System.EventHandler(this.frm_EditarParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaNacimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSalir;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtApellido2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtApellido1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgParticipantes;
        private DevComponents.DotNetBar.LabelX lblTablaParticipantes;
        private DevComponents.DotNetBar.LabelX lblNombre;
        private DevComponents.DotNetBar.LabelX lblApellido1;
        private DevComponents.DotNetBar.LabelX lblApellido2;
        private DevComponents.DotNetBar.LabelX lblFechaNacimiento;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFechaNacimiento;
    }
}