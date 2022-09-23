/*
1. Desarrollar un programa que permita ingresar dos números por medio de inputbox y retorne 
la suma de los mismos en un messagebox.
*/
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{

    public partial class FormularioInputBoxSuma : Form
    {
        
        public FormularioInputBoxSuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1;
            int valor2;


            valor1 = int.Parse(Interaction.InputBox("Ingrese el numero 1")); //esto activa la inputbox 
                                                                    //en esta inputbox se pueden ingresar datos
                                                                    //se debe habilitar el visual basic

            valor2 = int.Parse(Interaction.InputBox("Ingrese el numero 2")); //cada uno de los componentes se convierte a int

            int valor3 = valor1 + valor2;

            LblResultado.Text = Convert.ToString(valor3); //el resultado es convertido en string para poder ser mostrado

            MessageBox.Show("El resultado es " + valor3, "Resultado"); //el ,"resultado" es el titulo que tendra la messagebox

        }
    }
}
