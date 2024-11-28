using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AF_Wanna_Laugh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //on click closes this form opens the login page  
        this.Hide();
        Form1 f1 = new Form1();
        f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //on click closes this form opens the generator page
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on click closes this form opens the passwords page  
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
