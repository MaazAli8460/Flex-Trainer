using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report20 : Form
    {
        public report20()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT dp.PlanID, dp.Plan_Name, m.MealName
                FROM DietPlan dp
                JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
                WHERE m.Allergens <> 'Wheat';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int planID = (int)reader.GetByte(0);
                        string planName = reader.GetString(1);
                        string mealName = reader.GetString(2);

                        dataGridView1.Rows.Add(planID, planName, mealName);
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
