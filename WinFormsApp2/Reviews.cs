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

namespace WinFormsApp2
{
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC04\SQLEXPRESS; Initial Catalog=MovieCatalog; Integrated Security=True; TrustServerCertificate=True;"))
            {
                string query = "SELECT * FROM WatchedMovies";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Check if the DataSet contains any tables
                    if (ds.Tables.Count > 0)
                    {
                        // Set the DataSource of the DataGridView to the DataTable in the DataSet
                        NotesList.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // If no data found, set DataSource to null
                        NotesList.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving reviews: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show(); // Show the form
        }
    }
}
