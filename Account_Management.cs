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
    public partial class Account_Management : Form
    {
        private string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
        public Account_Management()
        {
            InitializeComponent();
            CustomizeAppearance();
            PopulateDataGridView();
        }

        private void CustomizeAppearance()
        {
            panel1.BackColor = Color.FromArgb(150, Color.Turquoise);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            label1.Font = customFont;
            privateFonts.Dispose();
            customFont.Dispose();
        }

        private void Account_Management_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT FName + ' ' + LName AS FullName FROM Users WHERE Type IN ('member', 'trainer')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string fullName = reader.GetString(0);
                        dataGridView1.Rows.Add(fullName, "Delete");
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
            // Check if the clicked cell is in the "Delete" button column
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                DeleteUser(e.RowIndex);
            }
        }

        private void DeleteUser(int rowIndex)
        {
            string query = @"
                BEGIN TRANSACTION;
                DELETE FROM DietPlan WHERE User_ID IN (SELECT UserID FROM Users WHERE FName + ' ' + LName = @FullName);
                DELETE FROM Workouts WHERE User_ID IN (SELECT UserID FROM Users WHERE FName + ' ' + LName = @FullName);
                DELETE FROM Feedback WHERE BookingID IN (SELECT BookingID FROM BookingSessions WHERE MemberID IN (SELECT UserID FROM Users WHERE FName + ' ' + LName = @FullName));
                DELETE FROM BookingSessions WHERE MemberID IN (SELECT UserID FROM Users WHERE FName + ' ' + LName = @FullName);
                DELETE FROM USER_GYM WHERE UserID IN (SELECT UserID FROM Users WHERE FName + ' ' + LName = @FullName);
                DELETE FROM USERS WHERE FName + ' ' + LName = @FullName;
                COMMIT TRANSACTION;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        PopulateDataGridView(); // Refresh the grid after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.");
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
