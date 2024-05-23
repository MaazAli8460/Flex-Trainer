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
    public partial class report7 : Form
    {
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Plan;
        private DataGridViewTextBoxColumn Plann;

        public report7()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // No transparency issues
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport7(); // Function to load data into DataGridView
        }

        private void report7_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport7()
        {
            dataGridView2.Rows.Clear(); // Assuming dataGridView2 is used; replace with your actual DataGridView name
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT DISTINCT
                    W.WorkoutID,
                    W.Workout_Name
                FROM
                    Workouts W
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM Exercise_Machine EM
                    WHERE (W.Exercise_1 = EM.ExerciseID OR
                           W.Exercise_2 = EM.ExerciseID OR
                           W.Exercise_3 = EM.ExerciseID)
                      AND EM.MachineID = 1
                );";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int workoutID = reader.IsDBNull(0) ? 0 : (int)reader.GetByte(0);
                        string workoutName = reader.IsDBNull(1) ? "" : reader.GetString(1);

                        dataGridView2.Rows.Add(workoutID, workoutName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plan,
            this.Plann});
            this.dataGridView2.Location = new System.Drawing.Point(245, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(371, 201);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Plan
            // 
            this.Plan.HeaderText = "ID";
            this.Plan.MinimumWidth = 6;
            this.Plan.Name = "Plan";
            this.Plan.Width = 125;
            // 
            // Plann
            // 
            this.Plann.HeaderText = "WorkoutName";
            this.Plann.MinimumWidth = 6;
            this.Plann.Name = "Plann";
            this.Plann.Width = 125;
            // 
            // report7
            // 
            this.ClientSize = new System.Drawing.Size(861, 382);
            this.Controls.Add(this.dataGridView2);
            this.Name = "report7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
