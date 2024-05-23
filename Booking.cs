using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Booking : Form
    {
        private string username;
        private int userID;
        public Booking(string username, int userID)
        {
            InitializeComponent();
            //panel1.BackColor = Color.FromArgb(150, Color.HotPink);
            panel2.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            panel3.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            Boot_Loder();
            this.username = username;
            this.userID = userID;
        }
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        

        
        private void Boot_Loder()
        {
            privateFonts.AddFontFile("Deep_Hero.ttf");

            privateFonts1.AddFontFile("Hard_Race.otf");

            privateFonts2.AddFontFile("Stonersport-Regular.ttf");

            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            Font customFont1 = new Font(privateFonts1.Families[0], 60, FontStyle.Regular);
            Font customFont3 = new Font(privateFonts1.Families[0], 10, FontStyle.Regular);

            //label1.Font = customFont;
            //label1.Height = 20;
            label6.Font = customFont;
            //label2.Font = customFont3;
            //label3.Font = customFont3;
            label4.Font = customFont;
            //label5.Font = customFont3;


            //Size formSize = this.panel1.Size;
            //int width = formSize.Width;
            //int height = formSize.Height;

            //width /= 2;
            //width -= 50;
            //label1.Location = new Point(2, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            PopulateDataGridView();
            PopulateDataGridView2();

        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        SELECT bs.BookingID, bs.Time, f.Review, f.Rating
        FROM BookingSessions bs
        LEFT JOIN Feedback f ON bs.BookingID = f.BookingID
        WHERE bs.MemberID = @UserID AND bs.Status = 'complete'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Add button column
                   /* DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "";
                    buttonColumn.Text = "View Feedback";
                    buttonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(buttonColumn);*/

                    // Set the DataSource of the DataGridView
                    dataGridView1.DataSource = table;

                    // Resize the columns to fit the content
                    dataGridView1.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "View Feedback" column
            if (e.ColumnIndex == dataGridView1.Columns[""].Index && e.RowIndex >= 0)
            {
                // Get the BookingID from the corresponding row
                int bookingID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value);

                // Fetch and display feedback for the selected booking
                string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
                string query = @"
            SELECT f.Review, f.Rating
            FROM Feedback f
            WHERE f.BookingID = @BookingID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@BookingID", bookingID);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string review = reader["Review"].ToString();
                            string rating = reader["Rating"].ToString();
                            MessageBox.Show($"Review: {review}\nRating: {rating}");
                        }
                        else
                        {
                            MessageBox.Show("No feedback available.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void PopulateDataGridView2()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        SELECT bs.BookingID, bs.Time
        FROM BookingSessions bs
        WHERE bs.TrainerID = @TrainerID AND bs.Status = 'pending'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TrainerID", userID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Add ComboBox column
                    DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                    comboBoxColumn.HeaderText = "Action";
                    comboBoxColumn.Items.AddRange("Accept", "Reject");
                    dataGridView2.Columns.Add(comboBoxColumn);

                    // Set the DataSource of the DataGridView
                    dataGridView2.DataSource = table;

                    // Resize the columns to fit the content
                    dataGridView2.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Action" column
            if (e.ColumnIndex == dataGridView2.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // Get the selected action
                string action = dataGridView2.Rows[e.RowIndex].Cells["Action"].Value.ToString();

                // Get the BookingID from the corresponding row
                int bookingID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["BookingID"].Value);

                if (action == "Accept")
                {
                    // Update the appointment status to "complete"
                    UpdateAppointmentStatus(bookingID, "complete");
                }
                else if (action == "Reject")
                {
                    // Update the appointment status to "disapprove"
                    UpdateAppointmentStatus(bookingID, "disapprove");
                }
            }
        }

        private void UpdateAppointmentStatus(int bookingID, string status)
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        UPDATE BookingSessions
        SET Status = @Status
        WHERE BookingID = @BookingID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment status updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment status.");
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
