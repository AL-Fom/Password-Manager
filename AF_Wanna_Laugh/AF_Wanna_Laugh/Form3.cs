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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // len defines the length of the generated password
            int len = 12;
            // the characters which can appear in a generated password
            const string ValidChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@?£$&*";

            //begins generating the string 
            StringBuilder result = new StringBuilder();
            //sets it to a random generator
            Random rand = new Random();
            //a condition based loop that repeats itself until it meets the condition of the length of the generated password defined above
            while (0 < len--)
            {
                //add the randomly generated character to a string called result, repeats until loop ends
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }
            //print the result to textbox 1
            textBox1.Text = result.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           //closes this form opens menu page
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
