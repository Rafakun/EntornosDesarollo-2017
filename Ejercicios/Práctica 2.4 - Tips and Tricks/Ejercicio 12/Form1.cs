using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Entornos2017
{
    //public partial class Form1 : Form
    //{
    // Esta parte se ha comentado mediante el atajo "Ctrl+k, Ctrl+C"

    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        int numero, i;
    //        string texto;

    //        numero = int.Parse(textBox1.Text);
    //        i = 2;
    //        texto = "Numero pares del 2 al " + numero + " : ";

    //        while (i <= numero)
    //       {
    //            texto = texto + i + " , ";
    //           i = i + 2;
    //       }
    //        MessageBox.Show(texto);
    //    }

    //    private void button2_Click(object sender, EventArgs e)
    //    {
    //        int numero, i;
    //        string texto;

    //        numero = int.Parse(textBox1.Text);
    //        i = 2;
    //        texto = "Numero pares del 2 al " + numero + " : ";

    //        do
    //        {
    //            texto = texto + i + " , ";
    //            i = i + 2;
    //        }
    //        while (i <= numero);

    //        MessageBox.Show(texto);
    //    }

    //    private void button3_Click(object sender, EventArgs e)
    //    {
    //        int numero, i;
    //        string texto;

    //        numero = int.Parse(textBox1.Text);
    //        i = 2;
    //        texto = "Numero pares del 2 al " + numero + " : ";

    //        for (i = 2; i <= numero; i = i + 2)
    //            texto = texto + i + " , ";

    //        MessageBox.Show(texto);
    //    }
    #region Parte Rehecha con todos los code snipets y atajos posibles (esta región se ha introducido mediante Code Snippet)
    // Clase introducida con code snippet, formateada mediante Ctrl+K y Ctrl+F, los puntos de interrupcion se han introducido con F9
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, i = 2; string texto;

            numero = int.Parse(textBox1.Text);
            texto = "Numero pares del 2 al " + numero + " : ";
                        
            //Estructura del while con code snippet, su contenido ha sido introducido con "Surround" Crtl+K, Ctrl+S.
            while (i <= numero)
            {
                texto = texto + i + " , ";
                i = i + 2;
            }
            MessageBox.Show(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero, i = 2; string texto;

            numero = int.Parse(textBox1.Text);
            i = 2;
            texto = "Numero pares del 2 al " + numero + " : ";
            //Do while + "Surround" Crtl+K, Ctrl+S mediante Code Snippet.
            do
            {
                texto = texto + i + " , ";
                i = i + 2;
            }
            while (i <= numero);

            MessageBox.Show(texto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero, i = 2; string texto;

            numero = int.Parse(textBox1.Text);
            i = 2;
            texto = "Numero pares del 2 al " + numero + " : ";

            //For y "Surround" Crtl+K, Ctrl+S con code Snippet.
            for (i = 2; i <= numero; i = i + 2)
                texto = texto + i + " , ";

            MessageBox.Show(texto);
        }
    }
}
#endregion

