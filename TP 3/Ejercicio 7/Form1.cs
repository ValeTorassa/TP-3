/*
Desarrollar un programa que permita calcular los intereses de un plazo fijo. Para ello nos
informan que la manera de obtenerlo es haciendo M * T * D / 36500. Donde: M=Monto, T=Tasa
Nominal Anual, D=Días que dura la imposición. Mostrar los valores ingresados y los resultados
en una Grilla del tipo DataGridView. 
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

namespace Ejercicio_7
{
    public partial class CalculadoraInteres : Form
    {
        int n; //la declaro en este espacio para usarla en los dos botones

        public CalculadoraInteres()
        {
            InitializeComponent();
        }

        //Boton Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //valido que ninguna cadena este vacia
            if(txtMonto.Text == "" || txtTasa.Text == "" || txtDias.Text == "")
            {
                lblError.Text = "Error: Uno o varios espacios estan vacios";

            }
            else
            {


                //Adicionamos nuevo renglon
                n = dtgvDatos.Rows.Add(); //aumenta una fila y regresa su indice

                //colocamos la informacion
                dtgvDatos.Rows[n].Cells[0].Value = txtMonto.Text; //tomamos las filas de indice n
                                                                  //en la columna 0(monto)
                                                                  //e imprimimos en ella el contento de la textbox de monto

                dtgvDatos.Rows[n].Cells[1].Value = txtTasa.Text;//lo mismo con tasa
                                                                //en la columna 1

                dtgvDatos.Rows[n].Cells[2].Value = txtDias.Text;//lo mismo con dias
                                                                //en la columna 2

                //calculo del interes
                double resultado;
                string interes;

                double m = double.Parse(txtMonto.Text); //convierto cada uno de los valores de las txt
                double t = double.Parse(txtTasa.Text);// a double y las guardo en una variable
                double d = double.Parse(txtDias.Text);

                resultado = m * t * d / 36500; //calculo el interes
                resultado = Math.Round(resultado,2); //Redonde y ASIGNO A LA VARIABLE
                interes = Convert.ToString(resultado); //y lo convierto en una string

                //añadir interes a la grilla
                dtgvDatos.Rows[n].Cells[3].Value = interes;

                //limpiamos los textbox y el lbl
                txtMonto.Text = "";
                txtTasa.Text = "";
                txtDias.Text = "";
                lblError.Text = "";


            } //fin validacion

        } //Fin Boton Agregar

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (n > -1) //compruebo que el n sea al menos 0
            {
                dtgvDatos.Rows.RemoveAt(n); //borro la fila n

                n = n - 1; //resto uno a n para que siga de donde estaba
            }


        }
    }
}
