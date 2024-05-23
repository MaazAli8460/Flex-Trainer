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
    public partial class report9 : Form
    {
        public report9()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.BackColor = Color.MediumOrchid;
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            //label1.Font = customFont;
            LoadReport9(); // Function to load data into DataGridView
        }

        private void report9_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void LoadReport9()
        {
            dataGridView1.Rows.Clear(); // Ensure dataGridView2 is set up properly in the form
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT
                    UG.UserID,
                    UG.GymID,
                    UG.JoiningDate,
                    G.Name AS GymName,
                    U.FName AS FirstName,
                    U.LName AS LastName
                FROM
                    USER_GYM UG
                JOIN
                    Gyms G ON UG.GymID = G.GymID
                JOIN
                    USERS U ON UG.UserID = U.UserID
                WHERE
                    CONVERT(TIME, DATEADD(YEAR, 3, GETDATE())) > UG.JoiningDate;";
                
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
                        int gymID = reader.IsDBNull(1) ? 0 : (int)reader.GetByte(1);
                        DateTime joiningDate;
                        if (!reader.IsDBNull(2))
                        {
                            try
                            {
                                joiningDate = reader.GetDateTime(2);
                            }
                            catch (InvalidCastException)
                            {
                                Console.WriteLine("Invalid cast for DateTime encountered.");
                                joiningDate = DateTime.MinValue; // Set to MinValue or handle appropriately
                            }
                        }
                        else
                        {
                            joiningDate = DateTime.MinValue;
                        }
                        string gymName = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        string firstName = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string lastName = reader.IsDBNull(5) ? "" : reader.GetString(5);

                        dataGridView1.Rows.Add(userID, gymID, joiningDate, gymName, firstName, lastName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void report9_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
