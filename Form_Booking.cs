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
    public partial class Form_Booking : Form
    {
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        private string username;
        private int userID;
        public Form_Booking(string username, int userID)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.HotPink);
            panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            panel3.BackColor = Color.FromArgb(150, Color.HotPink);
            this.username = username;
            this.userID = userID;
            Boot_Loder();
            PopulateDataGridView();
            PopulateDataGridView(userID);

        }

        private void Form_Booking_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void Boot_Loder()
        {
            privateFonts.AddFontFile("Deep_Hero.ttf");

            privateFonts1.AddFontFile("Hard_Race.otf");

            privateFonts2.AddFontFile("Stonersport-Regular.ttf");

            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            Font customFont1 = new Font(privateFonts1.Families[0], 60, FontStyle.Regular);
            Font customFont3 = new Font(privateFonts1.Families[0], 10, FontStyle.Regular);

            label1.Font = customFont;
            //label1.Height = 20;
            label6.Font = customFont;
            label2.Font = customFont3;
            label3.Font = customFont3;
            label4.Font = customFont;
            label5.Font = customFont3;


            Size formSize = this.panel1.Size;
            int width = formSize.Width;
            int height = formSize.Height;

            width /= 2;
            width -= 50;
            label1.Location = new Point(2, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trainerID = Convert.ToInt32(textBox1.Text);
            string date = textBox3.Text;
            string time = textBox4.Text;
            int duration = Convert.ToInt32(textBox2.Text);

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the next booking ID
                    int nextBookingID = 0;
                    SqlCommand getNextBookingIDCommand = new SqlCommand("SELECT ISNULL(MAX(BookingID), 0) + 1 FROM BookingSessions", connection);
                    object nextBookingIDResult = getNextBookingIDCommand.ExecuteScalar();
                    if (nextBookingIDResult != DBNull.Value)
                    {
                        nextBookingID = Convert.ToInt32(nextBookingIDResult);
                    }

                    // Insert new booking session into database
                    SqlCommand insertBookingCommand = new SqlCommand(@"
                INSERT INTO BookingSessions (BookingID, Date, Time, Duration, Price, Status, TrainerID, MemberID)
                VALUES (@NextBookingID, @Date, @Time, @Duration, 1500, 'pending', @TrainerID, 6)", connection);

                    insertBookingCommand.Parameters.AddWithValue("@NextBookingID", nextBookingID);
                    insertBookingCommand.Parameters.AddWithValue("@Date", date);
                    insertBookingCommand.Parameters.AddWithValue("@Time", time);
                    insertBookingCommand.Parameters.AddWithValue("@Duration", duration);
                    insertBookingCommand.Parameters.AddWithValue("@TrainerID", trainerID);

                    int rowsAffected = insertBookingCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking added successfully.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add booking.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        SELECT U.UserID AS ID, U.FName + ' ' + U.LName AS Name, UG.GymID,
            (SELECT CAST(RAND() * 1000 AS DECIMAL(10, 2))) AS Cost
        FROM Users U
        INNER JOIN User_Gym UG ON U.UserID = UG.UserID
        WHERE U.Type = 'trainer';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Set the DataSource of the DataGridView
                    dataGridView2.DataSource = table;

                    // Set the column headers
                    dataGridView2.Columns[0].HeaderText = "Trainer ID";
                    dataGridView2.Columns[1].HeaderText = "Trainer Name";
                    dataGridView2.Columns[2].HeaderText = "Gym";
                    dataGridView2.Columns[3].HeaderText = "Cost";

                    // Resize the columns to fit the content
                    dataGridView2.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void PopulateDataGridView(int userID)
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        SELECT U.FName + ' ' + U.LName AS TrainerName, BS.Time, 
               (SELECT CAST(RAND() * 1000 AS DECIMAL(10, 2))) AS Price, 'completed' AS Status
        FROM BookingSessions BS
        INNER JOIN Users U ON BS.TrainerID = U.UserID
        WHERE BS.MemberID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Set the DataSource of the DataGridView
                    dataGridView1.DataSource = table;

                    // Set the column headers
                    dataGridView1.Columns[0].HeaderText = "Trainer Name";
                    dataGridView1.Columns[1].HeaderText = "Time";
                    dataGridView1.Columns[2].HeaderText = "Price";
                    dataGridView1.Columns[3].HeaderText = "Status";

                    // Resize the columns to fit the content
                    dataGridView1.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
