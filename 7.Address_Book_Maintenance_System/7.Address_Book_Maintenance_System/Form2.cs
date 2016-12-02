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
namespace _7.Address_Book_Maintenance_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.SlateGray;
            textBox2.ForeColor = Color.SlateGray;
            textBox3.ForeColor = Color.SlateGray;
            textBox4.ForeColor = Color.SlateGray;
            textBox5.ForeColor = Color.SlateGray;
            textBox6.ForeColor = Color.SlateGray;
            textBox7.ForeColor = Color.SlateGray;
            textBox8.ForeColor = Color.SlateGray;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            Hideall();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
           
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
          
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Black;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
            
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.Black;
            
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.Black;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formsDbDataSet.citizendetails' table. You can move, or remove it, as needed.
            
        }
        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            Visibleall();
            bool val = true;
                val = IfNotNull();
            if (val==false)
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                string source = @"Data Source= SUHAAS;Initial Catalog=FormsDb;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                SqlCommand insertCommand = new SqlCommand("INSERT INTO [citizendetails] (addressdb,pindb,citydb,statedb,countrydb,phonedb,maildb,aadharnum) VALUES (@addr,@pin,@city,@state,@country,@phone,@mail,@aadhar)", con);
                insertCommand.Parameters.Add("@addr", SqlDbType.VarChar, 255, "addressdb").Value = textBox2.Text;
                insertCommand.Parameters.Add("@pin", SqlDbType.VarChar, 255, "pindb").Value = textBox6.Text;
                insertCommand.Parameters.Add("@city", SqlDbType.VarChar, 255, "citydb").Value = textBox5.Text;
                insertCommand.Parameters.Add("@state", SqlDbType.VarChar, 255, "statedb").Value = textBox4.Text;
                insertCommand.Parameters.Add("@country", SqlDbType.VarChar, 255, "countrydb").Value = textBox3.Text;
                insertCommand.Parameters.Add("@phone", SqlDbType.VarChar, 255, "phonedb").Value = textBox7.Text;
                insertCommand.Parameters.Add("@mail", SqlDbType.VarChar, 255, "maildb").Value = textBox8.Text;
                insertCommand.Parameters.Add("@aadhar", SqlDbType.VarChar, 255, "aadharnum").Value = textBox1.Text;
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult > 0)
                {
                    label1.Text = "Records Inserted Successfully";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Try Again";
                    label1.ForeColor = Color.Red;
                }
                SqlDataAdapter adp = new SqlDataAdapter("select * from citizendetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            
          
        }

        public bool IfNotNull()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "" || textBox6.Text == "" ||
                textBox7.Text == "" || textBox8.Text == "" || textBox5.Text.Equals("City")) {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Hideall() {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            button5.Visible = false;
        }
        public void Visibleall()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
        }

        public void ButtonVisible() {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hideall();
            textBox7.Visible = true;
            textBox8.Visible = true;
            button5.Visible = true;
            label1.Text = "Fill the Visible Boxes for verification";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string phonenum, mailid;
            phonenum = textBox7.Text;
            mailid = textBox8.Text;
            if (phonenum != null || mailid != null || phonenum != "Phone Number" || mailid != "Mail Id")
            {
                string source = @"Data Source= SUHAAS;Initial Catalog=FormsDb;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                SqlCommand insertCommand = new SqlCommand("Select * from  [citizendetails] WHERE phonedb=@phone AND maildb=@mail", con);
                insertCommand.Parameters.Add("@phone", SqlDbType.VarChar, 255, "phonedb").Value = phonenum;
                insertCommand.Parameters.Add("@mail", SqlDbType.VarChar, 255, "maildb").Value = mailid;
                SqlDataReader queryResult = insertCommand.ExecuteReader();
                while (queryResult.Read())
                {
                    textBox2.Text = queryResult[0].ToString();
                    textBox6.Text = queryResult[1].ToString();
                    textBox3.Text = queryResult[2].ToString();
                    textBox4.Text = queryResult[3].ToString();
                    textBox5.Text = queryResult[4].ToString();
                    textBox1.Text = queryResult[7].ToString();
                }

                if (queryResult !=null)
                {
                    Visibleall();
                    button2.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    label1.Text = "Click below to Update";
                    label1.ForeColor = Color.Green;
                    textBox7.Text = phonenum;
                    textBox8.Text = mailid;
                    button6.Visible = true;
                    button5.Visible = false;
                    button6.Text = "Update Please";
                }
                else
                {
                    label1.Text = "Invalid Credentials"+queryResult;
                    label1.ForeColor = Color.Red;
                }
                con.Close();
            }
            else { MessageBox.Show("Enter the fields "); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string phonenum, mailid;
            phonenum = textBox7.Text;
            mailid = textBox8.Text;
           
            bool val = true;
            val = IfNotNull();
            if (val == false)
            {
                MessageBox.Show("Please Fill out all the fields");
            }
            else
            {
                string source = @"Data Source= SUHAAS;Initial Catalog=FormsDb;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                SqlCommand insertCommand = new SqlCommand("UPDATE [citizendetails] SET addressdb=@addr,pindb=@pin,citydb=@city,statedb=@state,countrydb=@country,aadharnum=@aadhar WHERE phonedb=@phone AND maildb=@mail", con);
                insertCommand.Parameters.Add("@addr", SqlDbType.VarChar, 255, "addressdb").Value = textBox2.Text;
                insertCommand.Parameters.Add("@pin", SqlDbType.VarChar, 255, "pindb").Value = textBox6.Text;
                insertCommand.Parameters.Add("@city", SqlDbType.VarChar, 255, "citydb").Value = textBox5.Text;
                insertCommand.Parameters.Add("@state", SqlDbType.VarChar, 255, "statedb").Value = textBox4.Text;
                insertCommand.Parameters.Add("@country", SqlDbType.VarChar, 255, "countrydb").Value = textBox3.Text;
                insertCommand.Parameters.Add("@aadhar", SqlDbType.VarChar, 255, "aadharnum").Value = textBox1.Text;
                insertCommand.Parameters.Add("@phone", SqlDbType.VarChar, 255, "phonedb").Value = textBox7.Text;
                insertCommand.Parameters.Add("@mail", SqlDbType.VarChar, 255, "maildb").Value = textBox8.Text;
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult > 0)
                {
                    label1.Text = "Updated Successfully";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Try Again";
                    label1.ForeColor = Color.Red;
                }
                SqlDataAdapter adp = new SqlDataAdapter("select * from citizendetails ", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
                button5.Visible = false;
                button6.Visible = false;
                button2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            Hideall();
            textBox7.Visible = true;
            textBox8.Visible = true;
            label1.Text = "Press Confirm after Entering Details";
            label1.ForeColor = Color.Red;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string source = @"Data Source= SUHAAS;Initial Catalog=FormsDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand insertCommand = new SqlCommand("DELETE [citizendetails] FROM  [citizendetails]  WHERE phonedb=@phone AND maildb=@mail", con);
            insertCommand.Parameters.Add("@phone", SqlDbType.VarChar, 255, "phonedb").Value = textBox7.Text;
            insertCommand.Parameters.Add("@mail", SqlDbType.VarChar, 255, "maildb").Value = textBox8.Text;
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult > 0)
            {
                label1.Text = "Deleted Successfully";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Data Not Found";
                label1.ForeColor = Color.Red;
            }
            SqlDataAdapter adp = new SqlDataAdapter("select * from citizendetails ", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string aadharnum;
            aadharnum = textBox1.Text;
            if (aadharnum != "" || aadharnum.Equals("Aadhar Card Number"))
            {
                string source = @"Data Source= SUHAAS;Initial Catalog=FormsDb;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                SqlCommand insertCommand = new SqlCommand("Select * from  [citizendetails] WHERE aadharnum=@aadhar", con);
                insertCommand.Parameters.Add("@aadhar", SqlDbType.VarChar, 255, "aadharnum").Value = aadharnum;
                SqlDataReader queryResult = insertCommand.ExecuteReader();
                if (!queryResult.HasRows)
                {
                    label1.Text = "Not Found";
                    label1.ForeColor = Color.Red;
                    ButtonVisible();
                    Visibleall();
                    MessageBox.Show("No Records are found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else {
                    while (queryResult.Read())
                    {
                        textBox2.Text = queryResult[0].ToString();
                        textBox6.Text = queryResult[1].ToString();
                        textBox3.Text = queryResult[2].ToString();
                        textBox4.Text = queryResult[3].ToString();
                        textBox5.Text = queryResult[4].ToString();
                        textBox1.Text = queryResult[7].ToString();
                        textBox7.Text = queryResult[5].ToString();
                        textBox8.Text = queryResult[6].ToString();
                    }
                    Visibleall();
                    label1.Text = "Record Found";
                    label1.ForeColor = Color.Green;
                    Visibleall();
                    ButtonVisible();
                    button8.Visible = false;
                }
                
                con.Close();
            }
            else { MessageBox.Show("Enter the fields"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hideall();
            textBox1.Visible = true;
            button8.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button7.Visible = false;

            label1.Text = "Enter the Aadhar Card Number to Search";
            label1.ForeColor = Color.Red;
        }
    }
}
