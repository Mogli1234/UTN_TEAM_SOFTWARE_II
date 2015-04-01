namespace Project_View
{
    partial class frm_Participante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Participante));
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btn_GuardarParticipante = new DevComponents.DotNetBar.ButtonX();
            this.txt_Nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_PrimerApellido = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SegundoApellido = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dt_fecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.intEdad = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(331, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_GuardarParticipante
            // 
            this.btn_GuardarParticipante.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_GuardarParticipante.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_GuardarParticipante.Location = new System.Drawing.Point(151, 213);
            this.btn_GuardarParticipante.Name = "btn_GuardarParticipante";
            this.btn_GuardarParticipante.Size = new System.Drawing.Size(75, 23);
            this.btn_GuardarParticipante.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_GuardarParticipante.TabIndex = 1;
            this.btn_GuardarParticipante.Text = "Guardar";
            this.btn_GuardarParticipante.Click += new System.EventHandler(this.btn_GuardarParticipante_Click);
            // 
            // txt_Nombre
            // 
            // 
            // 
            // 
            this.txt_Nombre.Border.Class = "TextBoxBorder";
            this.txt_Nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Nombre.Location = new System.Drawing.Point(40, 51);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(157, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_PrimerApellido
            // 
            // 
            // 
            // 
            this.txt_PrimerApellido.Border.Class = "TextBoxBorder";
            this.txt_PrimerApellido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_PrimerApellido.Location = new System.Drawing.Point(231, 51);
            this.txt_PrimerApellido.Name = "txt_PrimerApellido";
            this.txt_PrimerApellido.Size = new System.Drawing.Size(143, 20);
            this.txt_PrimerApellido.TabIndex = 4;
            // 
            // txt_SegundoApellido
            // 
            // 
            // 
            // 
            this.txt_SegundoApellido.Border.Class = "TextBoxBorder";
            this.txt_SegundoApellido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SegundoApellido.Location = new System.Drawing.Point(409, 51);
            this.txt_SegundoApellido.Name = "txt_SegundoApellido";
            this.txt_SegundoApellido.Size = new System.Drawing.Size(139, 20);
            this.txt_SegundoApellido.TabIndex = 5;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Nombre";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(231, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Primer Apellido";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(409, 22);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(103, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Segundo Apellido";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(40, 99);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Edad";
            // 
            // dt_fecha
            // 
            // 
            // 
            // 
            this.dt_fecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_fecha.ButtonDropDown.Visible = true;
            this.dt_fecha.IsPopupCalendarOpen = false;
            this.dt_fecha.Location = new System.Drawing.Point(231, 128);
            // 
            // 
            // 
            this.dt_fecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_fecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fecha.MonthCalendar.DisplayMonth = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.dt_fecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dt_fecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dt_fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_fecha.MonthCalendar.TodayButtonVisible = true;
            this.dt_fecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(114, 20);
            this.dt_fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_fecha.TabIndex = 10;
            // 
            // intEdad
            // 
            // 
            // 
            // 
            this.intEdad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intEdad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intEdad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intEdad.Location = new System.Drawing.Point(40, 127);
            this.intEdad.MinValue = 0;
            this.intEdad.Name = "intEdad";
            this.intEdad.ShowUpDown = true;
            this.intEdad.Size = new System.Drawing.Size(67, 20);
            this.intEdad.TabIndex = 11;
            // 
            // frm_Participante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 272);
            this.Controls.Add(this.intEdad);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_SegundoApellido);
            this.Controls.Add(this.txt_PrimerApellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_GuardarParticipante);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Participante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Crear Prticipante";
            this.Load += new System.EventHandler(this.frm_Participante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btn_GuardarParticipante;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Nombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_PrimerApellido;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SegundoApellido;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_fecha;
        private DevComponents.Editors.IntegerInput intEdad;
    }
}