namespace Ejercicio_8
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
            this.btnTirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTirar
            // 
            this.btnTirar.Location = new System.Drawing.Point(75, 153);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(97, 48);
            this.btnTirar.TabIndex = 0;
            this.btnTirar.Text = "Tirar Dado";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "El dado dice:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(109, 84);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(26, 27);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(246, 225);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTirar);
            this.Name = "Form1";
            this.Text = "Tirar Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum;
    }
}

