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
    public partial class report3 : Form
    {
        public report3()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid; // Assuming no transparency issues
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport3(); // Function to load data into DataGridView
        }

        private void report3_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport3()
        {
            dataGridView2.Rows.Clear(); // Using dataGridView2, make sure it is set up properly in the form
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT 
                    U.UserID,
                    U.FName,
                    U.LName,
                    U.Gender,
                    U.Address,
                    U.Phone_No, 
                    U.Username,
                    DP.PlanID,
                    DP.Plan_Name
                FROM 
                    USERS U
                JOIN 
                    USER_GYM UG ON U.UserID = UG.UserID
                JOIN 
                    BookingSessions BS ON U.UserID = BS.MemberID
                JOIN 
                    DietPlan DP ON U.UserID = DP.User_ID
                WHERE 
                    BS.TrainerID = 20
                    AND DP.PlanID = 2;";

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

                        dataGridView2.Rows.Add(userID, fName, lName, gender, address, phoneNo, username, planID, planName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
