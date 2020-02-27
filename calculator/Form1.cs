using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OperatorList.SelectedIndex = 0;
        }

        private void CalculteButton_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (!double.TryParse(InputBox1.Text, out num1) || !double.TryParse(InputBox2.Text, out num2))
            {
                Answer.Text = "Invalid Input";
                return;
            }
            switch(OperatorList.Text)
            {
                case "+": Answer.Text = (num1 + num2).ToString(); break;
                case "-": Answer.Text = (num1 - num2).ToString(); break;
                case "*": Answer.Text = (num1 * num2).ToString(); break;
                case "/": Answer.Text = num2==0? "Invalid Input":(num1 / num2).ToString(); break;
                default: Answer.Text = "Invalid Input";break;

            }
        }
    }
}
