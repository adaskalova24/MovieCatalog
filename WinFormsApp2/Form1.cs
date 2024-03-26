using System;  // Importing the System namespace
using System.Collections.Generic;  // Importing namespaces for various functionalities
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp2.authenticate;  // Importing static members from the authenticate class
using WinFormsApp2;  // Importing the entire WinFormsDemo namespace
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private User authenticatedUser;
        public Form1(User user)
        {
            InitializeComponent();
        }

        // Event handler for when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default values for ComboBoxes when the form is loaded
            movieType.SelectedIndex = 0;
            movieGenre.SelectedIndex = 0;
            movieSP.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM MoviesTable WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (movieSP.SelectedItem != null)
                    conditions.Add("movieSP = @movieSP");

                if (movieType.SelectedItem != null)
                    conditions.Add("movieType = @movieType");

                if (movieGenre.SelectedItem != null)
                    conditions.Add("movieGenre = @movieGenre");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                cmd.Parameters.AddWithValue("@movieSP", movieSP.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@movieType", movieType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@movieGenre", movieGenre.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            movieType.SelectedIndex = 0;
            movieGenre.SelectedIndex = 0;
            movieSP.SelectedIndex = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 userInputForm = new Form2())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }

    }
}