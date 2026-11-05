using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace definitiva
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte nota1 = byte.Parse(Textnota1.Text);// aqui estamos guardando una variable utilizando nuestro Textbox
            byte nota2 = byte.Parse(Textnota2.Text);// aqui estamos guardando una variable utilizando nuestro Textbox
            byte nota3 = byte.Parse(Textnota3.Text);// aqui estamos guardando una variable utilizando nuestro Textbox
            float Promedio = ((nota1 + nota2 + nota3) / 3);// esta es la formula de nuestro promedio
            MessageBox.Show("El resultado es" + Promedio);// mostramos el resultado en pantalla
        }
    }
}
