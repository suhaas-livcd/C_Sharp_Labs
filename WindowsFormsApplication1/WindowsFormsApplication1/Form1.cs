using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = @"Data Source= SUHAAS; Initial Catalog=FirstDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            MessageBox.Show("Success");
            //Do operations
            SqlDataAdapter adp = new SqlDataAdapter("select * from Student", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string source = @"Data Source= SUHAAS; Initial Catalog=FirstDB; Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand insertCommand = new SqlCommand("INSERT INTO [Student] (NAME,ID) VALUES (@n,@r)", con);
            insertCommand.Parameters.Add("@n", SqlDbType.VarChar, 255, "ID").Value =   textBox1.Text.ToUpper();
            insertCommand.Parameters.Add("@r", SqlDbType.VarChar, 255, "NAME").Value = textBox2.Text;
            int queryResult = insertCommand.ExecuteNonQuery();
            MessageBox.Show("Data were successfully added " + queryResult);
            con.Close();
        }
    }
}
