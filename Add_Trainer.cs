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
    public partial class Add_Trainer : Form
    {
        public Add_Trainer()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            this.panel1.BackColor = Color.FromArgb(150, Color.Turquoise);
            this.panel2.BackColor = Color.FromArgb(150, Color.Turquoise);
            privateFonts.AddFontFile("Deep_Hero.ttf");
            Font customFont = new Font(privateFonts.Families[0], 34, FontStyle.Regular);
            label1.Font = customFont;
        }

        private void Add_Trainer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.SelectedIndex = -1; // Clear combobox selection
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox5.Text;
            string username = textBox4.Text;
            string phoneNo = textBox3.Text;
            string cnic = textBox2.Text;
            string gender = comboBox1.SelectedItem?.ToString(); // Ensure gender is not null
            string address = textBox8.Text;
            string password = textBox9.Text;

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Declare parameters
                    int maxUserID = 0;
                    int newUserID = 0;

                    // Check if the username already exists
                    SqlCommand checkUsernameCommand = new SqlCommand("IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username) BEGIN PRINT 'Username already exists' END ELSE BEGIN SELECT @MaxUserID = ISNULL(MAX(UserID), 0) FROM Users SET @NewUserID = @MaxUserID + 1 INSERT INTO Users (UserID, FName, LName, Gender, Address, Phone_No, CNIC, Username, [Password], [Type]) VALUES (@NewUserID, @FirstName, @LastName, @Gender, @Address, @PhoneNo, @CNIC, @Username, @Password, 'Trainer') PRINT 'User inserted successfully' END", connection);

                    checkUsernameCommand.Parameters.AddWithValue("@Username", username);
                    checkUsernameCommand.Parameters.AddWithValue("@FirstName", firstName);
                    checkUsernameCommand.Parameters.AddWithValue("@LastName", lastName);
                    checkUsernameCommand.Parameters.AddWithValue("@Gender", gender);
                    checkUsernameCommand.Parameters.AddWithValue("@Address", address);
                    checkUsernameCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    checkUsernameCommand.Parameters.AddWithValue("@CNIC", cnic);
                    checkUsernameCommand.Parameters.AddWithValue("@Password", password);

                    checkUsernameCommand.Parameters.Add("@MaxUserID", SqlDbType.Int).Direction = ParameterDirection.Output; // Output parameter
                    checkUsernameCommand.Parameters.Add("@NewUserID", SqlDbType.Int).Direction = ParameterDirection.Output; // Output parameter

                    int rowsAffected = checkUsernameCommand.ExecuteNonQuery();

                    // Get output parameter values
                    maxUserID = (int)checkUsernameCommand.Parameters["@MaxUserID"].Value;
                    newUserID = (int)checkUsernameCommand.Parameters["@NewUserID"].Value;

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trainer added successfully.");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add trainer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
