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
    public partial class report5 : Form
    {
        public report5()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // Standard color without transparency
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport5(); // Function to load data into DataGridView
        }

        private void report5_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport5()
        {
            dataGridView1.Rows.Clear(); // Ensure dataGridView2 is set up properly in the form
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT
                    DP.PlanID,
                    DP.Plan_Name
                FROM
                    DietPlan DP
                JOIN
                    Meals M ON DP.Breakfast = M.MealID
                WHERE
                    M.Proteins < 40;";

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

                        dataGridView1.Rows.Add(planID, planName);
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
