namespace RestoraApp
{
    partial class ReportesIndex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button11;
            System.Windows.Forms.Button button13;
            System.Windows.Forms.Button button14;
            System.Windows.Forms.Button button9;
            this.Welcometext = new System.Windows.Forms.Label();
            button11 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button11.Location = new System.Drawing.Point(737, 338);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(281, 158);
            button11.TabIndex = 64;
            button11.Text = "Reporte de Compras";
            button11.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button13.Location = new System.Drawing.Point(737, 124);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(281, 158);
            button13.TabIndex = 63;
            button13.Text = "Reporte de Ventas";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button14.Location = new System.Drawing.Point(341, 124);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(281, 158);
            button14.TabIndex = 62;
            button14.Text = "Balance por Fecha";
            button14.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button9.Location = new System.Drawing.Point(341, 344);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(281, 158);
            button9.TabIndex = 66;
            button9.Text = "Deudas por Fecha";
            button9.UseVisualStyleBackColor = false;
            // 
            // Welcometext
            // 
            this.Welcometext.AutoSize = true;
            this.Welcometext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcometext.Location = new System.Drawing.Point(634, 40);
            this.Welcometext.Name = "Welcometext";
            this.Welcometext.Size = new System.Drawing.Size(133, 31);
            this.Welcometext.TabIndex = 67;
            this.Welcometext.Text = "Reportes";
            this.Welcometext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReportesIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.Welcometext);
            this.Controls.Add(button9);
            this.Controls.Add(button11);
            this.Controls.Add(button13);
            this.Controls.Add(button14);
            this.Name = "ReportesIndex";
            this.Controls.SetChildIndex(button14, 0);
            this.Controls.SetChildIndex(button13, 0);
            this.Controls.SetChildIndex(button11, 0);
            this.Controls.SetChildIndex(button9, 0);
            this.Controls.SetChildIndex(this.Welcometext, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcometext;
    }
}
