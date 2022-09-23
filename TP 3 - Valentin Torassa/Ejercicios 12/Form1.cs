/*
12. Desarrolle un programa utilizando el control ColorDialog y que el color seleccionado se le asigne
al color de fondo del formulario.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog(); //Creamos el metodo del color
            if (cd.ShowDialog() == DialogResult.OK) //si el identificador del cuadro es devuelto con un ok
            {
                this.BackColor = cd.Color; //el fondo se cambia al color elegido por el user
                btnColor.BackColor = cd.Color; //y del boton tmb
            }
        }
    }
}
