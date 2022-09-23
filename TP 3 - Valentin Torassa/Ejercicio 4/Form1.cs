/*
4. Desarrollar un programa que permita calcular la suma, resta, multiplicación, división, potencia 
y raíz cuadrada de dos números. Seleccione los controles que utilizará para ingresar los número 
y visualizar el resultado. Las operaciones se ejecutarán con botones de comando.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //COMIENZO SUMA
        private void BTNsumar_Click(object sender, EventArgs e)
        {
            int sumando1;
            int sumando2;
            int rtasuma;

            if (TXTop1.Text == "" || TXTop2.Text == "") //compruebo que ninguno sea un string vacio
            {
                LBLpedirnum.Text = "Uno o los dos operadores estan vacios"; //si es asi envio un mensaje

            }
            else
            {

                LBLpedirnum.Text = ""; //esto es por si anteriormente imprimio el mensaje de "uno de los..."

                sumando1 = int.Parse(TXTop1.Text); //Se convierten de string a enteros
                sumando2 = int.Parse(TXTop2.Text);

                rtasuma = sumando1 + sumando2; //Se suman

                TXTresultado.Text = rtasuma.ToString(); //convertimos la variable int rta suma a string y la mostramos en el resultado

            }
        } //FIN SUMA


        //BOTON SALIR
        private void BTNsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //COMIENZO RESTA
        private void BTNrestar_Click(object sender, EventArgs e)
        {
            int restando1;
            int restando2;
            int rtaresta;

            if (TXTop1.Text == "" || TXTop2.Text == "")
            {
                LBLpedirnum.Text = "Uno o los dos operadores estan vacios";

            }
            else
            {
                LBLpedirnum.Text = "";
                restando1 = int.Parse(TXTop1.Text); //Se convierten de string a enteros
                restando2 = int.Parse(TXTop2.Text);

                rtaresta = restando1 - restando2; //Se restan

                TXTresultado.Text = rtaresta.ToString(); //convertimos la variable int rta a string y la mostramos en el resultado

            }
        } //FIN RESTA


        //COMIENZO MULTIPLICACION
        private void BTNmultiplicacion_Click(object sender, EventArgs e)
        {
            int multiplo1;
            int multiplo2;
            int rtamultiplicacion;

            if (TXTop1.Text == "" || TXTop2.Text == "")
            {
                LBLpedirnum.Text = "Uno o los dos operadores estan vacios";

            }
            else
            {
                LBLpedirnum.Text = "";
                multiplo1 = int.Parse(TXTop1.Text); //Se convierten de string a enteros
                multiplo2 = int.Parse(TXTop2.Text);

                rtamultiplicacion = multiplo1 * multiplo2; //Se multiplican

                TXTresultado.Text = rtamultiplicacion.ToString(); //convertimos la variable int rta a string y la mostramos en el resultado

            }
        } //FIN MULTIPLICACION


        //COMIENZO DIVISION
        private void BTNcociente_Click(object sender, EventArgs e)
        {
            double numerador;
            double denominador;
            double rtadivision;

            if (TXTop1.Text == "" || TXTop2.Text == "")
            {
                LBLpedirnum.Text = "Uno o los dos operadores estan vacios";

            }
            else
            {
                LBLpedirnum.Text = "";
                numerador = double.Parse(TXTop1.Text); //Se convierten de string a enteros
                denominador = double.Parse(TXTop2.Text);


                if (denominador != 0)
                {
                    rtadivision = numerador / denominador; //Se dividen

                    TXTresultado.Text = rtadivision.ToString(); //convertimos la variable int rta a string y la mostramos en el resultado
                }
                else
                {
                    LBLpedirnum.Text = "El denominador no puede ser 0";
                }
            }

        } //FIN DIVISION


        //COMIENZO POTENCIA CUADRADA
        private void button1_Click(object sender, EventArgs e)
        {
            int potencia;
            int potenciafinal;

            if (TXTop1.Text == "")
            {
                LBLpedirnum.Text = "El primer espacio esta vacio";

            }
            else
            {
                LBLpedirnum.Text = "";
                potencia = int.Parse(TXTop1.Text); //Se convierten de string a enteros

                potenciafinal = potencia * potencia; //Se multiplican

                TXTresultado.Text = potenciafinal.ToString(); //convertimos la variable int rta a string y la mostramos en el resultado

            }


        } //FIN POTENCIA CUADRADA

        //COMIENZO RAIZ CUADRADA
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double raiz;

            if (TXTop1.Text == "")
            {
                LBLpedirnum.Text = "El primer espacio esta vacio";

            }
            else
            {
                LBLpedirnum.Text = "";
                raiz = int.Parse(TXTop1.Text); //Se convierten de string a enteros

                double raizCuadrada = Math.Sqrt(raiz);

                TXTresultado.Text = raizCuadrada.ToString();

            }





        } //FIN RAIZ
    }
}

