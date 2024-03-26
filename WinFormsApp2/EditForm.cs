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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class EditForm : Form
    {
        private string connectionString = @"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True; TrustServerCertificate=True;";

        public EditForm()
        {
            InitializeComponent();
        }

        public string MovieTitle { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Get the note title from the TextBox
            MovieTitle = textBox1.Text;

            // Construct the SQL DELETE statement
            string query = "DELETE FROM WatchedMovies WHERE MovieName = @Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", MovieTitle);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Movie Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Close Form2 with OK result
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Movie Review not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}