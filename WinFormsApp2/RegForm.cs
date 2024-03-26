using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class RegForm : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;

        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True; TrustServerCertificate=True;"))
            {

                // Checking if passwords match
                if (!string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(textBox1.Text))
                {
                    if (password.Text == textBox1.Text)
                    {
                        // Checking if the username already exists
                        using (cmd = new SqlCommand("SELECT username FROM LogInInfo WHERE username=@username", cn))
                        {
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cn.Open();
                            using (dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    dr.Close();

                                    // Inserting user information into the database
                                    using (cmd = new SqlCommand("INSERT INTO LogInInfo (username, password) VALUES (@username, @password) ", cn))
                                    {
                                        cmd.Parameters.AddWithValue("@username", username.Text);
                                        cmd.Parameters.AddWithValue("@password", password.Text);


                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Hide();
                                        LogInForm login = new LogInForm();
                                        login.Show();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both passwords the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
        }
    }
}
