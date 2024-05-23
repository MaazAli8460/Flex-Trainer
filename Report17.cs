using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report17 : Form
    {
        public report17()
        {
            InitializeComponent();
            lblTotalRevenue = new Label();
            lblTotalRevenue.AutoSize = true;  // Example property
            lblTotalRevenue.Location = new Point(10, 10);  // Example location
            lblTotalRevenue.Font = new Font("Arial", 12, FontStyle.Bold);  // Example font
            this.Controls.Add(lblTotalRevenue);  // Adding the label to the form's controls

            LoadTotalRevenue();
        }

        private void LoadTotalRevenue()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT SUM(Price) AS TotalRevenue
                FROM BookingSessions
                WHERE Status = 'complete';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalRevenue = (int)result;
                        lblTotalRevenue.Text = $"Total Revenue: {totalRevenue:C}";  // Display formatted as currency
                    }
                    else
                    {
                        lblTotalRevenue.Text = "Total Revenue: $0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void report17_Load(object sender, EventArgs e)
        {

        }
    }
}
