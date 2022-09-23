namespace Ejercicios_11
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FichasTateti = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picReiniciar = new System.Windows.Forms.PictureBox();
            this.picGanador = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FichasTateti
            // 
            this.FichasTateti.BackColor = System.Drawing.Color.Transparent;
            this.FichasTateti.ColumnCount = 3;
            this.FichasTateti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasTateti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasTateti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.FichasTateti.Location = new System.Drawing.Point(29, 26);
            this.FichasTateti.Name = "FichasTateti";
            this.FichasTateti.RowCount = 3;
            this.FichasTateti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasTateti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasTateti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.FichasTateti.Size = new System.Drawing.Size(286, 268);
            this.FichasTateti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "VS";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer2.Location = new System.Drawing.Point(494, 103);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(21, 21);
            this.lblPlayer2.TabIndex = 18;
            this.lblPlayer2.Text = "0";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer1.Location = new System.Drawing.Point(387, 103);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(21, 21);
            this.lblPlayer1.TabIndex = 17;
            this.lblPlayer1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(615, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ganador";
            // 
            // picReiniciar
            // 
            this.picReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.picReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReiniciar.Image = global::Ejercicios_11.Properties.Resources.Reiniciar;
            this.picReiniciar.Location = new System.Drawing.Point(86, 311);
            this.picReiniciar.Name = "picReiniciar";
            this.picReiniciar.Size = new System.Drawing.Size(175, 56);
            this.picReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReiniciar.TabIndex = 15;
            this.picReiniciar.TabStop = false;
            this.picReiniciar.Click += new System.EventHandler(this.picReiniciar_Click);
            // 
            // picGanador
            // 
            this.picGanador.BackColor = System.Drawing.Color.Transparent;
            this.picGanador.Image = global::Ejercicios_11.Properties.Resources.f_0;
            this.picGanador.Location = new System.Drawing.Point(620, 26);
            this.picGanador.Name = "picGanador";
            this.picGanador.Size = new System.Drawing.Size(106, 98);
            this.picGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanador.TabIndex = 3;
            this.picGanador.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Ejercicios_11.Properties.Resources.f_2;
            this.pictureBox2.Location = new System.Drawing.Point(467, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ejercicios_11.Properties.Resources.f_1;
            this.pictureBox1.Location = new System.Drawing.Point(357, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicios_11.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 379);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picReiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGanador);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FichasTateti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FichasTateti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picGanador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReiniciar;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label label2;
    }
}

