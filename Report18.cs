using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class report18 : Form
    {
        public report18()
        {
            InitializeComponent();
            LoadData();
        }



        private void LoadData()
        {
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            string query = @"
                SELECT g.GymID, g.Name, g.Location, gp.MembershipGrowth
                FROM Gyms g
                JOIN GymPerformance gp ON g.GymID = gp.Gym_ID
                WHERE gp.MembershipGrowth = (SELECT MIN(MembershipGrowth) FROM GymPerformance);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int gymID = (int)reader.GetByte(0);
                        string name = reader.GetString(1);
                        string location = reader.GetString(2);
                        string membershipGrowth = reader.GetString(3);

                        dataGridView1.Rows.Add(gymID, name, location, membershipGrowth);
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
