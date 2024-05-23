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


    public partial class CreateWorkout : Form
    {
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        Form_Excercise Form_Excercise = new Form_Excercise();
        public CreateWorkout()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            this.Resize += Form_resize;
            Boot_Loder();
            PopulateExerciseGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form_Excercise == null)
            {
                Form_Excercise = new Form_Excercise();
            }
            Form_Excercise.Show();
        }
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
            //label1.Height = 20;
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
            label1.Location = new Point(2, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adds workout
        }

        private void CreateWorkout_Load(object sender, EventArgs e)
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
            string workoutName = textBox1.Text;
            int userID = Convert.ToInt32(textBox2.Text);
            int exercise1 = Convert.ToInt32(textBox3.Text);
            int exercise2 = Convert.ToInt32(textBox4.Text);
            int exercise3 = Convert.ToInt32(textBox5.Text);

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the max workout ID
                    int maxWorkoutID = 0;
                    SqlCommand getMaxWorkoutIDCommand = new SqlCommand("SELECT ISNULL(MAX(WorkoutID), 0) FROM Workouts", connection);
                    object maxWorkoutIDResult = getMaxWorkoutIDCommand.ExecuteScalar();
                    if (maxWorkoutIDResult != DBNull.Value)
                    {
                        maxWorkoutID = Convert.ToInt32(maxWorkoutIDResult);
                    }

                    // Calculate new workout ID
                    int newWorkoutID = maxWorkoutID + 1;

                    // Insert new workout into database
                    SqlCommand insertWorkoutCommand = new SqlCommand(@"
                        INSERT INTO Workouts (WorkoutID, Workout_Name, User_ID, Exercise_1, Exercise_2, Exercise_3)
                        VALUES (@NewWorkoutID, @WorkoutName, @UserID, @Exercise1, @Exercise2, @Exercise3)", connection);

                    insertWorkoutCommand.Parameters.AddWithValue("@NewWorkoutID", newWorkoutID);
                    insertWorkoutCommand.Parameters.AddWithValue("@WorkoutName", workoutName);
                    insertWorkoutCommand.Parameters.AddWithValue("@UserID", userID);
                    insertWorkoutCommand.Parameters.AddWithValue("@Exercise1", exercise1);
                    insertWorkoutCommand.Parameters.AddWithValue("@Exercise2", exercise2);
                    insertWorkoutCommand.Parameters.AddWithValue("@Exercise3", exercise3);

                    int rowsAffected = insertWorkoutCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Workout added successfully.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add workout.");
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

        private void PopulateExerciseGrid()
        {
            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT ExerciseID, ExerciseName FROM Exercise";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable exercisesTable = new DataTable();
                    adapter.Fill(exercisesTable);
                    dataGridView1.DataSource = exercisesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Add DataGridViewButtonColumn
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Report";
            buttonColumn.Name = "btnReport";
            buttonColumn.Text = "View Report";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            // Set DataGridView properties
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnReport"].Index && e.RowIndex >= 0)
            {
                // Retrieve reps, sets, and goal of the exercise
                int exerciseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ExerciseID"].Value);
                string exerciseName = dataGridView1.Rows[e.RowIndex].Cells["ExerciseName"].Value.ToString();
                string report = GetExerciseReport(exerciseID, exerciseName);

                // Display the message box with exercise report
                MessageBox.Show(report, "Exercise Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetExerciseReport(int exerciseID, string exerciseName)
        {
            // Retrieve reps, sets, and goal of the exercise from the database
            string report = "";
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT Reps, Sets, Goal FROM Exercise WHERE ExerciseID = @ExerciseID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ExerciseID", exerciseID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int reps = Convert.ToInt32(reader["Reps"]);
                        int sets = Convert.ToInt32(reader["Sets"]);
                        string goal = reader["Goal"].ToString();
                        report = $"Exercise: {exerciseName}\nReps: {reps}\nSets: {sets}\nGoal: {goal}";
                    }
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
