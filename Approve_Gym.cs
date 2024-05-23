using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Approve_Gym : Form
    {
        private string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";

        public Approve_Gym()
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

        private void Approve_Gym_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT Name, Location FROM GymRequests";

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
                        dataGridView1.Rows.Add(gymName, location, "Accept");
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
            // Check if the clicked cell is in the "Accept" button column
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                AcceptGym(e.RowIndex);
            }
        }

        private void AcceptGym(int rowIndex)
        {
            // Execute the approval query for the gym
            string query = @"
                BEGIN TRANSACTION;
                DECLARE @MaxGymID INT;
                SELECT @MaxGymID = ISNULL(MAX(GymID), 0) FROM Gyms;
                SET @MaxGymID = @MaxGymID + 1;
                DECLARE @GymNameInput NVARCHAR(100) = @GymNameInputParam;
                DECLARE @LocationInput NVARCHAR(100) = @LocationInputParam;
                INSERT INTO Gyms (GymID, Name, Location, OwnerID)
                VALUES (@MaxGymID, @GymNameInputParam, @LocationInputParam, 1);
                DELETE FROM GymRequests WHERE Name = @GymNameInputParam AND Location = @LocationInputParam;
                COMMIT TRANSACTION;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GymNameInputParam", dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    command.Parameters.AddWithValue("@LocationInputParam", dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Gym approved successfully.");
                    PopulateDataGridView(); // Refresh the grid after approval
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
