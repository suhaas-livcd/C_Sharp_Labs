using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Address_Book_Maintenance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validating the password
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            //NUll values
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Please fill the fields");
            }
            else {
                //Authentication
                if (username.Equals("admin") || password.Equals("admin")) {
                    
                    
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();
                }
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
