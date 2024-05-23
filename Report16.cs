using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report16 : Form
    {
        public report16()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData(); // Load data from the database
        }

        private void InitializeDataGridView()
        {
            // Assuming dataGridView1 is already added to the form in the designer.
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("BookingID", "Booking ID");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Duration", "Duration");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("TrainerFirstName", "Trainer First Name");
            dataGridView1.Columns.Add("TrainerLastName", "Trainer Last Name");
            dataGridView1.Columns.Add("MemberFirstName", "Member First Name");
            dataGridView1.Columns.Add("MemberLastName", "Member Last Name");
            dataGridView1.Columns.Add("Rating", "Feedback Rating");

            // Setting DataGridView properties for usability and appearance
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;  // Prevents users from adding rows directly
        }

        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT bs.BookingID, bs.Date, bs.Time, bs.Duration, bs.Price, bs.Status,
                       t.FName AS TrainerFirstName, t.LName AS TrainerLastName,
                       m.FName AS MemberFirstName, m.LName AS MemberLastName,
                       f.Rating
                FROM BookingSessions bs
                JOIN USERS t ON bs.TrainerID = t.UserID
                JOIN USERS m ON bs.MemberID = m.UserID
                LEFT JOIN Feedback f ON bs.BookingID = f.BookingID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int bookingID = (int)reader.GetByte(0);
                        DateTime date;
                        if (!reader.IsDBNull(2))
                        {
                            try
                            {
                                date = reader.GetDateTime(2);
                            }
                            catch (InvalidCastException)
                            {
                                Console.WriteLine("Invalid cast for DateTime encountered.");
                                date = DateTime.MinValue; // Set to MinValue or handle appropriately
                            }
                        }
                        else
                        {
                            date = DateTime.MinValue;
                        }
                        TimeSpan time = reader.GetTimeSpan(2);
                        int duration = (int)reader.GetByte(3);
                        int price = (int)reader.GetInt16(4);
                        string status = reader.GetString(5);
                        string trainerFirstName = reader.GetString(6);
                        string trainerLastName = reader.GetString(7);
                        string memberFirstName = reader.GetString(8);
                        string memberLastName = reader.GetString(9);
                        double rating = reader.GetDouble(10);

                        dataGridView1.Rows.Add(bookingID, date, time, duration, price, status,
                                               trainerFirstName, trainerLastName,
                                               memberFirstName, memberLastName, rating);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
