using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculaorCShard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String s;
        double beforeCal;
        double afterCal;
        String algo;
        private void calButton(String algo1)
        {
            switch (algo1)
            {
                case "+":
                    algo = "+";
                    equal();
                    textBox1.Text = beforeCal + "+";
                    
                    break;
                case "X":
                    algo = "X";
                    equal();
                    textBox1.Text = beforeCal + "X";
                    break;
                case "/":
                    algo = "/";
                    equal();
                    textBox1.Text = beforeCal + "*";
                    break;
                case "-":
                    algo = "-";
                    equal();
                    textBox1.Text = beforeCal + "-";
                    break;
                default:
                    textBox1.Text = "0";
                    break;
            }

            s = "";

        }
        double equal()
        {
            try
            {
                afterCal = Double.Parse(s);
            }
            catch (Exception e)
            {
                textBox1.Text = "E";
            }
            switch (algo)
            {
                case "+":
                    beforeCal = beforeCal + afterCal;
                    break;
                case "X":
                    if (beforeCal == 0)
                        beforeCal = afterCal;
                    else
                        beforeCal = beforeCal * afterCal;
                    break;
                case "/":
                    if (beforeCal == 0)
                        beforeCal = afterCal;
                    else if (afterCal == 0)
                        textBox1.Text = "E";
                    else
                        beforeCal = beforeCal / afterCal;
                    break;
                case "-":
                    if (beforeCal == 0)
                        beforeCal = afterCal;
                    else
                        beforeCal = beforeCal - afterCal;
                    break;
                default:
                    textBox1.Text= "0";
                    break;
            }
            return beforeCal;
        }
        void equalLast()
        {
            textBox1.Text = beforeCal.ToString();
            beforeCal = 0;
            s = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "7";
            s = s + 7;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            calButton("+");
        }

        private void but0_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "0";
            s = s + 0;
        }

        private void but00_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "00";
            s = s + 00;
        }

        private void butDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + ".";
            s = s + ".";
        }

        private void but1_Click(object sender, EventArgs e)
        {
            textBox1.Text = s+"1";
            s = s + 1;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "2";
            s = s + 2;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "3";
            s = s + 3;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "4";
            s = s + 4;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "5";
            s = s + 5;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "6";
            s = s + 6;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "8";
            s = s + 8;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textBox1.Text = s + "9";
            s = s + 9;
        }

        private void minBut_Click(object sender, EventArgs e)
        {
            calButton("-");
        }

        private void mulBut_Click(object sender, EventArgs e)
        {
            calButton("X");
        }

        private void divBut_Click(object sender, EventArgs e)
        {
            calButton("/");
        }

        private void acBut_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            s = "";
            beforeCal = 0;
        }

        private void cBut_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            s = "";
        }

        private void eqBut_Click(object sender, EventArgs e)
        {
            equal();
            equalLast();
        }
    }
}
