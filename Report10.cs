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
    public partial class report10 : Form
    {
        public report10()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid;
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport10(); // Function to load data into DataGridView
        }

        private void report10_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport10()
        {
            dataGridView1.Rows.Clear(); // Ensure dataGridView2 is set up properly in the form
            string connectionString = @"Data Source=HUZAIFA\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT
                    G.GymID,
                    G.Name AS GymName,
                    COUNT(UG.UserID) AS TotalNewMembers
                FROM
                    USER_GYM UG
                JOIN
                    Gyms G ON UG.GymID = G.GymID
                WHERE
                    UG.JoiningDate >= '2023-01-01 01:01:23'  -- Adjusted to filter by specific datetime
                GROUP BY
                    G.GymID, G.Name
                ORDER BY
                    TotalNewMembers DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int gymID = reader.IsDBNull(0) ? 0 : (int)reader.GetByte(0);
                        string gymName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        int totalNewMembers = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);

                        dataGridView1.Rows.Add(gymID, gymName, totalNewMembers);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void report10_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
