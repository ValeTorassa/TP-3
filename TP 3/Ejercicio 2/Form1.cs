/*
2. Desarrollar un programa que permita ingresar dos números por medio de cajas de texto y 
retorne la suma de los mismos en un label.
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

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "") //comprueba que ninguno de los textbox esten vacios
            {
                lblError.Text = "Complete los dos campos";
            }
            else
            {
                lblError.Text = ""; //se borra el mensaje de error

                int valor1 = int.Parse(txtNumero1.Text);
                int valor2 = int.Parse(txtNumero2.Text);

                int valor3 = valor1 + valor2;
                lblResultado.Text = Convert.ToString(valor3);//se renconvierte en string para poder ser mostrado

            }
        }
    }
}
