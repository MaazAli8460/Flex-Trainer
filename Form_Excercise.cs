using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class Form_Excercise : Form
    {
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        public Form_Excercise()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.HotPink);
            this.Resize += Form_resize;
            Boot_Loder();
        }

        private void Form_Excercise_Load(object sender, EventArgs e)
        {

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
            label6.Font = customFont3;
            label2.Font = customFont3;
            label3.Font = customFont3;
            label4.Font = customFont3;
            label5.Font = customFont3;
            //linkLabel1.Font = customFont3;




            //Size formSize = this.panel1.Size;
            //int width = formSize.Width;
            //int height = formSize.Height;

            //width /= 2;
            //width -= 50;
            //label1.Location = new Point(2, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

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
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string exerciseName = textBox1.Text;
            int sets = Convert.ToInt32(textBox3.Text);
            int reps = Convert.ToInt32(textBox4.Text);
            string goal = textBox2.Text;
            string type = textBox5.Text;

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get the max exercise ID
                    int maxExerciseID = 0;
                    SqlCommand getMaxExerciseIDCommand = new SqlCommand("SELECT ISNULL(MAX(ExerciseID), 0) FROM Exercise", connection);
                    object maxExerciseIDResult = getMaxExerciseIDCommand.ExecuteScalar();
                    if (maxExerciseIDResult != DBNull.Value)
                    {
                        maxExerciseID = Convert.ToInt32(maxExerciseIDResult);
                    }

                    // Calculate new exercise ID
                    int newExerciseID = maxExerciseID + 1;

                    // Insert new exercise into database
                    SqlCommand insertExerciseCommand = new SqlCommand(@"
                        INSERT INTO Exercise (ExerciseID, ExerciseName, Sets, Reps, Goal, Type)
                        VALUES (@NewExerciseID, @ExerciseName, @Sets, @Reps, @Goal, @Type)", connection);

                    insertExerciseCommand.Parameters.AddWithValue("@NewExerciseID", newExerciseID);
                    insertExerciseCommand.Parameters.AddWithValue("@ExerciseName", exerciseName);
                    insertExerciseCommand.Parameters.AddWithValue("@Sets", sets);
                    insertExerciseCommand.Parameters.AddWithValue("@Reps", reps);
                    insertExerciseCommand.Parameters.AddWithValue("@Goal", goal);
                    insertExerciseCommand.Parameters.AddWithValue("@Type", type);

                    int rowsAffected = insertExerciseCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        MessageBox.Show("Exercise added successfully.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add exercise.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
