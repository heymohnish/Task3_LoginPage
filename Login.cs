using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task3_LoginPage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.employeeDataSet1.EMPLOYEE);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  string css = "Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True;";
            NewUser newUser = new NewUser();
            newUser.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the field properly", "Error in validation",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
                string email=textBox1.Text;
                string password=textBox2.Text;
                Console.WriteLine(email+" "+password);
                SqlConnection connection = new SqlConnection(CS);
                try
                {
                    Console.WriteLine("---1--");
                    SqlCommand cmd = new SqlCommand("spGetPersonID", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlParameter outputParameter=new SqlParameter();
                    outputParameter.ParameterName = "@PersonID";
                    outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outputParameter.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(outputParameter.Value.ToString());
                    string setValue = outputParameter.Value.ToString();
                    
                    if (setValue == "")
                    {
                        MessageBox.Show("Invalid Email or Password", "Invalid",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Console.WriteLine(setValue + "---");
                        ConsolePage consoleInital = new ConsolePage(setValue);
                        consoleInital.Show();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.Show();
        }
    }
}