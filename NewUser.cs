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
using System.Collections;
using System.Configuration;

namespace Task3_LoginPage
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        private void NewUser_Load(object sender, EventArgs e)
        {
            
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            phone.Text = "";
            email.Text = "";
            password.Text = "";
            gender.Text = "";
            age.Text = "";
            city.Text = "";
            state.Text = "";
            country.Text = "";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fname.Text==""|| lname.Text == "" || phone.Text == "" || email.Text == "" || password.Text == "" ||
                gender.Text == "" || age.Text == "" || city.Text == "" || state.Text == "" || country.Text == "")
            {
                MessageBox.Show("Please fill all the field properly", "Error in validation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
                SqlConnection connection = new SqlConnection(CS);
                bool pipe = false;
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(PersonID) FROM PERSON WHERE Email='"+ email.Text+"'", connection);
                    connection.Open();
                    object rtn= cmd.ExecuteScalar();
                    Console.WriteLine(rtn);
                    Console.WriteLine("hello ----moto");
                    int count = Convert.ToInt32(rtn);
                    if (count == 0)
                    {
                        pipe = true;

                    }
                    else
                    {
                        MessageBox.Show("Email already in use", "Error in validation",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connection.Close();
                }
                if(pipe==true)
                {
                    try
                    {
                        long phoneCV = Convert.ToInt64(phone.Text);
                        int ageCV = Convert.ToInt32(age.Text);
                        SqlCommand cmd = new SqlCommand("spInsertPerson", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                        cmd.Parameters.AddWithValue("@LastName", lname.Text);
                        cmd.Parameters.AddWithValue("@AgeYears", ageCV);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneCV);
                        cmd.Parameters.AddWithValue("@Country", country.Text);
                        cmd.Parameters.AddWithValue("@State", state.Text);
                        cmd.Parameters.AddWithValue("@City", city.Text);
                        cmd.Parameters.AddWithValue("@Password", password.Text);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        this.Close();
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
        }
    }
}
