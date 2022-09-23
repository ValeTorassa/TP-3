/*
Desarrollar un programa que simule la tirada de dos dados y mostrar en una grilla la cantidad
de veces que salió cada número y el porcentaje que representa esa cantidad en el total de
tiradas. Las tiradas se deben realizar al oprimir un botón.
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

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables fuera del boton porque no tienen que reiniciarse
        double var1 = 0, var2 = 0, var3 = 0, var4 = 0, var5 = 0, var6 = 0;

        double total = 0;


        private void btnTirar_Click(object sender, EventArgs e)
        {
                //obtencion del numero random
                var random = new Random(); //metodo
                int valor = random.Next(1, 7); //invocacion con minimo incluyente y maximo no incluyente

                //promedios
                total++;

                    switch (valor) //hago un switch usando valor como referencia de los cases
                    {
                        case 1:
                        var1++; //segun que salga en el dado sumo una variable
                        break;

                        case 2:
                        var2++;
                        break;

                        case 3:
                        var3++;
                        break;

                        case 4:
                        var4++;
                        break;

                        case 5:
                        var5++;
                        break;

                        case 6:
                        var6++;
                        break;
                    }

                //saco el promedio de cada una y lo almaceno en el lbl correspondiente
                double prom1, prom2, prom3, prom4, prom5, prom6;

                prom1 = Math.Round(var1/total * 100, 1); //saco el promedio con un decimal
                lblPor1.Text = Convert.ToString(prom1); //convierto en string y almaceno en lbl

                prom2 = Math.Round(var2 / total * 100, 1); 
                lblPor2.Text = Convert.ToString(prom2);    

                prom3 = Math.Round(var3 / total * 100, 1); 
                lblPor3.Text = Convert.ToString(prom3);

                prom4 = Math.Round(var4 / total * 100, 1);
                lblPor4.Text = Convert.ToString(prom4);

                prom5 = Math.Round(var5 / total * 100, 1);
                lblPor5.Text = Convert.ToString(prom5);

                prom6 = Math.Round(var6 / total * 100, 1);
                lblPor6.Text = Convert.ToString(prom6);

                //convierto el numero que dio el dado en string
                lblNum.Text = Convert.ToString(valor); 

                //Adicionamos nuevo renglon en la grind
                 int n = dtgvDatos.Rows.Add(); //aumenta un renglon y regresa su indice

                //colocamos la informacion
                dtgvDatos.Rows[n].Cells[0].Value = valor; //tomamos la fila de indice n
                                                          //en la columna 0
                                                          //e imprimimos valor en ella
              
        }
    }
}
