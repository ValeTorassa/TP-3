namespace Ejercicio_7
{
    partial class CalculadoraInteres
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
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.Tasa,
            this.Dias,
            this.Interes});
            this.dtgvDatos.Location = new System.Drawing.Point(11, 124);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.Size = new System.Drawing.Size(444, 185);
            this.dtgvDatos.TabIndex = 0;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Tasa
            // 
            this.Tasa.HeaderText = "Tasa Efectiva";
            this.Tasa.Name = "Tasa";
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa Efectiva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dias";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(314, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(314, 42);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(133, 92);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 7;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(173, 61);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 8;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(173, 35);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 20);
            this.txtTasa.TabIndex = 9;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(173, 10);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 10;
            // 
            // CalculadoraInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(467, 350);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDatos);
            this.Name = "CalculadoraInteres";
            this.Text = "Calculadora de Interes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
    }
}

