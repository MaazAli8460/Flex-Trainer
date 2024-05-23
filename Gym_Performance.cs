using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Gym_Performance : Form
    {
        private string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";

        public Gym_Performance()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.panel2.BackColor = Color.FromArgb(150, Color.Lavender);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            label3.Font = customFont;

            // Add button column
            /*DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Text = "REPORT";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;*/
        }

        private void Gym_Performance_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            string query = @"
                SELECT g.GymID, g.Name AS GymName, g.Location, g.OwnerID,
                       p.MembershipGrowth, p.FinancialPerformance, p.ClassAttendanceRates, p.CustomerSatisfaction
                FROM Gyms g
                LEFT JOIN GymPerformance p ON g.GymID = p.GYM_ID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

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
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                int gymID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GymID"].Value);
                string gymName = dataGridView1.Rows[e.RowIndex].Cells["GymName"].Value.ToString();

                string report = GetGymPerformanceReport(gymID, gymName);

                MessageBox.Show(report, "Gym Performance Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetGymPerformanceReport(int gymID, string gymName)
        {
            string report = "";

            string query = "SELECT * FROM GymPerformance WHERE GYM_ID = @GymID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GymID", gymID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        report = $"Gym Performance Report for {gymName}\n\n" +
                                 $"Membership Growth: {reader["MembershipGrowth"]}\n" +
                                 $"Financial Performance: {reader["FinancialPerformance"]}\n" +
                                 $"Class Attendance Rates: {reader["ClassAttendanceRates"]}\n" +
                                 $"Customer Satisfaction: {reader["CustomerSatisfaction"]}";
                    }
                    else
                    {
                        report = "No performance data available for this gym.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return report;
        }
    }
}
