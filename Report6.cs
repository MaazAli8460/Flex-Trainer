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
    public partial class report6 : Form
    {
        public report6()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // No transparency issues
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport6(); // Function to load data into DataGridView
        }

        private void report6_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport6()
        {
            dataGridView2.Rows.Clear(); // Assuming dataGridView2 is used; replace with your actual DataGridView name
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT
                    DP.PlanID,
                    DP.Plan_Name
                FROM
                    DietPlan DP
                JOIN
                    Meals MB ON DP.Breakfast = MB.MealID
                JOIN
                    Meals ML ON DP.Lunch = ML.MealID
                JOIN
                    Meals MD ON DP.Dinner = MD.MealID
                WHERE
                    (MB.Carbohydrates + ML.Carbohydrates + MD.Carbohydrates) < 100;";

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
                        string planName = reader.IsDBNull(1) ? "" : reader.GetString(1);

                        dataGridView2.Rows.Add(planID, planName);
                    }
                    reader.Close();
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
    }
}
