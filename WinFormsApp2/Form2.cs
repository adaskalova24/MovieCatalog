using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string insertQuery = "INSERT INTO WatchedMovies (MovieName, WatchDate, Rating, Comments) VALUES (@MovieName, @WatchDate, @Rating, @Comments)";

                string movieExistsQuery = "SELECT movieName FROM MoviesTable WHERE movieName = @MovieName";

                using (SqlCommand insertcmd = new SqlCommand(insertQuery, sqlCon))
                using (SqlCommand movieExistsCmd = new SqlCommand(movieExistsQuery, sqlCon))
                {
                    insertcmd.Parameters.AddWithValue("@MovieName", movieName.Text);
                    insertcmd.Parameters.AddWithValue("@WatchDate", date.Text);
                    insertcmd.Parameters.AddWithValue("@Rating", rating.Text);
                    insertcmd.Parameters.AddWithValue("@Comments", comments.Text);
                    sqlCon.Close();


                    try
                    {
                        sqlCon.Open();
                        movieExistsCmd.Parameters.AddWithValue("@MovieName", movieName.Text);
                        object result = movieExistsCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int rowsAffected = insertcmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your movie review has been successfully submitted!");

                            }
                            else
                            {
                                MessageBox.Show("Failed to save your movie review.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to save your movie review.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving your movie review: " + ex.Message);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reviews review = new Reviews();
            review.Show();
        }
    }
}