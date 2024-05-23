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
    public partial class report8 : Form
    {
        public report8()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // No transparency issues
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport8(); // Function to load data into DataGridView
        }

        private void report8_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport8()
        {
            dataGridView2.Rows.Clear(); // Assuming dataGridView2 is used; replace with your actual DataGridView name
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT DISTINCT
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
                    MB.allergens NOT LIKE '%Peanuts%'
                    AND ML.allergens NOT LIKE '%Peanuts%'
                    AND MD.allergens NOT LIKE '%Peanuts%';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int planID = reader.IsDBNull(0) ? 0 : (int)reader.GetByte(0); // GetByte and cast to int
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

        private void report8_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
