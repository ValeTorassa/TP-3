/*
 Desarrollar un programa que simule la tirada de un dado
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

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            var random = new Random(); //creamos el metodo random
            int valor = random.Next(1, 7); //usamos el metodo random y next
                                          //para obtener un valor aleatorio entre 1 y 7
                                          //(incluye al 1 pero excluye al 7)

            lblNum.Text = Convert.ToString(valor); //convertimos el valor random a string
                                                    //y lo cargamos al lbl
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
