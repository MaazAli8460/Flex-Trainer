using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Owner : Form
    {
        private string username;
        private int userID;
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();

        Owner_Dashboard dashboard;
        Owner_Member_Report member_report;
        Trainer_Report trainer;
        Add_Trainer new_trainer;
        Account_Management acc_M;
        public Owner(string username, int userID)
        {
            InitializeComponent();
            this.username = username;
            this.userID = userID;
            this.Resize += Form_resize;
            Boot_Loder();

            this.panel2.BackColor = Color.FromArgb(150, Color.Turquoise);
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
            label3.Location = new Point(5, 5);
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
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool expand = true;
        private void HNDL_btn_Click(object sender, EventArgs e)
        {
            if (expand)
            {
                Sidebar.Width = 45;
                if (Sidebar.Width <= 45)
                {
                    expand = false;
                    //SIDEBAR_TRANSITION.Stop();
                }
                
            }
            else
            {
                Sidebar.Width = 190;
                if (Sidebar.Width >= 190)
                {
                    expand = true;
                    //SIDEBAR_TRANSITION.Stop();
                }
                Manage_Account.Width = (int)Sidebar.Width;
                Add_Trainer.Width = (int)Sidebar.Width;
                Trainer_Report.Width = (int)Sidebar.Width;
                MEMBER_REPORT1.Width = (int)Sidebar.Width;
                DASHBOARD1.Width = (int)Sidebar.Width;
            }
        }
        private void revert_Color()
        {
            this.MEMBER_REPORT1.BackColor = Color.DarkGray;
            this.DASHBOARD1.BackColor = Color.DarkGray;
            this.Trainer_Report.BackColor = Color.DarkGray;
            this.Add_Trainer.BackColor = Color.DarkGray;
            this.Manage_Account.BackColor = Color.DarkGray;
            
        }
        private void DASHBOARD_Click(object sender, EventArgs e)
        {
            //remove_Priv();
           
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void Member_Report_Click(object sender, EventArgs e)
        {
            
        }
        private void Member_Report_FormClosed(object sender, FormClosedEventArgs e)
        {

            member_report = null;
        }

        private void Trainer_Report_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Owner.Hide();
            Trainer_Report.BackColor = Color.Turquoise;
            if (trainer == null)
            {
                trainer = new Trainer_Report();
                trainer.FormClosed += Trainer_Report_FormClosed;
                trainer.MdiParent = this;
                trainer.Size = this.Size;
                trainer.Show();
            }
            else
            {
                trainer.Size = this.Size;
                trainer.Activate();
            }
        }
        private void Trainer_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            trainer = null;
        }

        private void Add_Trainer_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Owner.Hide();
            Add_Trainer.BackColor = Color.Turquoise;
            if (new_trainer == null)
            {
                new_trainer = new Add_Trainer();
                new_trainer.FormClosed += Add_Trainer_FormClosed;
                new_trainer.MdiParent = this;
                new_trainer.Size = this.Size;
                new_trainer.Show();
            }
            else
            {
                new_trainer.Size = this.Size;
                new_trainer.Activate();
            }
        }
        private void Add_Trainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            new_trainer = null;
        }

        private void Manage_Account_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Owner.Hide();
            Manage_Account.BackColor = Color.Turquoise;
            if (acc_M == null)
            {
                acc_M = new Account_Management();
                acc_M.FormClosed += Manage_Account_FormClosed;
                acc_M.MdiParent = this;
                acc_M.Size = this.Size;
                acc_M.Show();
            }
            else
            {
                acc_M.Size = this.Size;
                acc_M.Activate();
            }
        }
        private void Manage_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            acc_M = null;
        }

        private void DASHBOARD1_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Owner.Hide();
            DASHBOARD1.BackColor = Color.Turquoise;
            if (dashboard == null)
            {
                dashboard = new Owner_Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Size = this.Size;
                dashboard.Show();
            }
            else
            {
                dashboard.Size = this.Size;
                dashboard.Activate();
            }
        }

        private void MEMBER_REPORT1_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Owner.Hide();
            MEMBER_REPORT1.BackColor = Color.Turquoise;
            if (member_report == null)
            {
                member_report = new Owner_Member_Report();
                member_report.FormClosed += Member_Report_FormClosed;
                member_report.MdiParent = this;
                member_report.Size = this.Size;
                member_report.Show();
            }
            else
            {
                member_report.Size = this.Size;
                member_report.Activate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Username " + username + " User ID " + userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
