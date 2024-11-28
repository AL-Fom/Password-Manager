using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF_Wanna_Laugh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //the line below is a condition check, the if statement validates input box 1 to see if the input is admin 
            if (textBox1.Text=="admin")
            {
                //the line below is a condition check, the if statement validates input box 2 to see if the input is qwerty
                if (textBox2.Text=="qwerty")
                {
                 //the code below executes once both of the conditions are met which hides the current form and opens form 2 
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
