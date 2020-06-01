using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value;
        string soperator;
        bool check;
        public Form1()
        {
            InitializeComponent();
        }
        private void PNumber(object sender, EventArgs e)
        {
            if((soperator =="+")|| (soperator == "-") || (soperator == "*") || (soperator == "/"))
            {
                if (check)
                {
                    check = false;
                    textResult.Text = "0";
                }
            }
            Button b = sender as Button;
            if (textResult.Text == "0")
                textResult.Text = b.Text;
            else
                textResult.Text += b.Text;
        }
        private void POperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //Convert text to number
            value = double.Parse(textResult.Text);
            soperator = b.Text;
            textResult.Text += b.Text;
            check = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            value = 0;
        }

        private void Btn20_Click(object sender, EventArgs e)
        {

                    switch (soperator)
                    {
                        case "+":

                            textResult.Text = (value + double.Parse(textResult.Text)).ToString();

                            break;
                        case "-":
                            textResult.Text = (value - double.Parse(textResult.Text)).ToString();
                            break;
                        case "*":
                            textResult.Text = (value * double.Parse(textResult.Text)).ToString();
                            break;
                        case "/":
                            textResult.Text = (value / double.Parse(textResult.Text)).ToString();
                            break;
                    }

            
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Int32.TryParse(textResult.Text, out int result);
            textResult.Text = (-result).ToString(); 
        }

        private void Btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
