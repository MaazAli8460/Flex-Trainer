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
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = ControlPaint.Light(Color.MediumOrchid);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport1(); // This function loads the report data into DataGridView2
        }

        private void report1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport1()
        {
            dataGridView2.Rows.Clear(); // Using dataGridView2 as specified
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
            SELECT 
                U.UserID,
                U.FName,
                U.LName,
                U.Gender,
                U.Address,
                U.Phone_No,
                U.Username
            FROM 
                USERS U
            JOIN 
                USER_GYM UG ON U.UserID = UG.UserID
            JOIN 
                BookingSessions BS ON U.UserID = BS.MemberID
            WHERE 
                UG.GymID = 18
                AND BS.TrainerID = 23;";

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

                        dataGridView2.Rows.Add(userID, fName, lName, gender, address, phoneNo, username);
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
