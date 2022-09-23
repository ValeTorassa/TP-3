namespace Ejercicio_1
{
    partial class FormularioInputBoxSuma
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
            this.btnInputBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInputBox
            // 
            this.btnInputBox.Location = new System.Drawing.Point(91, 12);
            this.btnInputBox.Name = "btnInputBox";
            this.btnInputBox.Size = new System.Drawing.Size(138, 41);
            this.btnInputBox.TabIndex = 0;
            this.btnInputBox.Text = "Suma con InputBox";
            this.btnInputBox.UseVisualStyleBackColor = true;
            this.btnInputBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblResultado.Location = new System.Drawing.Point(123, 106);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 20);
            this.LblResultado.TabIndex = 2;
            // 
            // FormularioInputBoxSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 160);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInputBox);
            this.Name = "FormularioInputBoxSuma";
            this.Text = "Suma inputbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResultado;
    }
}

