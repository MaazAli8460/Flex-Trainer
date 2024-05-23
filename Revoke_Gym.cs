using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flex_Trainer
{
    public partial class Revoke_Gym : Form
    {
        string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";

        public Revoke_Gym()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.panel2.BackColor = Color.FromArgb(150, Color.Lavender);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            label3.Font = customFont;
            privateFonts.Dispose();
            customFont.Dispose();
            PopulateDataGridView();
        }

        private void Revoke_Gym_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT Name, Location FROM Gyms";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string gymName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        string location = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        dataGridView1.Rows.Add(gymName, location, "Revoke");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Revoke" button column
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                RevokeGym(e.RowIndex);
            }
        }

        private void RevokeGym(int rowIndex)
        {
            string gymName = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string location = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

            string query = @"
                BEGIN TRANSACTION;
                DECLARE @GymID INT;
                SELECT @GymID = GymID FROM Gyms WHERE Name = @GymName AND Location = @Location;
                UPDATE USERS
                SET Type = 'Undefined'
                WHERE UserID IN (SELECT UserID FROM USER_GYM WHERE GymID = @GymID);
                DELETE FROM USER_GYM
                WHERE GymID = @GymID;
                DELETE FROM GymPerformance
                WHERE GYM_ID = @GymID;
                DELETE FROM Gyms
                WHERE GymID = @GymID;
                COMMIT TRANSACTION;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GymName", gymName);
                    command.Parameters.AddWithValue("@Location", location);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Gym revoked successfully.");
                        PopulateDataGridView(); // Refresh the grid after revoking
                    }
                    else
                    {
                        MessageBox.Show("Failed to revoke gym.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
