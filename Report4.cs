using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report4 : Form
    {
        public report4()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT w.WorkoutID, w.Workout_Name
                FROM Workouts w
                JOIN Exercise e ON w.Exercise_1 = e.ExerciseID OR 
                                    w.Exercise_2 = e.ExerciseID OR
                                    w.Exercise_3 = e.ExerciseID
                WHERE e.Goal = 'Weight Loss';";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int workoutID = (int)reader.GetByte(0);
                        string workoutName = reader.GetString(1);

                        dataGridView1.Rows.Add(workoutID, workoutName);
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
