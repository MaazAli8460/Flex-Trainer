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
    
    public partial class Admin_Interface : Form
    {
        private string username;
        private int userID;
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        PrivateFontCollection privateFonts1 = new PrivateFontCollection();
        PrivateFontCollection privateFonts2 = new PrivateFontCollection();

        Revoke_Gym revokegym;
        GEN_Reports reports;
        Approve_Gym approve1;
        Gym_Performance performance;
        public Admin_Interface(string username, int userID)
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
                Performance_Gyms.Width = (int)Sidebar.Width;
                Revoke.Width = (int)Sidebar.Width;
                Approve.Width = (int)Sidebar.Width;
                Revoke.Width = (int)Sidebar.Width;
                
            }
        }
        private void revert_Color()
        {
            this.Performance_Gyms.BackColor = Color.DarkGray;
            this.Revoke.BackColor = Color.DarkGray;
            this.Approve.BackColor = Color.DarkGray;
            this.Revoke.BackColor = Color.DarkGray;
            

        }
        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }

        private void Performance_Gyms_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Admin.Hide();
            Performance_Gyms.BackColor = Color.Turquoise;
            if (performance == null)
            {
                performance = new Gym_Performance();
                performance.FormClosed += Performance_Gyms_form_Closed;
                performance.MdiParent = this;
                performance.Size = this.Size;
                performance.Show();
            }
            else
            {
                performance.Size = this.Size;
                performance.Activate();
            }
        }
        private void Performance_Gyms_form_Closed(object sender, EventArgs e)
        {
            performance = null;
        }

        private void Revoke_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Admin.Hide();
            Revoke.BackColor = Color.Turquoise;
            if (revokegym == null)
            {
                revokegym = new Revoke_Gym();
                revokegym.FormClosed += Revoke_Gyms_form_Closed;
                revokegym.MdiParent = this;
                revokegym.Size = this.Size;
                revokegym.Show();
            }
            else
            {
                revokegym.Size = this.Size;
                revokegym.Activate();
            }
        }
        private void Revoke_Gyms_form_Closed(object sender, EventArgs e)
        {
            revokegym = null;
        }
        private void Approve_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Admin.Hide();
            Approve.BackColor = Color.Turquoise;
            if (approve1 == null)
            {
                approve1 = new Approve_Gym();
                approve1.FormClosed += Performance_Gyms_form_Closed;
                approve1.MdiParent = this;
                approve1.Size = this.Size;
                approve1.Show();
            }
            else
            {
                approve1.Size = this.Size;
                approve1.Activate();
            }
        }
        private void Approve_Gyms_form_Closed(object sender, EventArgs e)
        {
            approve1 = null;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            revert_Color();
            Main_Admin.Hide();
            Report.BackColor = Color.Turquoise;
            if (reports == null)
            {
                reports = new GEN_Reports();
                reports.FormClosed += Report_form_Closed;
                reports.MdiParent = this;
                reports.Size = this.Size;
                reports.Show();
            }
            else
            {
                reports.Size = this.Size;
                reports.Activate();
            }
        }
        private void Report_form_Closed(object sender, EventArgs e)
        {
            reports = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Username " + username + " User ID " + userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Admin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
