namespace Ejercicio_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnTirar = new System.Windows.Forms.Button();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Resultados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPor1 = new System.Windows.Forms.Label();
            this.lblPor2 = new System.Windows.Forms.Label();
            this.lblPor3 = new System.Windows.Forms.Label();
            this.lblPor4 = new System.Windows.Forms.Label();
            this.lblPor5 = new System.Windows.Forms.Label();
            this.lblPor6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "El dado dice:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(78, 94);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(26, 27);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "X";
            // 
            // btnTirar
            // 
            this.btnTirar.Location = new System.Drawing.Point(39, 153);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(108, 48);
            this.btnTirar.TabIndex = 4;
            this.btnTirar.Text = "Tirar Dado";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resultados});
            this.dtgvDatos.Location = new System.Drawing.Point(184, 12);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.Size = new System.Drawing.Size(144, 224);
            this.dtgvDatos.TabIndex = 5;
            // 
            // Resultados
            // 
            this.Resultados.HeaderText = "Ultimas Tiradas";
            this.Resultados.Name = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "El porcentaje de 2 es de:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "El porcentaje de 1 es de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "El porcentaje de 3 es de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "El porcentaje de 4 es de:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "El porcentaje de 5 es de:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "El porcentaje de 6 es de:";
            // 
            // lblPor1
            // 
            this.lblPor1.AutoSize = true;
            this.lblPor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor1.Location = new System.Drawing.Point(556, 40);
            this.lblPor1.Name = "lblPor1";
            this.lblPor1.Size = new System.Drawing.Size(18, 17);
            this.lblPor1.TabIndex = 14;
            this.lblPor1.Text = "X";
            // 
            // lblPor2
            // 
            this.lblPor2.AutoSize = true;
            this.lblPor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor2.Location = new System.Drawing.Point(556, 65);
            this.lblPor2.Name = "lblPor2";
            this.lblPor2.Size = new System.Drawing.Size(18, 17);
            this.lblPor2.TabIndex = 15;
            this.lblPor2.Text = "X";
            // 
            // lblPor3
            // 
            this.lblPor3.AutoSize = true;
            this.lblPor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor3.Location = new System.Drawing.Point(556, 94);
            this.lblPor3.Name = "lblPor3";
            this.lblPor3.Size = new System.Drawing.Size(18, 17);
            this.lblPor3.TabIndex = 16;
            this.lblPor3.Text = "X";
            // 
            // lblPor4
            // 
            this.lblPor4.AutoSize = true;
            this.lblPor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor4.Location = new System.Drawing.Point(556, 123);
            this.lblPor4.Name = "lblPor4";
            this.lblPor4.Size = new System.Drawing.Size(18, 17);
            this.lblPor4.TabIndex = 17;
            this.lblPor4.Text = "X";
            // 
            // lblPor5
            // 
            this.lblPor5.AutoSize = true;
            this.lblPor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor5.Location = new System.Drawing.Point(556, 153);
            this.lblPor5.Name = "lblPor5";
            this.lblPor5.Size = new System.Drawing.Size(18, 17);
            this.lblPor5.TabIndex = 18;
            this.lblPor5.Text = "X";
            // 
            // lblPor6
            // 
            this.lblPor6.AutoSize = true;
            this.lblPor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPor6.Location = new System.Drawing.Point(556, 184);
            this.lblPor6.Name = "lblPor6";
            this.lblPor6.Size = new System.Drawing.Size(18, 17);
            this.lblPor6.TabIndex = 19;
            this.lblPor6.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(538, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(538, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(538, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(538, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(538, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(538, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(636, 262);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPor6);
            this.Controls.Add(this.lblPor5);
            this.Controls.Add(this.lblPor4);
            this.Controls.Add(this.lblPor3);
            this.Controls.Add(this.lblPor2);
            this.Controls.Add(this.lblPor1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dado con datos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPor1;
        private System.Windows.Forms.Label lblPor2;
        private System.Windows.Forms.Label lblPor3;
        private System.Windows.Forms.Label lblPor4;
        private System.Windows.Forms.Label lblPor5;
        private System.Windows.Forms.Label lblPor6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

