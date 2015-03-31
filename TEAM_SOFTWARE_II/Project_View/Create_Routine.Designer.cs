namespace Project_View
{
    partial class Create_Routine
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
            this.bntGuardar = new DevComponents.DotNetBar.ButtonX();
            this.txtRutina = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.lblRutina = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // bntGuardar
            // 
            this.bntGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntGuardar.Image = global::Project_View.Properties.Resources._1395628239_save;
            this.bntGuardar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.bntGuardar.Location = new System.Drawing.Point(515, 49);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(67, 68);
            this.bntGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntGuardar.TabIndex = 0;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // txtRutina
            // 
            // 
            // 
            // 
            this.txtRutina.Border.Class = "TextBoxBorder";
            this.txtRutina.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRutina.Location = new System.Drawing.Point(12, 103);
            this.txtRutina.Multiline = true;
            this.txtRutina.Name = "txtRutina";
            this.txtRutina.Size = new System.Drawing.Size(383, 123);
            this.txtRutina.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = global::Project_View.Properties.Resources._1395628811_cancel;
            this.btnCancelar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancelar.Location = new System.Drawing.Point(515, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 68);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 2;
            // 
            // lblRutina
            // 
            // 
            // 
            // 
            this.lblRutina.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRutina.Location = new System.Drawing.Point(12, 49);
            this.lblRutina.Name = "lblRutina";
            this.lblRutina.Size = new System.Drawing.Size(95, 34);
            this.lblRutina.TabIndex = 3;
            this.lblRutina.Text = "Rutina Nombre:";
            this.lblRutina.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Create_Routine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 299);
            this.Controls.Add(this.lblRutina);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRutina);
            this.Controls.Add(this.bntGuardar);
            this.Name = "Create_Routine";
            this.Text = "Creacion de Rutinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Create_Routine_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bntGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRutina;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.LabelX lblRutina;
    }
}