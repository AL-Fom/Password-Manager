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
    public partial class Form4 : Form
    {
        //similar to how we have done it with loading the forms, we are creating a new reference name calling it passAdapt
        DataSet1TableAdapters.tblPassTableAdapter passAdapt
               = new DataSet1TableAdapters.tblPassTableAdapter();
        //here we create an incrementing counter for the ID
        string CurrentID;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //hide the form to load the menu
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tblPass' table. You can move, or remove it, as needed.
            this.tblPassTableAdapter.Fill(this.dataSet1.tblPass);
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           //here we reference the dataset and call the query addData and we add the data from textbox1 2 and 3, then clear the textboxes
           //we update the grid at the end so that we can see the changes on the form
            passAdapt.AddData(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            GridUpdate();
        }
        private void GridUpdate()
           //here we create a function called gridupdate which we call upon at the end of every button
        {
            dataGridView1.DataSource = passAdapt.GetData();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check that the ID we've searched for is more than 0
            if (CurrentID.Length > 0)
            {
                //referencing the dataset we call the updateData query.
                //loads the textbox information into the releveant ID 
                passAdapt.UpdateData(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(CurrentID));
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
                CurrentID = "";
                textBox4.Focus();
                //grid updates to show on the form
                GridUpdate();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //check that the ID is more than null
            if (CurrentID.Length > 0)
            {
                //call on the table, calls deletedata query according to the ID of the data, clears textboxes
                passAdapt.DeleteData(int.Parse(CurrentID));
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
                CurrentID = "";
                //updates grid to show on form
                GridUpdate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //references the datatable and takes input from the search box
            AF_Wanna_Laugh.DataSet1.tblPassDataTable dt = new DataSet1.tblPassDataTable();
            string input = textBox4.Text;
            CurrentID="";
            //if the id from the search is more than 0 loads the data found from the dataset into the textboxes according to the
            //information stored in the dataset with that ID
            if (input.Length>0)
            {
                passAdapt.FindData(dt, input);
                DataRow dr = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    CurrentID = dr["Id"].ToString();
                    textBox1.Text = dr["Application"].ToString();
                    textBox2.Text = dr["Username"].ToString();
                    textBox3.Text = dr["Password"].ToString();
                }

            }
        }
    }
}
