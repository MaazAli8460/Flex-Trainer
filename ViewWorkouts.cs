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
    public partial class ViewWorkouts : Form
    {
        public ViewWorkouts()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();

            this.panel1.BackColor = Color.FromArgb(150, Color.MediumOrchid);
            privateFonts.AddFontFile("Deep_Hero.ttf");

            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);

            label1.Font = customFont;
            LoadWorkouts();
        }

        private void ViewWorkouts_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private void Form_Access_Workout_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadWorkouts()
        {
            dataGridView1.Rows.Clear();
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT WorkoutID, Workout_Name FROM Workouts";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int workoutID;
                        if (!reader.IsDBNull(0) && int.TryParse(reader.GetValue(0).ToString(), out workoutID))
                        {
                            string workoutName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            dataGridView1.Rows.Add(workoutID, workoutName, "Report");
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
                int workoutID;
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out workoutID))
                {
                    string workoutName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string report = GetExerciseReport(workoutID);
                    MessageBox.Show(report, $"Exercises for {workoutName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string GetExerciseReport(int workoutID)
        {
            string report = "";
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = "SELECT ExerciseName FROM Exercise WHERE ExerciseID IN (SELECT Exercise_1 FROM Workouts WHERE WorkoutID = @WorkoutID) " +
                           "UNION SELECT ExerciseName FROM Exercise WHERE ExerciseID IN (SELECT Exercise_2 FROM Workouts WHERE WorkoutID = @WorkoutID) " +
                           "UNION SELECT ExerciseName FROM Exercise WHERE ExerciseID IN (SELECT Exercise_3 FROM Workouts WHERE WorkoutID = @WorkoutID)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@WorkoutID", workoutID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string exerciseName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        report += $"{exerciseName}\n";
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
