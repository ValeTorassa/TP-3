namespace Ejercicio_10
{
    partial class Temperatura
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
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFinal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbInicio
            // 
            this.cmbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.cmbInicio.Location = new System.Drawing.Point(51, 57);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbInicio.TabIndex = 0;
            // 
            // cmbFinal
            // 
            this.cmbFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.cmbFinal.Location = new System.Drawing.Point(415, 57);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.Size = new System.Drawing.Size(121, 21);
            this.cmbFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la escala incial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la escala final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese los grados:";
            // 
            // txtGrados
            // 
            this.txtGrados.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrados.Location = new System.Drawing.Point(246, 57);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(112, 20);
            this.txtGrados.TabIndex = 5;
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Escala,
            this.Grados});
            this.dtgvDatos.Location = new System.Drawing.Point(148, 151);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowHeadersWidth = 21;
            this.dtgvDatos.Size = new System.Drawing.Size(323, 200);
            this.dtgvDatos.TabIndex = 6;
            // 
            // Escala
            // 
            this.Escala.HeaderText = "Escala";
            this.Escala.Name = "Escala";
            this.Escala.Width = 150;
            // 
            // Grados
            // 
            this.Grados.HeaderText = "Grados";
            this.Grados.Name = "Grados";
            this.Grados.Width = 150;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(262, 97);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 7;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(259, 80);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultados de las conversiones:";
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInicio);
            this.Name = "Temperatura";
            this.Text = "Transformador de Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.ComboBox cmbFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Escala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grados;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label4;
    }
}

