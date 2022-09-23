using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_11
{
    public partial class Form1 : Form
    {
        //variables del programa entero
        int turno = 1;
        int[,] TaTeTi;
        int PuntosJugador1 = 0;
        int PuntosJugador2 = 0;
        bool YaHayGanador;


        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }
        
        //metodo para iniciar la partida
        public void IniciarJuego(){
            // Iniciar Valores del incio de partida
            turno = 1;
            TaTeTi = new int[3, 3];
            YaHayGanador = false;
            
            picGanador.Image = Properties.Resources.f_0; //seteo la imagen del ganador en el tanque
            FichasTateti.Controls.Clear(); //limpio todos los controles para volverlos a cargar

            // Arreglos para mostrar Fichas y asignar valores a la matriz
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox(); //inicio la variable para poder modificar la ficha
                    FichaJuego.Image = Properties.Resources.f_0; //coloco la imagen del tanque en todas las fichas
                    FichaJuego.Name = string.Format("{0}", i + "_" + j); //cambio el nombre de la ficha en funcion de su posicion en la matriz
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand; //seteo el cursor en forma de mano
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage; //pongo el modo de cargar la imagen
                    FichaJuego.Click += Jugar;
                    FichasTateti.Controls.Add(FichaJuego, j, i); //añado el control e las fichas
                    TaTeTi[i, j] = 0;//le asigno 0 a cada valor de la matriz

                
                }
            } //fin recorrida matriz

        }//fin metodo de incio de partida

        //metodo para jugar
        private void Jugar(object sender, EventArgs e) {

            var FichaSeleccionadaUsuario = (PictureBox)sender; //seteo para poder mostrar imagen del jugador
            FichaSeleccionadaUsuario.Enabled = false; //una vez que se juega la ficha no puede volver a seleccionarse

            //esta propiedad carga la imagen correspondiente para cada jugador sobre la casilla que toco
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);

            //
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray()); //divide la cadena en filas y columnas
            int Fila = Convert.ToInt32(Posicion[0]); //pongo la fila en int
            int Columna = Convert.ToInt32(Posicion[1]); //pongo la columna en int
            TaTeTi[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna); //uso las variables de fila y columna como parametros
            turno = (turno == 1) ? 2 : 1; //pasa al turno siguiente

         }//fin metodo jugar



        //metodo verificacion
        public void VerificarJuego(int Fila,int Columna) {
            // Contador de fichas en filas y columnas del tateti
            //obtiene cualquiera de las formas de ganar posibles
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int GanarTateti = 3;


            //se descubre si se realiazo alguna fila columna o diagonal ganadora
            for (var i = 0; i < GanarTateti; i++)
            {
                for (var j = 0; j < GanarTateti; j++)
                {

                    if (i == Fila)
                    {
                        if (TaTeTi[i, j] == turno)
                        {
                            GanoFilas++;
                        }
                    }
                    if (j == Columna)
                    {
                        if (TaTeTi[i, j] == turno)
                        {
                            GanoColumnas++;
                        }
                    }
                    if (i == j) // Diagonal principal
                    {
                        if (TaTeTi[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    if ((i + j) == (GanarTateti - 1)) // Diagonal Inversa
                    {
                        if (TaTeTi[i, j] == turno)
                        {
                            DiagonalInversa++;

                        }
                    }



                }
            } //fin calculos

            //ganador
            if ((GanoFilas == GanarTateti) || (GanoColumnas == GanarTateti) || (DiagonalInversa == GanarTateti) || (DiagonalPrincipal == GanarTateti))
            {
                YaHayGanador = true;
            }
            else {
                bool Empate = true;
                for (var i = 0; i < GanarTateti; i++)
                {
                    for (var j = 0; j < GanarTateti; j++)
                    {
                        if (TaTeTi[i, j] == 0) {
                            Empate = false;
                        }

                    }
                }
                if(Empate){ //si hay un empate la messagebox lo avisa y reinicia el juego
                    MessageBox.Show("Esto es un empate ¡Reinicia el juego!");
                    IniciarJuego();
                }
            
            }
            if (YaHayGanador){
                
                MessageBox.Show("Ya hay ganador"); //si hay un ganador la text box lo avisa
                picGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno); //muestra al ganador en el icono de la derecha
                if (turno == 1) //y suma puntos al jugador correspondiente
                {
                    PuntosJugador1++;
                    lblPlayer1.Text = PuntosJugador1.ToString();
                }
                else
                {
                    PuntosJugador2++;
                    lblPlayer2.Text = PuntosJugador2.ToString();
                }

            
            }


        } //fin metodo para verificar


        //boton reiniciar
        private void picReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJuego(); //inicializa de nuevo el metodo de inicio de juego
        }
    }
}
