using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanz_erde_mond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            double geschwindigkeit = 0;


            if (double.TryParse(textBoxGeschwindigkeit.Text, out geschwindigkeit) == false)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein!");
                textBoxGeschwindigkeit.Focus();
                textBoxGeschwindigkeit.SelectAll();
            }
            else
            {
                tempo tempo = new tempo();
                tempo.geschwindigkeit = geschwindigkeit;

                if (radioButtonTage.Checked)
                {
                    textBoxResult.Text = tempo.ErhalteDauerInTagen().ToString();
                }
                else
                {
                    textBoxResult.Text = tempo.ErhalteDauerInStunden().ToString();
                }
            }
        }
    }
}
