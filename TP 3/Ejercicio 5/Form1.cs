/*
5. Desarrollar un programa que le permita al usuario indicar un número mínimo y un número 
máximo. Mostrar en un Listbox todos aquellos que son primos.
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

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, contador;


            num1 = int.Parse(txtMinimo.Text); //seteo del minimo
            num2 = int.Parse(txtMaximo.Text); //Seteo del maximo
            lstPrimos.Items.Clear(); //limpio toda la lista 

            for (int i = num1; i < num2; i++) //recorre desde minimo hasta el maximo
            {

                contador = 0;

                if (i > 1) //si es mayor a 1
                {

                    for (int j = 2; j < i; j++) //empieza del dos hasta llegar al numero seleccionado
                    {

                        if (i % j == 0) //deduce si hay o no resto
                        {
                            contador = 1; //sino lo hay se suma contador
                        }

                    }
                    if (contador == 0) //si el contador fue sumado no se agrega a la lista
                                        //en caso contrario se agrega a la listbox
                    {
                        lstPrimos.Items.Add(i);
                    }
                }
            }

        }
    }
}
