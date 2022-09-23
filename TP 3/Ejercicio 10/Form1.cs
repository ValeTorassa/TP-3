/*
Desarrollar un programa que permita transformar temperaturas entre las siguientes escalas:
Celsius, Fahrenheit, Kelvin, Rankine. el programa deberá permitir indicar: la escala inicial, la
escala final y la cantidad a transformar. Se debe obtener la cantidad en la escala final. Los
valores ingresados y calculados deberán permaneces visibles en una grilla.
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_10
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
            //seteo el tipo default
            cmbInicio.SelectedItem = "Celsius";
            cmbFinal.SelectedItem = "Celsius";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            if(txtGrados.Text != "") //validacion de que grados no este vacio
            {
                //corrigo el error del punto
                txtGrados.Text = txtGrados.Text.Replace(".", ",");

                double grados = Double.Parse(txtGrados.Text); //convierto en double y almaceno

                //tomamos el index del tipo seleccionado de inicio
                int tipo1 = cmbInicio.SelectedIndex;
                //siendo 0: Celsius 1:Fahrenheit 2:Kelvin 3:Rankine


                //index del tipo seleccionado de salida
                int tipo2 = cmbFinal.SelectedIndex;


                double resultado = 0;

                switch (tipo1){ //switch con el index del tipo de inicio
                


                    //Transformando Celsius
                    case 0:

                        if(tipo2 == 0) //Celsius a Celsius
                        {
                            resultado = grados;
                        } 
                        else if (tipo2 == 1) //Celsius a Fahrenheit
                        {
                            resultado = (grados * 1.8) + 32;
                        } 
                        else if(tipo2 == 2) //Celsius a Kelvin
                        {
                            resultado = grados + 273.15;
                        }
                        else //Celsius a Rankine
                        {
                            resultado = (grados * 1.8) + 491.67;
                        }
                    break;
                    //fin celsius



                    //Transformando Fahrenheit
                    case 1:

                        if (tipo2 == 0) //Fahrenheit a Celsius
                        {
                            resultado = (grados - 32) * 0.55555;
                        }
                        else if (tipo2 == 1) //Fahrenheit a Fahrenheit
                        {
                            resultado = grados;
                        }
                        else if (tipo2 == 2) //Fahrenheit a Kelvin
                        {
                            resultado = (grados - 32) * 0.55555 + 273.15;
                        }
                        else //Fahrenheit a Rankine
                        {
                            resultado = grados + 459.67;
                        }
                        break;
                        //fin fahrenheit



                    //Transformando Kelvin
                    case 2:

                        if (tipo2 == 0) //Kelvin a Celsius
                        {
                            resultado = grados - 273.15;
                        }
                        else if (tipo2 == 1) //Kelvin a Fahrenheit
                        {
                            resultado = (grados - 273.15) * 1.8 + 32;
                        }
                        else if (tipo2 == 2) //Kelvin a Kelvin
                        {
                            resultado = grados;
                        }
                        else //Kelvin a Rankine
                        {
                            resultado = grados * 1.8;
                        }
                        break;
                        //fin Kelvin



                    //Transformando Rankine
                    case 3:

                        if (tipo2 == 0) //Rankine a Celsius
                        {
                           resultado = (grados - 491.67) * 0.55555;
                        }
                        else if (tipo2 == 1) //Rankine a Fahrenheit
                        {
                            resultado = grados - 459.67;
                        }
                        else if (tipo2 == 2) //Rankine a Kelvin
                        {
                            resultado = grados * 0.55555;
                        }
                        else //Rankine a Rankine
                        {
                            resultado = grados;
                        }

                        break;
                        //fin Rankine

                } //fin switch


                //carga de datos

                //Adicionamos nuevo renglon en la grind
                int n = dtgvDatos.Rows.Add(); //aumenta un renglon y regresa su indice

                //redondeo los grados y transformo a string
                resultado = Math.Round(resultado, 2);

                //colocamos la informacion
                dtgvDatos.Rows[n].Cells[0].Value = cmbFinal.Text;
                dtgvDatos.Rows[n].Cells[1].Value = Convert.ToString(resultado);


            }
            else
            {
                lblError.Text = "Error: Campo vacio";
            } //fin validacion

            

        }
    }
}
