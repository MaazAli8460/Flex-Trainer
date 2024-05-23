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
    public partial class report2 : Form
    {
        public report2()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // Assuming no transparency is required
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport2(); // This function loads the report data into DataGridView2
        }

        private void report2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport2()
        {
            dataGridView1.Rows.Clear(); // Using dataGridView2 as specified
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"SELECT 
    U.UserID,
    U.FName,
    U.LName,
    U.Gender,
    U.Address,
    U.Phone_No,
    U.Username,
    DP.PlanID,
    DP.Plan_Name,
	G.Name
FROM 
    USERS U
JOIN 
    USER_GYM UG ON U.UserID = UG.UserID
JOIN 
    DietPlan DP ON U.UserID = DP.User_ID  -- Assuming USERS table has a PlanID
JOIN
	Gyms G ON G.GymID = UG.GymID
WHERE 
    UG.GymID = 9  -- Replace [Specific_Gym_ID] with the actual GymID
    AND DP.PlanID = 16;  -- Replace [Specific_Diet_Plan_ID] with the actual Diet Plan ID"; // Simplified query using the view

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userID = reader.IsDBNull(0) ? 0 : (int)reader.GetByte(0);
                        string fName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string lName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        string gender = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        string address = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string phoneNo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        string username = reader.IsDBNull(6) ? "" : reader.GetString(6);
                        int planID = reader.IsDBNull(7) ? 0 : (int)reader.GetByte(7);
                        string planName = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        string gymName = reader.IsDBNull(9) ? "" : reader.GetString(9);

                        dataGridView1.Rows.Add(userID, fName, lName, gender, address, phoneNo, username, planID, planName, gymName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void report2_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
