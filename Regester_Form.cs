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
    public partial class Regester_Form : Form
    {
        PrivateFontCollection privateFonts  = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        
        public Regester_Form()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(100, Color.FloralWhite);
            privateFonts.AddFontFile("Deep_Hero.ttf");

            privateFonts1.AddFontFile("Hard_Race.otf");

            privateFonts2.AddFontFile("Stonersport-Regular.ttf");

            bootloader1();
            this.Resize += Form_resize;
        }
        
        private void bootloader1()
        {
            

            Font customFont = new Font(privateFonts.Families[0], 16, FontStyle.Regular);
            Font customFont1 = new Font(privateFonts1.Families[0], 60, FontStyle.Regular);
            Font customFont3 = new Font(privateFonts1.Families[0], 8, FontStyle.Regular);

            label1.Font=customFont;
            label2.Font=customFont3;
            label3.Font=customFont3;
            label4.Font=customFont3;
            label5.Font=customFont3;
            label6.Font=customFont3;
            label7.Font=customFont3;
            label8.Font=customFont3;
            label9.Font=customFont3;
            label10.Font=customFont3;
            button1.Font=customFont3;
            
            customFont.Dispose();
            customFont1.Dispose();
            customFont3.Dispose();


        }

        private void Form_resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.Hide();

                Size formSize = this.panel1.Size;
                Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
                Font customFont3 = new Font(privateFonts1.Families[0], 14, FontStyle.Regular);

                label1.Font = customFont;
                label2.Font = customFont3;
                label3.Font = customFont3;
                label4.Font = customFont3;
                label5.Font = customFont3;
                label6.Font = customFont3;
                label7.Font = customFont3;
                label8.Font = customFont3;
                label9.Font = customFont3;
                label10.Font = customFont3;
                button1.Font = customFont3;
                
                int width = formSize.Width;
                width /= 3;
                width -= 170;
                //label1.Location = new Point(width, 20);

                float scaleX = 2;
                float scaleY = 2;
                foreach (Control control in panel1.Controls)
                {
                    // Scale control size
                    control.Width = (int)(control.Width * scaleX);
                    control.Height = (int)(control.Height * scaleY);

                    // Scale control position
                    control.Left = (int)(control.Left * scaleX);
                    control.Left += width;
                    control.Top = (int)(control.Top * scaleY);
                }
                this.Show();
                customFont.Dispose();
                customFont3.Dispose();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                
                this.Hide();
                bootloader1();
                Size formSize = this.panel1.Size;

                int width = formSize.Width;
                width /= 3;
                width -= 270;
                float scaleX = 2;//(float)this.Width / this.previousFormSize.Width;
                float scaleY = 2;//(float)this.Height / this.Height;
                foreach (Control control in panel1.Controls)
                {
                    // Scale control size
                    control.Width = (int)(control.Width / scaleX);
                    control.Height = (int)(control.Height / scaleY);

                    // Scale control position
                    control.Left = (int)(control.Left / scaleX);
                    control.Left += width;
                    control.Top = (int)(control.Top / scaleY);
                }
                this.Show();
            }
        }
        private void Regester_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Parent.Show();
            privateFonts.Dispose();
            privateFonts1.Dispose();
            privateFonts2.Dispose();

            this.Close();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string username = textBox3.Text;
            string email = textBox4.Text;
            string address = textBox5.Text;
            string phoneNo = textBox6.Text;
            string gender = comboBox1.SelectedItem.ToString();
            string password = textBox8.Text;

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the username already exists
                    SqlCommand checkUsernameCommand = new SqlCommand("SELECT 1 FROM Users WHERE Username = @Username", connection);
                    checkUsernameCommand.Parameters.AddWithValue("@Username", username);

                    bool usernameExists = checkUsernameCommand.ExecuteScalar() != null;

                    if (usernameExists)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    // If the username doesn't exist, insert the new user
                    SqlCommand insertUserCommand = new SqlCommand(@"
                DECLARE @NewUserID INT
                DECLARE @MaxUserID INT

                SELECT @MaxUserID = ISNULL(MAX(UserID), 0) FROM Users
                SET @NewUserID = @MaxUserID + 1
                INSERT INTO Users (UserID, FName, LName, Gender, Address, Phone_No, CNIC, Username, [Password], [Type])
                VALUES (@NewUserID, @FirstName, @LastName, @Gender, @Address, @PhoneNo, '', @Username, @Password, 'Member')", connection);

                    insertUserCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertUserCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertUserCommand.Parameters.AddWithValue("@Gender", gender);
                    insertUserCommand.Parameters.AddWithValue("@Address", address);
                    insertUserCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    insertUserCommand.Parameters.AddWithValue("@Email", email);
                    insertUserCommand.Parameters.AddWithValue("@Username", username);
                    insertUserCommand.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = insertUserCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                        this.Close(); // Close the registration form after successful registration
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
