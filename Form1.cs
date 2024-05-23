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
    public partial class LOGIN : Form
    {
        Regester_Form REG;
        Member_Interface member;
        Main_Trainer trainer;
        Owner owner1;
        Admin_Interface admin1;
        private string username;
        private int userID;

        //Temp1 tw;
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        
        public LOGIN()
        {
            InitializeComponent();
            Boot_Loder();
            this.Resize += Form_resize;
            this.FormClosed += SETTER1;
        }
        private void Boot_Loder()
        {
            privateFonts.AddFontFile("Deep_Hero.ttf");

            privateFonts1.AddFontFile("Hard_Race.otf");

            privateFonts2.AddFontFile("Stonersport-Regular.ttf");

            Font customFont = new Font(privateFonts.Families[0], 50, FontStyle.Regular);
            Font customFont1 = new Font(privateFonts1.Families[0], 60, FontStyle.Regular);
            Font customFont3 = new Font(privateFonts1.Families[0], 14, FontStyle.Regular);

            label1.Font = customFont;
            label6.Font = customFont1;
            label2.Font = customFont3;
            label3.Font = customFont3;
            label4.Font = customFont3;
            label5.Font = customFont3;
            linkLabel1.Font = customFont3;




            Size formSize = this.panel3.Size;
            int width = formSize.Width;
            int height = formSize.Height;
            height /= 2;
            height -= 200;
            width /= 2;
            width -= 150;
            label6.Location = new Point(width, height);
            //label1.Text = "FLEX TRAINER";
            this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            textBox1.ResetText();
            textBox2.ResetText();

        }
        private void Form_resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Size formSize = this.panel3.Size;
                int width = formSize.Width;
                int height = formSize.Height;
                height /= 2;
                height -= 200;
                width /= 2;
                width -= 150;
                label6.Location = new Point(width, height);
                //this.MaximizeBox = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Size formSize = this.panel3.Size;
                int width = formSize.Width;
                int height = formSize.Height;
                height /= 2;
                height -= 200;
                width /= 2;
                width -= 150;
                label6.Location = new Point(width, height);
            }
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (trainer == null)
            {
                trainer = new Main_Trainer(username,userID);
                trainer.FormClosed += Trainer_FormClosed;
            }
            
            trainer.Show();
            this.Hide();


        }

        private void Trainer_FormClosed1(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Trainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the previous form (Form1) again
            trainer = null;
            this.Show();
            this.Boot_Loder();

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (admin1==null)
            {
                admin1=new Admin_Interface(username,userID);
                admin1.FormClosed += Admin_FormClosed;
            }
            admin1.Show();
            this.Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the previous form (Form1) again
            admin1 = null;
            this.Show();
            this.Boot_Loder();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (REG==null)
            {
                REG = new Regester_Form();
            }
            this.Hide();
            REG.FormClosed += Regestration_FormClosed;
            REG.Show();
            //tw = new Temp1();
            //tw.Show();
        }
        private void Regestration_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the previous form (Form1) again
            REG = null;
            this.Show();
            this.Boot_Loder();
            
        }
        private void SETTER1(object sender, FormClosedEventArgs e)
        {
            privateFonts.Dispose();
            privateFonts1.Dispose();
            privateFonts2.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(member==null)
            {
                member=new Member_Interface(username,userID);
                member.FormClosed += Member_FormClosed;
            }
            this.Hide();
            member.Show();
        }
        private void Member_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the previous form (Form1) again
            member = null;
            this.Show();
            this.Boot_Loder();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            if(owner1==null)
            {
                owner1 = new Owner(username,userID);
                owner1.FormClosed += Owner_FormClosed;
            }
            this.Hide();
            owner1.Show();

        }
        private void Owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the previous form (Form1) again
            owner1 = null;
            this.Show();
            this.Boot_Loder();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetUsername()
        {
            return username;
        }

        public int GetUserID()
        {
            return userID;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            string password = textBox2.Text;

            // Make database connection
            string connectionString = "Data Source=HUZAIFA\\SQLEXPRESS03;Initial Catalog=PROJECT;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check user type
                    // Execute query to get user type
                    string query = "SELECT Type FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    string userType = command.ExecuteScalar() as string;

                    // Execute query to get UserID
                    string query2 = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@Username", username);
                    command2.Parameters.AddWithValue("@Password", password);
                    int userID = Convert.ToInt32(command2.ExecuteScalar());

                    string auditAction = $"User '{username}' logged in.";
                    string insertAuditQuery = "INSERT INTO Audit (Action) VALUES (@Action)";
                    SqlCommand insertAuditCommand = new SqlCommand(insertAuditQuery, connection);
                    insertAuditCommand.Parameters.AddWithValue("@Action", auditAction);
                    insertAuditCommand.ExecuteNonQuery();

                    // Check if user exists
                    if (!string.IsNullOrEmpty(userType))
                    {
                        this.username = username; // Store username
                                                  // Load the respective form based on user type
                        switch (userType)
                        {
                            case "Member":
                                Member_Interface memberForm = new Member_Interface(username, userID);
                                memberForm.Show();
                                break;
                            case "Admin":
                                Admin_Interface adminForm = new Admin_Interface(username, userID);
                                adminForm.Show();
                                break;
                            case "Trainer":
                                Main_Trainer trainerForm = new Main_Trainer(username, userID);
                                trainerForm.Show();
                                break;
                            case "Owner":
                                Owner ownerForm = new Owner(username, userID);
                                ownerForm.Show();
                                break;
                            default:
                                MessageBox.Show("Invalid user type.");
                                break;
                        }
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
