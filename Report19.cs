using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report19 : Form
    {
        public report19()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT g.GymID, g.Name, g.Location, gp.CustomerSatisfaction
                FROM Gyms g
                JOIN GymPerformance gp ON g.GymID = gp.GYM_ID
                WHERE gp.CustomerSatisfaction = (SELECT MAX(CustomerSatisfaction) FROM GymPerformance);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int gymID = (int)reader.GetByte(0);
                        string name = reader.GetString(1);
                        string location = reader.GetString(2);
                        int customerSatisfaction = (int)reader.GetByte(3);

                        dataGridView1.Rows.Add(gymID, name, location, customerSatisfaction);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void report19_Load(object sender, EventArgs e)
        {

        }
    }
}
