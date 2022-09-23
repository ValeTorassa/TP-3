/*
 13. Desarrolle un programa utilizando el control FileDialog y seleccionar una imagen que se vea en
un control PictureBox.
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

namespace Ejercicios_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog()) //usando el open file dialog
            {
                dlg.Title = "Open Image"; 
                dlg.Filter = "jpg files (*.jpg)|*.jpg"; //filtro las imagenes jpg

                if (dlg.ShowDialog() == DialogResult.OK) //si la busqueda resulta correcta
                {
                    PictureBox pictureBox = new PictureBox(); //con el metodo picturebox

                    pbImagen.Image = new Bitmap(dlg.FileName); //cargo el file en la
                                                               //direccion de la picture
                                                               //box del programa

                    
                    this.Controls.Add(pbImagen);//y la añado
                }
            }
        }
    }
}
