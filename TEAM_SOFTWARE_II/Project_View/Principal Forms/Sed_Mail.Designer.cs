namespace Project_View.Principal_Forms
{
    partial class Sed_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sed_Mail));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtFromMail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbToEmail = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSubjectMail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBodyMail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSendMail = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "From:";
            // 
            // txtFromMail
            // 
            // 
            // 
            // 
            this.txtFromMail.Border.Class = "TextBoxBorder";
            this.txtFromMail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFromMail.Location = new System.Drawing.Point(49, 15);
            this.txtFromMail.Name = "txtFromMail";
            this.txtFromMail.Size = new System.Drawing.Size(421, 20);
            this.txtFromMail.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "To:";
            // 
            // cmbToEmail
            // 
            this.cmbToEmail.DisplayMember = "Text";
            this.cmbToEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbToEmail.FormattingEnabled = true;
            this.cmbToEmail.ItemHeight = 14;
            this.cmbToEmail.Items.AddRange(new object[] {
            this.comboItem1});
            this.cmbToEmail.Location = new System.Drawing.Point(36, 70);
            this.cmbToEmail.Name = "cmbToEmail";
            this.cmbToEmail.Size = new System.Drawing.Size(434, 20);
            this.cmbToEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbToEmail.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Subject";
            // 
            // txtSubjectMail
            // 
            // 
            // 
            // 
            this.txtSubjectMail.Border.Class = "TextBoxBorder";
            this.txtSubjectMail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSubjectMail.Location = new System.Drawing.Point(57, 119);
            this.txtSubjectMail.Name = "txtSubjectMail";
            this.txtSubjectMail.Size = new System.Drawing.Size(413, 20);
            this.txtSubjectMail.TabIndex = 5;
            // 
            // txtBodyMail
            // 
            // 
            // 
            // 
            this.txtBodyMail.Border.Class = "TextBoxBorder";
            this.txtBodyMail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBodyMail.Location = new System.Drawing.Point(13, 158);
            this.txtBodyMail.Multiline = true;
            this.txtBodyMail.Name = "txtBodyMail";
            this.txtBodyMail.Size = new System.Drawing.Size(457, 163);
            this.txtBodyMail.TabIndex = 6;
            // 
            // btnSendMail
            // 
            this.btnSendMail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSendMail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSendMail.Image = global::Project_View.Properties.Resources._1395628423_new_mail;
            this.btnSendMail.Location = new System.Drawing.Point(504, 119);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 69);
            this.btnSendMail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::Project_View.Properties.Resources._1395628811_cancel;
            this.btnCancel.Location = new System.Drawing.Point(504, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 69);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "jaimeesquivelgomez@gmail.com";
            // 
            // Sed_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtBodyMail);
            this.Controls.Add(this.txtSubjectMail);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cmbToEmail);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtFromMail);
            this.Controls.Add(this.labelX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sed_Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email ";
            this.Load += new System.EventHandler(this.Sed_Mail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFromMail;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbToEmail;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSubjectMail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBodyMail;
        private DevComponents.DotNetBar.ButtonX btnSendMail;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.Editors.ComboItem comboItem1;
    }
}