namespace Ejercicio_4
{
    partial class Form1
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
            this.LBLop1 = new System.Windows.Forms.Label();
            this.LBLop2 = new System.Windows.Forms.Label();
            this.LBLresultado = new System.Windows.Forms.Label();
            this.TXTop1 = new System.Windows.Forms.TextBox();
            this.TXTop2 = new System.Windows.Forms.TextBox();
            this.TXTresultado = new System.Windows.Forms.TextBox();
            this.BTNsumar = new System.Windows.Forms.Button();
            this.BTNrestar = new System.Windows.Forms.Button();
            this.BTNmultiplicacion = new System.Windows.Forms.Button();
            this.BTNcociente = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.LBLpedirnum = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLop1
            // 
            this.LBLop1.AutoSize = true;
            this.LBLop1.Location = new System.Drawing.Point(12, 23);
            this.LBLop1.Name = "LBLop1";
            this.LBLop1.Size = new System.Drawing.Size(83, 13);
            this.LBLop1.TabIndex = 0;
            this.LBLop1.Text = "Primer Operador";
            // 
            // LBLop2
            // 
            this.LBLop2.AutoSize = true;
            this.LBLop2.Location = new System.Drawing.Point(12, 68);
            this.LBLop2.Name = "LBLop2";
            this.LBLop2.Size = new System.Drawing.Size(97, 13);
            this.LBLop2.TabIndex = 1;
            this.LBLop2.Text = "Segundo Operador";
            // 
            // LBLresultado
            // 
            this.LBLresultado.AutoSize = true;
            this.LBLresultado.Location = new System.Drawing.Point(12, 229);
            this.LBLresultado.Name = "LBLresultado";
            this.LBLresultado.Size = new System.Drawing.Size(58, 13);
            this.LBLresultado.TabIndex = 2;
            this.LBLresultado.Text = "Resultado:";
            // 
            // TXTop1
            // 
            this.TXTop1.Location = new System.Drawing.Point(123, 20);
            this.TXTop1.Name = "TXTop1";
            this.TXTop1.Size = new System.Drawing.Size(100, 20);
            this.TXTop1.TabIndex = 3;
            // 
            // TXTop2
            // 
            this.TXTop2.Location = new System.Drawing.Point(123, 65);
            this.TXTop2.Name = "TXTop2";
            this.TXTop2.Size = new System.Drawing.Size(100, 20);
            this.TXTop2.TabIndex = 4;
            // 
            // TXTresultado
            // 
            this.TXTresultado.Location = new System.Drawing.Point(123, 226);
            this.TXTresultado.Name = "TXTresultado";
            this.TXTresultado.Size = new System.Drawing.Size(100, 20);
            this.TXTresultado.TabIndex = 5;
            // 
            // BTNsumar
            // 
            this.BTNsumar.Location = new System.Drawing.Point(244, 12);
            this.BTNsumar.Name = "BTNsumar";
            this.BTNsumar.Size = new System.Drawing.Size(75, 23);
            this.BTNsumar.TabIndex = 6;
            this.BTNsumar.Text = "Sumar";
            this.BTNsumar.UseVisualStyleBackColor = true;
            this.BTNsumar.Click += new System.EventHandler(this.BTNsumar_Click);
            // 
            // BTNrestar
            // 
            this.BTNrestar.Location = new System.Drawing.Point(244, 58);
            this.BTNrestar.Name = "BTNrestar";
            this.BTNrestar.Size = new System.Drawing.Size(75, 23);
            this.BTNrestar.TabIndex = 7;
            this.BTNrestar.Text = "Restar";
            this.BTNrestar.UseVisualStyleBackColor = true;
            this.BTNrestar.Click += new System.EventHandler(this.BTNrestar_Click);
            // 
            // BTNmultiplicacion
            // 
            this.BTNmultiplicacion.Location = new System.Drawing.Point(244, 101);
            this.BTNmultiplicacion.Name = "BTNmultiplicacion";
            this.BTNmultiplicacion.Size = new System.Drawing.Size(75, 23);
            this.BTNmultiplicacion.TabIndex = 8;
            this.BTNmultiplicacion.Text = "Producto";
            this.BTNmultiplicacion.UseVisualStyleBackColor = true;
            this.BTNmultiplicacion.Click += new System.EventHandler(this.BTNmultiplicacion_Click);
            // 
            // BTNcociente
            // 
            this.BTNcociente.Location = new System.Drawing.Point(244, 142);
            this.BTNcociente.Name = "BTNcociente";
            this.BTNcociente.Size = new System.Drawing.Size(75, 23);
            this.BTNcociente.TabIndex = 9;
            this.BTNcociente.Text = "Cociente";
            this.BTNcociente.UseVisualStyleBackColor = true;
            this.BTNcociente.Click += new System.EventHandler(this.BTNcociente_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(12, 266);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 10;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // LBLpedirnum
            // 
            this.LBLpedirnum.AutoSize = true;
            this.LBLpedirnum.Location = new System.Drawing.Point(12, 111);
            this.LBLpedirnum.Name = "LBLpedirnum";
            this.LBLpedirnum.Size = new System.Drawing.Size(0, 13);
            this.LBLpedirnum.TabIndex = 11;
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(244, 178);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 48);
            this.btnPotencia.TabIndex = 12;
            this.btnPotencia.Text = "Potencia cuadrada del primero";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(244, 240);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 49);
            this.btnRaiz.TabIndex = 13;
            this.btnRaiz.Text = "Raiz cuadrada del primero";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.LBLpedirnum);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNcociente);
            this.Controls.Add(this.BTNmultiplicacion);
            this.Controls.Add(this.BTNrestar);
            this.Controls.Add(this.BTNsumar);
            this.Controls.Add(this.TXTresultado);
            this.Controls.Add(this.TXTop2);
            this.Controls.Add(this.TXTop1);
            this.Controls.Add(this.LBLresultado);
            this.Controls.Add(this.LBLop2);
            this.Controls.Add(this.LBLop1);
            this.Name = "Form1";
            this.Text = "Mi Primer Calcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLop1;
        private System.Windows.Forms.Label LBLop2;
        private System.Windows.Forms.Label LBLresultado;
        private System.Windows.Forms.TextBox TXTop1;
        private System.Windows.Forms.TextBox TXTop2;
        private System.Windows.Forms.TextBox TXTresultado;
        private System.Windows.Forms.Button BTNsumar;
        private System.Windows.Forms.Button BTNrestar;
        private System.Windows.Forms.Button BTNmultiplicacion;
        private System.Windows.Forms.Button BTNcociente;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Label LBLpedirnum;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
    }
}

