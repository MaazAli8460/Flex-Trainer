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
    public partial class Form_Accessdiet : Form
    {
        public Form_Accessdiet()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();

            privateFonts.AddFontFile("Deep_Hero.ttf");

            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            panel1.BackColor = Color.FromArgb(150, Color.HotPink);
            //dataGridView1.BackgroundColor= Color.FromArgb(150, Color.HotPink); ;
            label1.Font = customFont;
            //Size size=this.panel1.Size;
            //int Width= size.Width;
            //Width /= 2;
            //label1.Location = new Point(Width, 10);
            privateFonts.Dispose();
            customFont.Dispose();
            LoadDietPlans();


        }

        private void Form_Accessdiet_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }



        private void LoadDietPlans()
        {
            dataGridView1.Rows.Clear();
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT PlanID, Plan_Name FROM DietPlan";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int planID;
                        if (!reader.IsDBNull(0) && int.TryParse(reader.GetValue(0).ToString(), out planID))
                        {
                            string planName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            dataGridView1.Rows.Add(planID, planName, "Report");
                        }
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
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                int planID;
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out planID))
                {
                    string planName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string report = GetMealReport(planID);
                    MessageBox.Show(report, $"Meals for {planName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string GetMealReport(int planID)
        {
            string report = "";
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
        SELECT m1.MealName AS Breakfast, m2.MealName AS Lunch, m3.MealName AS Dinner
        FROM DietPlan d
        LEFT JOIN Meals m1 ON d.Breakfast = m1.MealID
        LEFT JOIN Meals m2 ON d.Lunch = m2.MealID
        LEFT JOIN Meals m3 ON d.Dinner = m3.MealID
        WHERE d.PlanID = @PlanID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlanID", planID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string breakfast = reader.IsDBNull(0) ? "No meal added" : reader.GetString(0);
                        string lunch = reader.IsDBNull(1) ? "No meal added" : reader.GetString(1);
                        string dinner = reader.IsDBNull(2) ? "No meal added" : reader.GetString(2);
                        report = $"Breakfast: {breakfast}\n\nLunch: {lunch}\n\nDinner: {dinner}";
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

