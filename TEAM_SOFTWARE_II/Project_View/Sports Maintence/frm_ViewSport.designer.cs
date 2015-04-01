namespace Project_View
{
    partial class frm_ViewParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewParticipantes));
            this.dtg_sport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_Cancelar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_sport
            // 
            this.dtg_sport.AllowUserToAddRows = false;
            this.dtg_sport.AllowUserToDeleteRows = false;
            this.dtg_sport.AllowUserToResizeColumns = false;
            this.dtg_sport.AllowUserToResizeRows = false;
            this.dtg_sport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_sport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_sport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_sport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtg_sport.Location = new System.Drawing.Point(12, 34);
            this.dtg_sport.MultiSelect = false;
            this.dtg_sport.Name = "dtg_sport";
            this.dtg_sport.ReadOnly = true;
            this.dtg_sport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_sport.Size = new System.Drawing.Size(645, 227);
            this.dtg_sport.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancelar.Location = new System.Drawing.Point(275, 282);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_ViewSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 331);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dtg_sport);      
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ViewSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Deportes";
            this.Load += new System.EventHandler(this.frm_ViewSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtg_sport;
        private DevComponents.DotNetBar.ButtonX btn_Cancelar;
    }
}