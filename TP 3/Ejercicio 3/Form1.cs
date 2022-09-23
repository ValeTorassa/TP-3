/*
3. Desarrollar un programa que permita cargar una cantidad n de números ingresados por el 
usuario y mostrar los números ingresados en un textbox y el resultado en un label.
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

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        int num; //se declara en la clase para poder usarse en mas de un componente

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(num); //convierte en string la variable num y la muestra
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ""; //vacio el mensaje de error

            string numero = txtIngreso.Text;  //guardo el string ingresado en una variable

            listBox1.Items.Add(numero); //y la ahreho a la listbox

            num = num + int.Parse(numero); //sumo el num al total para mostrar con el boton sumar

        }
    }
}
