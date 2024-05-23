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
    public partial class report11 : Form
    {
        public report11()
        {
            InitializeComponent();
            LoadData(); // Load data from database
        }

        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT dp.PlanID, dp.Plan_Name, m.MealName
                FROM DietPlan dp
                JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
                WHERE m.Allergens = 'Eggs';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int planID = reader.IsDBNull(0) ? 0 : (int)reader.GetByte(0);
                        string planName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        string mealName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                        dataGridView1.Rows.Add(planID, planName, mealName);
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

        }
    }
}
