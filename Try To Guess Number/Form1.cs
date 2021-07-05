using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_To_Guess_Number
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Please write below a number from 1 to 100";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var randomNumber = rand.Next(1, 101);
            var userNumber = int.Parse(textBox1.Text);
            if (userNumber == randomNumber)
            {
                label2.Text = "Amazing! Your number was exatly the same as random number";
            }
            else if (userNumber<randomNumber)
            {
                label2.Text = "Sorry Your number was slower than random number. Random number was " + randomNumber;
            }
            else
            {
                label2.Text = "Sorry Your number was higher than random number. Random number was " + randomNumber;
            }
        }
    }
}
