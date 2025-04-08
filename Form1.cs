using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                if (num == aleatorio)
                {
                    MessageBox.Show($"Gano el juego.El juego es {aleatorio}");
                    DialogResult resultado = MessageBox.Show("¿Quieres volver a jugar?" "Resultado", MessageBoxButtons.YesNO, MessageBoxIcon.Question);
                    if (Resultado = DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtIntentos.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 100);
                    }
                }
                if (num > aleatorio)
                {
                    MessageBox.Show($"{num} es mayor al numero aleatorio");
                }
                if (num < aleatorio)
                {
                    MessageBox.Show($"{num} es menor al numero aleatorio");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5;
            txt.Intentos.Text = intentos.ToString();
            aleatorio = rand.Next(1,100) // aleatorio = numero entre 1 y 100
        }
    }
