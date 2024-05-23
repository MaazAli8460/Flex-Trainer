using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flex_Trainer
{
    public partial class Member_Interface : Form
    {
        private string username;
        private int userID;

        Form_Accessdiet accessdiet;
        Form_Creatediet creatediet;
        Form_Accessworkout accessworkout;
        Form_Createworkout createworkout;
        Form_Booking booking;//=new Form_Booking();
        Form_Dashboard dashboard;//=new Form_Dashboard();
        //Form_Meal meal;
        //Form_Excercise excercise;
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();
        public Member_Interface(string username, int userID)
        {
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            this.Resize += Form_resize;
            Boot_Loder();

            this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
        }
        private void Form_resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Size formSize = this.Size;
                int width = formSize.Width;
                int height = formSize.Height;
                
                panel2.Width = width;
                panel2.Height = 100;
                //this.MaximizeBox = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Size formSize = this.Size;
                int width = formSize.Width;
                int height = formSize.Height;

                panel2.Width = width;
                panel2.Height = 100;
                width /= 2;
                width -= 230;
                label3.Location = new Point(width, 5);
            }
        }
        private void Boot_Loder()
        {
            privateFonts.AddFontFile("Deep_Hero.ttf");

            privateFonts1.AddFontFile("Hard_Race.otf");

            privateFonts2.AddFontFile("Stonersport-Regular.ttf");

            Font customFont = new Font(privateFonts.Families[0], 30, FontStyle.Regular);
            Font customFont1 = new Font(privateFonts1.Families[0], 14, FontStyle.Regular);
            Font customFont3 = new Font(privateFonts1.Families[0], 14, FontStyle.Regular);

            label3.Font = customFont;
            label3.Location = new Point(5,5);
            label1.Font = customFont3;
            //label6.Font = customFont1;
            //label2.Font = customFont3;
            //label3.Font = customFont3;
            //label4.Font = customFont3;
            //label5.Font = customFont3;
            //linkLabel1.Font = customFont3;




            Size formSize = this.panel2.Size;
            int width = formSize.Width;
            int height = formSize.Height;
            
            width /= 2;
            width -= 50;
            label3.Location = new Point(width, 5);
            //label1.Text = "FLEX TRAINER";
            //this.panel1.BackColor = Color.FromArgb(150, Color.Teal);
            //this.panel2.BackColor = Color.FromArgb(150, Color.HotPink);
            //this.panel3.BackColor = Color.FromArgb(100, Color.Navy);
            //textBox1.Refresh();
            //textBox1.ResetText();
            //textBox2.ResetText();

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool expand = true;
        private void remove_Priv()
        {
            //if(booking != null) 
            //{
            //    booking.Close();
            //    booking=null;
            //}
        }
        private void SIDEBAR_TRANSITION_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                Sidebar.Width = 45;
                if (Sidebar.Width <= 45)
                {
                    expand = false;
                    //SIDEBAR_TRANSITION.Stop();
                }
                Accessdiet_panel.Width = (int)Sidebar.Width;
                Accessworkout_panel.Width = (int)Sidebar.Width;
                Booking_Panel.Width = (int)Sidebar.Width;
                Creatediet_panel.Width = (int)Sidebar.Width;
                Createworkout_panel.Width = (int)Sidebar.Width;
                Dashboard_panel.Width = (int)Sidebar.Width;
                //Booking.Width = (int)Sidebar.Width;
                //Access_Diet.Width = (int)Sidebar.Width;
                //Access_Workout.Width = (int)Sidebar.Width;
                //Create_Diet.Width = (int)Sidebar.Width;
                //Create_Workout.Width = (int)Sidebar.Width;
                //Dashboard.Width = (int)Sidebar.Width;
            }
            else
            {
                Sidebar.Width = 190;
                if (Sidebar.Width >= 190)
                {
                    expand = true;
                    //SIDEBAR_TRANSITION.Stop();
                }

                Accessdiet_panel.Width = (int)Sidebar.Width;
                Accessworkout_panel.Width = (int)Sidebar.Width;
                Booking_Panel.Width = (int)Sidebar.Width;
                Creatediet_panel.Width = (int)Sidebar.Width;
                Createworkout_panel.Width = (int)Sidebar.Width;
                Dashboard_panel.Width = (int)Sidebar.Width;
                Booking1.Width = (int)Sidebar.Width;
                Access_Diet.Width = (int)Sidebar.Width;
                Access_Workout.Width = (int)Sidebar.Width;
                Create_Diet.Width = (int)Sidebar.Width;
                Create_Workout.Width = (int)Sidebar.Width;
                DASHBOARD1.Width = (int)Sidebar.Width;
            }
        }
        private void revert_Color()
        {
            this.Booking1.BackColor = Color.DarkGray;
            this.DASHBOARD1.BackColor = Color.DarkGray;
            //this.DASHBOARD.BackColor = Color.DarkGray;
            this.Create_Workout.BackColor = Color.DarkGray;
            this.Access_Workout.BackColor = Color.DarkGray;
            this.Access_Diet.BackColor = Color.DarkGray;
            this.Create_Diet.BackColor = Color.DarkGray;
        }
        private void HNDL_btn_Click(object sender, EventArgs e)
        {
            //SIDEBAR_TRANSITION.Start();
            
                if (expand)
                {
                    Sidebar.Width = 45;
                    if (Sidebar.Width <= 45)
                    {
                        expand = false;
                        //SIDEBAR_TRANSITION.Stop();
                    }
                    Accessdiet_panel.Width = (int)Sidebar.Width;
                    Accessworkout_panel.Width = (int)Sidebar.Width;
                    Booking_Panel.Width = (int)Sidebar.Width;
                    Creatediet_panel.Width = (int)Sidebar.Width;
                    Createworkout_panel.Width = (int)Sidebar.Width;
                    Dashboard_panel.Width = (int)Sidebar.Width;
                    //Booking.Width = (int)Sidebar.Width;
                    //Access_Diet.Width = (int)Sidebar.Width;
                    //Access_Workout.Width = (int)Sidebar.Width;
                    //Create_Diet.Width = (int)Sidebar.Width;
                    //Create_Workout.Width = (int)Sidebar.Width;
                    //Dashboard.Width = (int)Sidebar.Width;
                }
                else
                {
                    Sidebar.Width = 190;
                    if (Sidebar.Width >= 190)
                    {
                        expand = true;
                        //SIDEBAR_TRANSITION.Stop();
                    }

                    Accessdiet_panel.Width = (int)Sidebar.Width;
                    Accessworkout_panel.Width = (int)Sidebar.Width;
                    Booking_Panel.Width = (int)Sidebar.Width;
                    Creatediet_panel.Width = (int)Sidebar.Width;
                    Createworkout_panel.Width = (int)Sidebar.Width;
                    Dashboard_panel.Width = (int)Sidebar.Width;
                    Booking1.Width = (int)Sidebar.Width;
                    Access_Diet.Width = (int)Sidebar.Width;
                    Access_Workout.Width = (int)Sidebar.Width;
                    Create_Diet.Width = (int)Sidebar.Width;
                    Create_Workout.Width = (int)Sidebar.Width;
                    DASHBOARD1.Width = (int)Sidebar.Width;
                }
            
        }

        private void DASHBOARD_Click(object sender, EventArgs e)
        {
            remove_Priv();
            revert_Color();
            Main_Member.Hide();
            DASHBOARD1.BackColor = Color.Orange;
            if (dashboard == null)
            {
                dashboard = new Form_Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                //dashboard.Size = this.Size;
                dashboard.Show();
            }
            else
            {
                dashboard.Size = this.Size;
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void Create_Workout_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Create_Workout.BackColor = Color.Orange;
            if (createworkout == null)
            {
                createworkout = new Form_Createworkout();
                createworkout.FormClosed += Create_Workout_FormClosed;
                createworkout.MdiParent = this;
                //createworkout.Size = this.Size;

                createworkout.Show();
            }
            else
            {
                createworkout.Size = this.Size;
                createworkout.Activate();
            }
        }
        
        private void Create_Workout_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            createworkout = null;
        }

        private void Access_Workout_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Access_Workout.BackColor = Color.Orange;
            if (accessworkout == null)
            {
                accessworkout = new Form_Accessworkout();
                accessworkout.FormClosed += Access_Workout_FormClosed;
                accessworkout.MdiParent = this;
                //accessworkout.Size = this.Size;

                accessworkout.Show();
            }
            else
            {

                //accessworkout.Size = this.Size;
                accessworkout.Activate();
            }
        }
        private void Access_Workout_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            accessworkout = null;
        }

        private void Create_Diet_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Create_Diet.BackColor = Color.Orange;//Salmon
            if (creatediet == null)
            {
                creatediet = new Form_Creatediet();
                creatediet.FormClosed += Create_Diet_FormClosed;
                creatediet.MdiParent = this;
                //creatediet.Size = this.Size;

                creatediet.Show();
            }
            else
            {
                creatediet.Size = this.Size;
                creatediet.Activate();
            }
        }
        

        private void Create_Diet_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            creatediet = null;
        }

        private void Access_Diet_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Access_Diet.BackColor = Color.Orange;
            if (accessdiet == null)
            {
                accessdiet = new Form_Accessdiet();
                accessdiet.FormClosed += Access_Diet_FormClosed;
                accessdiet.MdiParent = this;
                //accessdiet.Size = this.Size;

                accessdiet.Show();
            }
            else
            {
                accessdiet.Size = this.Size;
                accessdiet.Activate();
            }
        }
        private void Access_Diet_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            accessdiet = null;
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Booking1.BackColor = Color.Orange;
            if (booking == null)
            {
                booking = new Form_Booking(username,userID);
                booking.FormClosed += Booking_FormClosed;
                booking.MdiParent = this;
                //booking.Size = this.Size;

                booking.Show();
            }
            else
            {
                booking.Size = this.Size;
                booking.Activate();
            }
        }

        private void Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            
            booking = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Booking1_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Member.Hide();
            Booking1.BackColor = Color.Orange;
            if (booking == null)
            {
                booking = new Form_Booking(username,userID);
                booking.FormClosed += Booking_FormClosed;
                booking.MdiParent = this;
                //booking.Size = this.Size;

                booking.Show();
            }
            else
            {
                booking.Size = this.Size;
                booking.Activate();
            }
        }

        private void DASHBOARD1_Click(object sender, EventArgs e)
        {
            remove_Priv();
            revert_Color();
            Main_Member.Hide();
            DASHBOARD1.BackColor = Color.Orange;
            if (dashboard == null)
            {
                dashboard = new Form_Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                //dashboard.Size = this.Size;
                dashboard.Show();
            }
            else
            {
                dashboard.Size = this.Size;
                dashboard.Activate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
                label2.Text = "Username " + username+" User ID " + userID;
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Member_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
