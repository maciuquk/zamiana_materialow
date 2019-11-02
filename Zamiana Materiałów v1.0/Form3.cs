using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamiana_Materiałów_v1._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonPrzeliczP6doP_Click(object sender, EventArgs e)
        {
            PrzetworzenieDanych();            
        }

        private void textBoxPodajSredniceP6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PrzetworzenieDanych();
            if (e.KeyCode == Keys.Escape) ZamknijForm3();
        }

        private void PrzetworzenieDanych()
        {
            #region sprawdzenie poprawności wpisanej średnicy
            try
            {
                //double srednica = double.Parse(textBoxPodajSredniceP6.Text);
                double srednica = Convert.ToDouble(textBoxPodajSredniceP6.Text);

            }
            catch
            {
                SystemSounds.Exclamation.Play();
                textBoxPodajSredniceP6.Text = "";
                MessageBox.Show("Podana średnica nie jest prawidłowa!");
                return;
            }

            #endregion

            double[,] tablicaSrednic = new double[,]{
            {4 ,4.6 },
            {4.5 ,5.2 },
            {5 ,5.8 },
            {5.5 ,6.3 },
            {6 ,6.9 },
            {7 ,8.1 },
            {8 ,9.2 },
            {9 ,10.4 },
            {10 ,11.5 },
            {11 ,12.7 },
            {12 ,13.8 },
            {14 ,16.2 },
            {15 ,17.3 },
            {16 ,18.4 },
            {17 ,19.6 },
            {18 ,20.7 },
            {19 ,21.9 },
            {20 ,23.0 },
            {21 ,24.1 },
            {22 ,25.4 },
            {24 ,27.7 },
            {25 ,28.7 },
            {26 ,29.9 },
            {27 ,31.2 },
            {30 ,34.6 },
            {32 ,36.9 },
            {33 ,38.0 },
            {34 ,39.1 },
            {36 ,41.6 },
            {38 ,43.7 },
            {39 ,44.8 },
            {41 ,47.3 },
            {44 ,50.6 },
            {46 ,52.9 },
            {48 ,55.2 },
            {50 ,57.7 }
            };

            double srednica1 = Convert.ToDouble(textBoxPodajSredniceP6.Text);
            bool czyZnalazlSrednice = false;

            for (int i = 0; i < tablicaSrednic.Length / 2; i++)
            {
                if (srednica1 == tablicaSrednic[i, 0])
                {
                    label2.Visible = true;
                    labelSrednicaP6doP.Text = tablicaSrednic[i, 1].ToString() + " mm";
                    czyZnalazlSrednice = true;
                }
            }

            if (!(czyZnalazlSrednice))
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Brak danych, spróbuj wybrać inną średnicę!");

            }
        }

        private void ZamknijForm3()
        {
            this.Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) ZamknijForm3();
        }

        private void buttonPrzeliczP6doP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) ZamknijForm3();
        }
    }




}

      
