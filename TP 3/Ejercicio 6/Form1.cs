/*
6. Desarrollar un programa que permita calcular los primeros n números de la serie de Fibonacci. 
El número n es ingresado por el usuario.
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

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int a = 0; //La secuencia fibonnaci empieza desde el 0
            int b = 1;
            int auxiliar;
            int maximo;

            maximo = int.Parse(txtMaximo.Text); //seteo del limite

            for (int i = 0; i < maximo; i++) //uso el numero maximo como tope del for
            {
                auxiliar = a; //en el auxiliar se guarda la a
                a = b; //en la a se guarda la b
                b = auxiliar + a; //en la b se suman tanto la a como el auxiliar
                listBox1.Items.Add(a); //para luego agregarse en la lista de items
            }

        }
    }
}
