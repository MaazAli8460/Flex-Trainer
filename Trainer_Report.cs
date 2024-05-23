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
    public partial class Trainer_Report : Form
    {
        private string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";

        public Trainer_Report()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.panel1.BackColor = Color.FromArgb(150, Color.Turquoise);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            label1.Font = customFont;
            LoadTrainerReport();
        }

        private void Trainer_Report_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Report" button column
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                ShowUserDetails(e.RowIndex);
            }
        }

        private void LoadTrainerReport()
        {
            dataGridView1.Rows.Clear();
            string query = @"
                SELECT 
                    U.FName + ' ' + U.LName AS Name, 
                    'Result' AS REPORT
                FROM USERS U
                WHERE U.Type = 'trainer'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        dataGridView1.Rows.Add(name, "REPORT");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ShowUserDetails(int rowIndex)
        {
            // Get the name of the user from the DataGridView
            string name = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            // Fetch user details based on the name and display in a message box
            string userDetails = GetUserDetails(name);
            MessageBox.Show(userDetails, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetUserDetails(string name)
        {
            string query = @"
                SELECT 
                    U.FName, U.LName, U.Gender, U.Address, U.Phone_No,
                    G.Name AS GymName, UG.JoiningDate,
                    BS.MemberID AS MemberID
                FROM USERS U
                LEFT JOIN USER_GYM UG ON U.UserID = UG.UserID
                LEFT JOIN Gyms G ON UG.GymID = G.GymID
                LEFT JOIN BookingSessions BS ON U.UserID = BS.TrainerID
                WHERE U.FName + ' ' + U.LName = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string userDetails = $"Name: {reader["FName"]} {reader["LName"]}\n" +
                                              $"Gender: {reader["Gender"]}\n" +
                                              $"Address: {reader["Address"]}\n" +
                                              $"Phone Number: {reader["Phone_No"]}\n" +
                                              $"Gym Name: {reader["GymName"]}\n" +
                                              $"Joining Date: {reader["JoiningDate"]}\n" +
                                              $"Clients ID's: {reader["MemberID"]}";

                        return userDetails;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return "No data found for the selected user.";
        }
    }
}
