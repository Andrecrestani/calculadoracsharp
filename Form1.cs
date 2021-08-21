using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";



        public Form1()
        {
            InitializeComponent();
        }
        
        private void bt0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = Decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "soma";
                lblOperação.Text = "+";
            }
            
            
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor2 = Decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "soma")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                if (operacao == "subtração")
                {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                if (operacao == "multiplicação")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                if (operacao == "divisão")
                {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void tb13_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = Decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "subtração";
                lblOperação.Text = "-";
            }
        }

        private void bt14_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = Decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "multiplicação";
                lblOperação.Text = "x";
            }
        }

        private void bt15_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = Decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "divisão";
                lblOperação.Text = "/";
            }
        }

        private void bt16_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperação.Text = "";

        }

        private void bt10_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ".";
        }
    }
}
