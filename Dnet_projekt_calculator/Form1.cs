using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnet_projekt_calculator
{
    public partial class Form1 : Form
    {
        Double result_vrijednost = 0;
        String operacija_napravljena = "";
        bool operacijaJeNapravljena = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void broj_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || operacijaJeNapravljena == true)
            {
                textBox1.Clear();
            }
            operacijaJeNapravljena = false;

            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result_vrijednost != 0)
            {
                tipkaJednako.PerformClick();
                operacija_napravljena = button.Text;
                label1.Text = result_vrijednost + " " + operacija_napravljena;
                operacijaJeNapravljena = true;
            }
            else
            {
                operacija_napravljena = button.Text;
                result_vrijednost = Double.Parse(textBox1.Text);
                label1.Text = result_vrijednost + " " + operacija_napravljena;
                operacijaJeNapravljena = true;
            }


        }

        private void tipkaClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void tipkaBrisi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result_vrijednost = 0;
        }

        private void tipkaJednako_Click(object sender, EventArgs e)
        {
            switch (operacija_napravljena)
            {
                case "+":
                    textBox1.Text = (result_vrijednost + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result_vrijednost - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result_vrijednost * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result_vrijednost / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result_vrijednost = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void tipkaKorijenClick(object sender, EventArgs e)
        {
            result_vrijednost = 0;
            operacija_napravljena = "";
            operacijaJeNapravljena = false;
            textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
            result_vrijednost = Double.Parse(textBox1.Text);
            label1.Text = "";

        }

        private void tipkaKvadartClick(object sender, EventArgs e)
        {
            result_vrijednost = 0;
            operacija_napravljena = "";
            operacijaJeNapravljena = false;
            textBox1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)).ToString();
            result_vrijednost = Double.Parse(textBox1.Text);
            label1.Text = "";

        }
    }
}
