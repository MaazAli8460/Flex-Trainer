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
    public partial class CreateDiet : Form
    {
        public CreateDiet()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            //this.Resize += Form_resize;
            Boot_Loder();
            PopulateMealGrid();
        }
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        Form_Meal newMeal = new Form_Meal();
        

        
        private void Form_resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    Size formSize = this.Size;
            //    int width = formSize.Width;
            //    int height = formSize.Height;

            //    panel2.Width = width;
            //    panel2.Height = 100;
            //    //this.MaximizeBox = true;
            //}
            //else if (this.WindowState == FormWindowState.Normal)
            //{
            //    Size formSize = this.Size;
            //    int width = formSize.Width;
            //    int height = formSize.Height;

            //    panel2.Width = width;
            //    panel2.Height = 100;
            //    width /= 2;
            //    width -= 230;
            //    label3.Location = new Point(width, 5);
            //}
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
            //label1.Location = new Point(panel1.Width, 50);
            label6.Font = customFont3;
            label2.Font = customFont3;
            label3.Font = customFont3;
            label4.Font = customFont3;
            label5.Font = customFont3;
            //label6.Font = customFont1;
            //label2.Font = customFont3;
            //label3.Font = customFont3;
            //label4.Font = customFont3;
            //label5.Font = customFont3;
            //linkLabel1.Font = customFont3;




            Size formSize = this.panel1.Size;
            int width = formSize.Width;
            int height = formSize.Height;

            width /= 2;
            width -= 50;
            //label1.Location = new Point(2, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (newMeal == null)
            {
                newMeal = new Form_Meal();
            }
            newMeal.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //adds workout
        }

        private void CreateDiet_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string planName = textBox1.Text;
            int userID = Convert.ToInt32(textBox2.Text);
            string breakfast = textBox3.Text;
            string lunch = textBox4.Text;
            string dinner = textBox5.Text;

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the max plan ID
                    int maxPlanID = 0;
                    SqlCommand getMaxPlanIDCommand = new SqlCommand("SELECT ISNULL(MAX(PlanID), 0) FROM DietPlan", connection);
                    object maxPlanIDResult = getMaxPlanIDCommand.ExecuteScalar();
                    if (maxPlanIDResult != DBNull.Value)
                    {
                        maxPlanID = Convert.ToInt32(maxPlanIDResult);
                    }

                    // Calculate new plan ID
                    int newPlanID = maxPlanID + 1;

                    // Insert new plan into database
                    SqlCommand insertPlanCommand = new SqlCommand(@"
                        INSERT INTO DietPlan (PlanID, Plan_Name, User_ID, Breakfast, Lunch, Dinner)
                        VALUES (@NewPlanID, @PlanName, @UserID, @Breakfast, @Lunch, @Dinner)", connection);

                    insertPlanCommand.Parameters.AddWithValue("@NewPlanID", newPlanID);
                    insertPlanCommand.Parameters.AddWithValue("@PlanName", planName);
                    insertPlanCommand.Parameters.AddWithValue("@UserID", userID);
                    insertPlanCommand.Parameters.AddWithValue("@Breakfast", breakfast);
                    insertPlanCommand.Parameters.AddWithValue("@Lunch", lunch);
                    insertPlanCommand.Parameters.AddWithValue("@Dinner", dinner);

                    int rowsAffected = insertPlanCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Diet plan added successfully.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add diet plan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void PopulateMealGrid()
        {
            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT MealID, MealName FROM Meals";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable mealsTable = new DataTable();
                    adapter.Fill(mealsTable);
                    dataGridView1.DataSource = mealsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Add DataGridViewButtonColumn
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "View Details";
            buttonColumn.Name = "btnDetails";
            buttonColumn.Text = "View Details";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            // Set DataGridView properties
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private string GetMealDetails(int mealID, string mealName)
        {
            string details = "";
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT Carbohydrates, Fats, Proteins, PortionSize, allergens FROM Meals WHERE MealID = @MealID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MealID", mealID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string carbohydrates = reader["Carbohydrates"].ToString();
                        string fats = reader["Fats"].ToString();
                        string proteins = reader["Proteins"].ToString();
                        string portionSize = reader["PortionSize"].ToString();
                        string allergens = reader["allergens"].ToString();

                        details = $"Meal Name: {mealName}\n\n" +
                                  $"Carbohydrates: {carbohydrates} grams\n" +
                                  $"Fats: {fats} grams\n" +
                                  $"Proteins: {proteins} grams\n" +
                                  $"Portion Size: {portionSize}\n" +
                                  $"Allergens: {allergens}";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return details;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnDetails"].Index && e.RowIndex >= 0)
            {
                int mealID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MealID"].Value);
                string mealName = dataGridView1.Rows[e.RowIndex].Cells["MealName"].Value.ToString();
                string details = GetMealDetails(mealID, mealName);
                MessageBox.Show(details, "Meal Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
