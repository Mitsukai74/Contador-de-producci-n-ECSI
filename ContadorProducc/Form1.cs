using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorProducc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Contador 1 sopladora

        int Contador = 0;
        double Ciclodecimas;
        int cicloReal = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ciclodecimas = Convert.ToDouble(TextCiclo.Text);
            cicloReal = Convert.ToInt32(Ciclodecimas);

            timer1.Interval = cicloReal * 1000;

            if (Contador < 50000)
            {
                Contador = Contador + Convert.ToInt32(TextCavidades.Text);
                labelMostrarEnvases.Text = Contador.ToString();             
                PruebaTextBox.Text=Convert.ToString(timer1.Interval);
            }                

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonStart.BackColor = Color.Blue;
            buttonStop.BackColor = Color.YellowGreen;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonStop.BackColor = Color.Red;
            buttonStart.BackColor = Color.YellowGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contador = 0;
            labelMostrarEnvases.Text = Convert.ToString(Contador);
        }
        //contador 2 de inyectoras
        int Contador2 = 0;
        double Ciclodecimas2;
        int cicloReal2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Ciclodecimas2 = Convert.ToDouble(tBcicloInyectoras.Text);
            cicloReal2 = Convert.ToInt32(Ciclodecimas2);

            timer2.Interval = cicloReal2 * 1000;

            if (Contador2 < 50000)
            {
                Contador2 = Contador2 + Convert.ToInt32(tBcavInyectoras.Text);
                MostrarInyectadas.Text = Contador2.ToString();

            }

        }

        private void buttonStarInyec_Click(object sender, EventArgs e)
        {
            timer2.Start();
            buttonStarInyec.BackColor = Color.Blue;
            buttonStopInyec.BackColor = Color.YellowGreen;
        }

        private void buttonStopInyec_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            buttonStopInyec.BackColor = Color.Red;
            buttonStarInyec.BackColor = Color.YellowGreen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contador2 = 0;
            MostrarInyectadas.Text = Convert.ToString(Contador2);
        }
        // contador  1 inyectoras
        int Contador3 = 0;
        double Ciclodecimas3;
        int cicloReal3 = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            Ciclodecimas3 = Convert.ToDouble(textBoxInyecCiclo2.Text);
            cicloReal3 = Convert.ToInt32(Ciclodecimas3);
            //Contador3 = Convert.ToInt32(textBox1.Text);
            timer3.Interval = cicloReal3 * 1000;

            if (Contador3 < 50000)
            {
                Contador3 = Contador3 + Convert.ToInt32(textBoxInyecCavi2.Text);
                MostrarInyectadas2.Text = Contador3.ToString();
            }

        }

        private void buttonStartInyecc2_Click(object sender, EventArgs e)
        {
            timer3.Start();
            buttonStartInyecc2.BackColor = Color.Blue;
            buttonInyeccStop2.BackColor = Color.YellowGreen;
        }

        private void buttonInyeccStop2_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            buttonInyeccStop2.BackColor = Color.Red;
            buttonStartInyecc2.BackColor = Color.YellowGreen;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contador3 = 0;
            MostrarInyectadas2.Text = Convert.ToString(Contador3);

        }
       
    }
}
