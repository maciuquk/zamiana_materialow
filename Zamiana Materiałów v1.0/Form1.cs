using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamiana_Materiałów_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double PI = Math.PI;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPret_Click(object sender, EventArgs e)
        {

            radioButtonPret.Checked = true;
            textBox3.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;




        }

        private void pictureBoxTuleja_Click(object sender, EventArgs e)
        {
            radioButtonTuleja.Checked = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
        }

        private void pictureBoxPret6_Click(object sender, EventArgs e)
        {
            radioButtonPret6.Checked = true;
           
            textBox3.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrzeliczPret();
        }

        private void PrzeliczPret()
        {
            double gestosc = 0;

            if (radioButtonAlu.Checked == true) gestosc = 2.7;
            if (radioButtonNie.Checked == true) gestosc = 8;

            float srednicaPierwotna = Convert.ToInt32(textBox1.Text); // 1000;
            double srednicaDocelowa = Convert.ToInt32(textBox2.Text); // 1000;
            double dlugosc = Convert.ToInt32(textBox4.Text); // 1000;
            srednicaPierwotna /= 1000;
            srednicaDocelowa /= 1000;
            dlugosc /= 1000;

            double wynik = ((PI * (srednicaPierwotna / 2) * (srednicaPierwotna / 2) * dlugosc) - (PI * (srednicaDocelowa / 2) * (srednicaDocelowa / 2) * dlugosc));
            label6.Text = "Różnica objętości: " + wynik + "cm3\nWaga: " + wynik * gestosc / 1000 + " kg";


        }

        private void radioButtonPret_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonPret6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonTuleja_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonPret_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }

        private void radioButtonTuleja_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
        }

        private void radioButtonPret6_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }
    }
}
