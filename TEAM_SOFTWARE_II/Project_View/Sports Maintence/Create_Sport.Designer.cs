namespace Project_View
{
    partial class Create_Sport
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSport = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Sport Name";
            // 
            // txtSport
            // 
            // 
            // 
            // 
            this.txtSport.Border.Class = "TextBoxBorder";
            this.txtSport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSport.Location = new System.Drawing.Point(87, 31);
            this.txtSport.Name = "txtSport";
            this.txtSport.Size = new System.Drawing.Size(154, 20);
            this.txtSport.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 85);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Sport Description";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.Location = new System.Drawing.Point(12, 114);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(318, 142);
            this.txtDescription.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Image = global::Project_View.Properties.Resources._1395628811_cancel;
            this.btnCancelar.Location = new System.Drawing.Point(439, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 72);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Image = global::Project_View.Properties.Resources._1395628239_save;
            this.btnAceptar.Location = new System.Drawing.Point(439, 85);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 72);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Create_Sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 305);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.labelX1);
            this.Name = "Create_Sport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sport";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSport;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
    }
}