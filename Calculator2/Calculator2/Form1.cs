using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {

        String operation = "";
        double firstNum, secondNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textDisplay.Text == "0") // if textBox contain 0 => write nothing
                textDisplay.Text = "";

            if(b.Text == ".") //if user click . button
            {
                // make sure there is one and only one .
                if (!textDisplay.Text.Contains(".")) //if textBox dosenot contain .
                    textDisplay.Text = textDisplay.Text + b.Text; //put .
            }

            else   //if user enter any num put that num in textBox
            {
                textDisplay.Text = textDisplay.Text + b.Text;
            }


        }

        private void C_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0"; // To clear textBox
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            String f, s;
            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            s = "";
            f = "";
        }

        private void Operations(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = Convert.ToDouble(textDisplay.Text);
            operation = b.Text; // assign operator + - / * to operation variable
            textDisplay.Text = ""; // clear first num

        }

        private void BackSpace_Click(object sender, EventArgs e) //delete only one num
        {
            if (textDisplay.Text.Length > 0) 
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length -1 ,1);
            }
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }

        private void PlusMiuns_Click(object sender, EventArgs e)
        {
            // if num is negative  => remove -
            if (textDisplay.Text.Contains("-"))
            {
                textDisplay.Text = textDisplay.Text.Remove(0, 1);
            }
            else // if positive => convert him to negative
            {
                textDisplay.Text = "-" + textDisplay.Text;
            }
               

        }

        private void equal_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(textDisplay.Text);
            switch (operation)
            {
                case "+":
                    textDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    textDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    textDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    textDisplay.Text = Convert.ToString(firstNum / secondNum);
                    break;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
