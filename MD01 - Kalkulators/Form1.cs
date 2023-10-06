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

namespace MD01___Kalkulators
{
    public partial class Form1 : Form
    {
        double firstvalue = 0.0;     // ievades vērtības1 glabāšanai
        double secondvalue = 0.0;    //ievades vērtības2 glabāšanai
        string operation = "";       // darbību simbols
        double result = 0.0;         // rezultāts

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // iespējo KeyPreview 
            this.KeyDown += new KeyEventHandler(Form1_KeyDown); 
        }

        // klaviatūras ievade
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // pārbauda kurš skaitlis NumPad ir nospiests
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    zerro_Click_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    one_Click_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    two_Click_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    three_Click_Click(sender, e);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    for_Click_Click(sender, e);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    five_Click_Click(sender, e);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    six_Click_Click(sender, e);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    seven_Click_Click(sender, e);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    eight_Click_Click(sender, e);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    nine_Click_Click(sender, e);
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                    coma_Click_Click(sender, e);
                    break;
                case Keys.Add:
                    summ_Click_Click(sender, e);
                    break;
                case Keys.Subtract:
                    minuse_Click_Click(sender, e);
                    break;
                case Keys.Multiply:
                    mult_Click_Click(sender, e);
                    break;
                case Keys.Divide:
                    div_Click_Click(sender, e);
                    break;
                case Keys.Enter:
                    equals_Click_Click(sender, e);
                    break;
                case Keys.Delete:
                    Clear_Click_Click(sender, e);
                    break;
                case Keys.Back:
                    Back_click_Click(sender, e);
                    break;
            }
        }

        // Skaitļi

        private void zerro_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")   //ja teksts ir 0
            {
              textBox1.Text = "0";       // tad paliek 0      
            }
            else
            {
              textBox1.Text += "0";     // ja ir citas vērtības ar + pievienojam 0 galā
            }
            
        }

        private void one_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")   // ja teksts ir 0 tad
            {
                textBox1.Text = "1";    // aizstājam ar skaitli, lai nebūtu 01
            }
            else
            {
                textBox1.Text += "1";   // ja ir citas vērtības ar + pievienojam skaitli
            }
        }

        private void two_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void three_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void for_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void five_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void six_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void seven_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void eight_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void nine_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        // operatori


        private void minuse_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "-";
            }

        }

        private void summ_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "+";
            }
        }

        private void div_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "/";
            }
        }

        private void mult_Click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "*";
            }
        }

         private void one_div_x_click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                firstvalue = 1 / firstvalue;
                textBox1.Text = firstvalue.ToString();
            }
        }

        private void squareroot_click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                firstvalue = double.Parse(textBox1.Text);
                firstvalue = Math.Sqrt(firstvalue);
                textBox1.Text = firstvalue.ToString();
            }
        }

        private void percentage_click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                secondvalue = double.Parse(textBox1.Text);
                secondvalue = (firstvalue * secondvalue)/100;
                textBox1.Text = secondvalue.ToString();
            }
        }

        // citi operatori

        private void coma_Click_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }

        }

        private void Clear_Click_Click(object sender, EventArgs e)
        {
           firstvalue = 0;
           secondvalue = 0;
           textBox1.Text = string.Empty;
        }

        private void Clear_lasts_click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                textBox1.Text = string.Empty;
                secondvalue = 0;
            }

            else
            {
                textBox1.Text = "error/no entry!";

            }
        }

        private void Back_click_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "error/no entry!")
            {
                textBox1.Text = string.Empty;
            }
                        
            else if (textBox1.Text.Length >= 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            else
            {
                textBox1.Text = "error/no entry!";

            }
        }

        private void plus_minus_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-")) //ja ir "-" tad noņemam
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;// ja nav "-" pievienojam
            }
        }

        // realizācija "="
        private void equals_Click_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "-":
                    secondvalue = double.Parse(textBox1.Text);
                    result = firstvalue - secondvalue;
                    textBox1.Text = result.ToString();
                    break;

                case "+":
                    secondvalue = double.Parse(textBox1.Text);
                    result = firstvalue + secondvalue;
                    textBox1.Text = result.ToString();
                    break;

                case "/":
                    secondvalue = double.Parse(textBox1.Text);
                    result = firstvalue / secondvalue;
                    textBox1.Text = result.ToString();
                    break;

                case "*":
                    secondvalue = double.Parse(textBox1.Text);
                    result = firstvalue * secondvalue;
                    textBox1.Text = result.ToString();
                    break;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
