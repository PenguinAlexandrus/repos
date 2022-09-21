using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool isSymbolAvaiable = false;
        public bool isDotAvaiable = true;
        public String inputString = " ";

        static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        public void inputSymbol(String symb) {
            if ((symb == "+" || symb == "-" || symb == "/" || symb == "*") && isSymbolAvaiable)
            {
                inputString += symb;
                input.Text += symb;
                isSymbolAvaiable = false;
                isDotAvaiable = true;
            } else
            {
                char exSymb = inputString[inputString.Length - 1];
                if (symb == "." && isDotAvaiable)
                {
                    if (exSymb != '-' && exSymb != '+' && exSymb != '*' && exSymb != '/' && exSymb != ' ')
                    {
                        isDotAvaiable = false;
                        inputString += symb;
                        input.Text += symb;
                    }
                }
                else if(!(symb == "+" || symb == "-" || symb == "/" || symb == "*" || symb == "." ))
                {
                    inputString += symb;
                    input.Text += symb;
                    isSymbolAvaiable = true;
                }

            }
            
        }

        public void deleteSymbol()
        {
            String symb = inputString[inputString.Length - 1].ToString();
            if (symb == "+" || symb == "-" || symb == "/" || symb == "*")
            {
                isSymbolAvaiable = true;
                isDotAvaiable = false;
                inputString = inputString.Remove(inputString.Length - 1);
                input.Text = inputString;
            } else
            {
                inputString = inputString.Remove(inputString.Length - 1);
                input.Text = inputString;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор от Седова";
        }
        private void equal_Click(object sender, EventArgs e)
        {
            if (isSymbolAvaiable)   
            {
                double result = Eval(inputString);
                
                inputString = result.ToString("0.00",System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                if (inputString == "∞")
                {
                    inputString = " ";
                    input.Text = "Ошибка деления";
                } else input.Text = inputString;

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputString = " ";
            input.Text = " ";
            isSymbolAvaiable = false;
            isDotAvaiable = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
        }

        private void one_Click(object sender, EventArgs e)
        {
            inputSymbol("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            inputSymbol("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            inputSymbol("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            inputSymbol("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            inputSymbol("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            inputSymbol("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            inputSymbol("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            inputSymbol("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            inputSymbol("9");
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            deleteSymbol();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            inputSymbol("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            inputSymbol("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            inputSymbol("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            inputSymbol("/");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            inputSymbol(".");
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (isSymbolAvaiable)
            {
                double temp = double.Parse(inputString, System.Globalization.CultureInfo.GetCultureInfo("en-US")); ;
                temp *= -1;
                inputString = temp.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                input.Text = inputString;
            }
        }
    }   
}
