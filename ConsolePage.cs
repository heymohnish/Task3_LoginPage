using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Task3_LoginPage
{
    public partial class ConsolePage : Form
    {
        public string personId { get; set; }
        public ConsolePage(string setValue)
        {
            InitializeComponent();
            personId = setValue;
        }

       

        private void ConsolePage_Load(object sender, EventArgs e)
        {
            Console.WriteLine(personId);
            textBox3.Text = personId;
            setAllValues(textBox3.Text);
        }

        private void setAllValues(string text)
        {
            int setValueId=Convert.ToInt32(text);
            Console.WriteLine("into set");
            string CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
            SqlConnection connection = new SqlConnection(CS);
            try
            {
                SqlCommand cmd = new SqlCommand("spGetByID", connection);
                DataTable dt = new DataTable();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", setValueId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Print the values of each field
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetName(i).Equals("FirstName"))
                            {
                                fname.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("LastName"))
                            {
                                lname.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("AgeYears"))
                            {
                                age.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("Gender"))
                            {
                                gender.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("CreatedDate"))
                            {
                                textBox2.Text= reader.GetValue(i).ToString();

                            }
                            if (reader.GetName(i).Equals("Email"))
                            {
                                email.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("Phone"))
                            {
                                phone.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("Country"))
                            {
                                country.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("State"))
                            {
                                state.Text  = reader.GetValue(i).ToString(); 
                            }
                            if (reader.GetName(i).Equals("City"))
                            {
                                city.Text   = reader.GetValue(i).ToString(); 
                            }
                            if (reader.GetName(i).Equals("UpdatedDate"))
                            {
                                textBox1.Text= reader.GetValue(i).ToString();
                            }
                            if (reader.GetName(i).Equals("Password"))
                            {
                                password.Text= reader.GetValue(i).ToString();
                            }
                        }
                    }
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
            Console.WriteLine("out set");
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fi_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete your profile", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(personId);
                string CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
                SqlConnection connection = new SqlConnection(CS);
                try
                {
                    SqlCommand cmd = new SqlCommand("spDeleteByID", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", id);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fname.Text == "" || lname.Text == "" || phone.Text == "" || password.Text == "" ||
               gender.Text == "" || age.Text == "" || city.Text == "" || state.Text == "" || country.Text == "")
            {
                MessageBox.Show("Please fill all the field properly", "Error in validation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to update your profile", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(personId);
                    string CS = System.Configuration.ConfigurationManager.ConnectionStrings["DBSC"].ConnectionString;
                    SqlConnection connection = new SqlConnection(CS);
                    try
                    {
                        int ageCV = Convert.ToInt32(age.Text);
                        long phoneCV = Convert.ToInt64(phone.Text);
                        SqlCommand cmd = new SqlCommand("spUpdatePerson", connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                        cmd.Parameters.AddWithValue("@LastName", lname.Text);
                        cmd.Parameters.AddWithValue("@AgeYears", ageCV);
                        cmd.Parameters.AddWithValue("@Gender", gender.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneCV);
                        cmd.Parameters.AddWithValue("@Country", country.Text);
                        cmd.Parameters.AddWithValue("@State", state.Text);
                        cmd.Parameters.AddWithValue("@City", city.Text);
                        cmd.Parameters.AddWithValue("@Password", password.Text);
                        cmd.Parameters.AddWithValue("@PersonID", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("=============sos");
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
