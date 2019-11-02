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
            int zaokraglenie = trackBar1.Value;
            if (radioButtonAlu.Checked == true) gestosc = 2.7; //g/cm3
            if (radioButtonNie.Checked == true) gestosc = 8;
            if (radioButtonSta.Checked == true) gestosc = 8;
            if (radioButtonMie.Checked == true) gestosc = 8;
            if (radioButtonMos.Checked == true) gestosc = 8;
            if (radioButtonTef.Checked == true) gestosc = 8;
            if (radioButtonTek.Checked == true) gestosc = 8;

            label12.Text = "Gestosc: " + gestosc.ToString();            //wywalic



            float srednicaPierwotna = Convert.ToInt32(textBox1.Text); // 1000;

           
            double srednicaDocelowa = Convert.ToInt32(textBox2.Text); // 1000;
            double dlugosc = Convert.ToInt32(textBox4.Text); // 1000;
            srednicaPierwotna /= 10;
            srednicaDocelowa /= 10;
            dlugosc /= 10;

            label13.Text = PI.ToString(); //wywalic

            double objetosc1 = ((PI * (srednicaPierwotna / 2) * (srednicaPierwotna / 2) * dlugosc));
            double objetosc2 = ((PI * (srednicaDocelowa/ 2) * (srednicaDocelowa / 2) * dlugosc));

            double wynik = objetosc2 - objetosc1;


            double waga = (wynik * gestosc / 1000);
            double wartosc = Math.Round(waga * (Convert.ToDouble(textBox6.Text)), zaokraglenie);


            wynik = Math.Round(wynik, zaokraglenie);
            waga = Math.Round(waga, zaokraglenie);


            //  double wynik = ((PI * (srednicaPierwotna / 2) * (srednicaPierwotna / 2) * dlugosc) - (PI * (srednicaDocelowa / 2) * (srednicaDocelowa / 2) * dlugosc));
            label6.Text = "Różnica objętości: " + wynik + "cm3    Waga: " + waga + " kg\nCena:" + wartosc + " PLN" ;


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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int wartosc = trackBar1.Value;
            string slowo = "";
            switch (wartosc)
            {
                case 0:
                    slowo = "miejsc";
                    break;
                case 1:
                    slowo = "miejsce";
                    break;
                case 5:
                    slowo = "miejsc";
                    break;
                case 6:
                    slowo = "miejsc";
                    break;
                default:
                    slowo = "miejsca";
                    break;

            }


            label15.Text = wartosc.ToString() + " " + slowo +" po przecinku";
        }
    }
}
