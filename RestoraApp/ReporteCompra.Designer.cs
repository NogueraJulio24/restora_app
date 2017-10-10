namespace RestoraApp
{
    partial class ReporteCompra
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
            System.Windows.Forms.Button button9;
            System.Windows.Forms.Button button12;
            System.Windows.Forms.Button button10;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Welcometext = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            button9 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button9.Location = new System.Drawing.Point(932, 176);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(214, 38);
            button9.TabIndex = 85;
            button9.Text = "Descargar";
            button9.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Proveedor,
            this.Nombre,
            this.Cantidad,
            this.Ruc,
            this.SubTotal,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(206, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 473);
            this.dataGridView1.TabIndex = 84;
            // 
            // Cod
            // 
            this.Cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.Width = 65;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Ruc
            // 
            this.Ruc.HeaderText = "Precio Unitario";
            this.Ruc.Name = "Ruc";
            this.Ruc.Width = 200;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button12
            // 
            button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button12.Location = new System.Drawing.Point(646, 176);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(214, 38);
            button12.TabIndex = 83;
            button12.Text = "Imprimir Reporte";
            button12.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button10.Location = new System.Drawing.Point(360, 176);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(190, 38);
            button10.TabIndex = 82;
            button10.Text = "Generar Reporte";
            button10.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Hasta";
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(883, 131);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(112, 23);
            this.materialSingleLineTextField6.TabIndex = 81;
            this.materialSingleLineTextField6.Text = "10/09/2017";
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "Desde";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(410, 133);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField2.TabIndex = 79;
            this.materialSingleLineTextField2.Text = "08/09/2017";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // Welcometext
            // 
            this.Welcometext.AutoSize = true;
            this.Welcometext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcometext.Location = new System.Drawing.Point(555, 40);
            this.Welcometext.Name = "Welcometext";
            this.Welcometext.Size = new System.Drawing.Size(382, 31);
            this.Welcometext.TabIndex = 77;
            this.Welcometext.Text = "Reportes Compra por Fecha";
            this.Welcometext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(427, 86);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(465, 23);
            this.materialSingleLineTextField1.TabIndex = 91;
            this.materialSingleLineTextField1.Text = "Escribe el nombre del proveedor";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Proveedor";
            // 
            // ReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.label4);
            this.Controls.Add(button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(button12);
            this.Controls.Add(button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialSingleLineTextField6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.Welcometext);
            this.Name = "ReporteCompra";
            this.Controls.SetChildIndex(this.Welcometext, 0);
            this.Controls.SetChildIndex(this.materialSingleLineTextField2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.materialSingleLineTextField6, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(button10, 0);
            this.Controls.SetChildIndex(button12, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(button9, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.materialSingleLineTextField1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private System.Windows.Forms.Label Welcometext;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Label label4;
    }
}
