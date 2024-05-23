namespace Flex_Trainer
{
    partial class Member_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Interface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HNDL_btn = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Dashboard_panel = new System.Windows.Forms.Panel();
            this.DASHBOARD1 = new System.Windows.Forms.Button();
            this.Createworkout_panel = new System.Windows.Forms.Panel();
            this.Create_Workout = new System.Windows.Forms.Button();
            this.Accessworkout_panel = new System.Windows.Forms.Panel();
            this.Access_Workout = new System.Windows.Forms.Button();
            this.Creatediet_panel = new System.Windows.Forms.Panel();
            this.Create_Diet = new System.Windows.Forms.Button();
            this.Accessdiet_panel = new System.Windows.Forms.Panel();
            this.Access_Diet = new System.Windows.Forms.Button();
            this.Booking_Panel = new System.Windows.Forms.Panel();
            this.Booking1 = new System.Windows.Forms.Button();
            this.SIDEBAR_TRANSITION = new System.Windows.Forms.Timer(this.components);
            this.Main_Member = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.Dashboard_panel.SuspendLayout();
            this.Createworkout_panel.SuspendLayout();
            this.Accessworkout_panel.SuspendLayout();
            this.Creatediet_panel.SuspendLayout();
            this.Accessdiet_panel.SuspendLayout();
            this.Booking_Panel.SuspendLayout();
            this.Main_Member.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HNDL_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 47);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEMBER";
            // 
            // HNDL_btn
            // 
            this.HNDL_btn.BackColor = System.Drawing.Color.Transparent;
            this.HNDL_btn.BackgroundImage = global::Flex_Trainer.Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Bars_48;
            this.HNDL_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HNDL_btn.Location = new System.Drawing.Point(12, 8);
            this.HNDL_btn.Name = "HNDL_btn";
            this.HNDL_btn.Size = new System.Drawing.Size(46, 32);
            this.HNDL_btn.TabIndex = 0;
            this.HNDL_btn.TabStop = false;
            this.HNDL_btn.Click += new System.EventHandler(this.HNDL_btn_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sidebar.Controls.Add(this.Dashboard_panel);
            this.Sidebar.Controls.Add(this.Createworkout_panel);
            this.Sidebar.Controls.Add(this.Accessworkout_panel);
            this.Sidebar.Controls.Add(this.Creatediet_panel);
            this.Sidebar.Controls.Add(this.Accessdiet_panel);
            this.Sidebar.Controls.Add(this.Booking_Panel);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 47);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(218, 515);
            this.Sidebar.TabIndex = 1;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Dashboard_panel
            // 
            this.Dashboard_panel.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_panel.Controls.Add(this.DASHBOARD1);
            this.Dashboard_panel.Location = new System.Drawing.Point(3, 3);
            this.Dashboard_panel.Name = "Dashboard_panel";
            this.Dashboard_panel.Size = new System.Drawing.Size(213, 61);
            this.Dashboard_panel.TabIndex = 3;
            // 
            // DASHBOARD1
            // 
            this.DASHBOARD1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DASHBOARD1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DASHBOARD1.FlatAppearance.BorderSize = 0;
            this.DASHBOARD1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DASHBOARD1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DASHBOARD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DASHBOARD1.Image = global::Flex_Trainer.Properties.Resources.icons8_dashboard_layout_241;
            this.DASHBOARD1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DASHBOARD1.Location = new System.Drawing.Point(-4, -2);
            this.DASHBOARD1.Name = "DASHBOARD1";
            this.DASHBOARD1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DASHBOARD1.Size = new System.Drawing.Size(217, 60);
            this.DASHBOARD1.TabIndex = 1;
            this.DASHBOARD1.Text = "DASHBOARD\r\n\r\n";
            this.DASHBOARD1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DASHBOARD1.UseVisualStyleBackColor = false;
            this.DASHBOARD1.Click += new System.EventHandler(this.DASHBOARD1_Click);
            // 
            // Createworkout_panel
            // 
            this.Createworkout_panel.BackColor = System.Drawing.Color.Transparent;
            this.Createworkout_panel.Controls.Add(this.Create_Workout);
            this.Createworkout_panel.Location = new System.Drawing.Point(3, 70);
            this.Createworkout_panel.Name = "Createworkout_panel";
            this.Createworkout_panel.Size = new System.Drawing.Size(213, 60);
            this.Createworkout_panel.TabIndex = 3;
            // 
            // Create_Workout
            // 
            this.Create_Workout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Workout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create_Workout.FlatAppearance.BorderSize = 0;
            this.Create_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Create_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Workout.Image = global::Flex_Trainer.Properties.Resources.icons8_battle_ropes_24;
            this.Create_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Workout.Location = new System.Drawing.Point(-4, 0);
            this.Create_Workout.Name = "Create_Workout";
            this.Create_Workout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Create_Workout.Size = new System.Drawing.Size(217, 60);
            this.Create_Workout.TabIndex = 0;
            this.Create_Workout.Text = "CREATE\r\nWORKOUT\r\n";
            this.Create_Workout.UseVisualStyleBackColor = false;
            this.Create_Workout.Click += new System.EventHandler(this.Create_Workout_Click);
            // 
            // Accessworkout_panel
            // 
            this.Accessworkout_panel.BackColor = System.Drawing.Color.Transparent;
            this.Accessworkout_panel.Controls.Add(this.Access_Workout);
            this.Accessworkout_panel.Location = new System.Drawing.Point(3, 136);
            this.Accessworkout_panel.Name = "Accessworkout_panel";
            this.Accessworkout_panel.Size = new System.Drawing.Size(213, 64);
            this.Accessworkout_panel.TabIndex = 4;
            // 
            // Access_Workout
            // 
            this.Access_Workout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Workout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Access_Workout.FlatAppearance.BorderSize = 0;
            this.Access_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Access_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Access_Workout.Image = global::Flex_Trainer.Properties.Resources.icons8_access_24;
            this.Access_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Access_Workout.Location = new System.Drawing.Point(-4, -1);
            this.Access_Workout.Name = "Access_Workout";
            this.Access_Workout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Access_Workout.Size = new System.Drawing.Size(217, 65);
            this.Access_Workout.TabIndex = 0;
            this.Access_Workout.Text = "ACCESS\r\nWORKOUT\r\n";
            this.Access_Workout.UseVisualStyleBackColor = false;
            this.Access_Workout.Click += new System.EventHandler(this.Access_Workout_Click);
            // 
            // Creatediet_panel
            // 
            this.Creatediet_panel.BackColor = System.Drawing.Color.Transparent;
            this.Creatediet_panel.Controls.Add(this.Create_Diet);
            this.Creatediet_panel.Location = new System.Drawing.Point(3, 206);
            this.Creatediet_panel.Name = "Creatediet_panel";
            this.Creatediet_panel.Size = new System.Drawing.Size(213, 67);
            this.Creatediet_panel.TabIndex = 2;
            // 
            // Create_Diet
            // 
            this.Create_Diet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Diet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create_Diet.FlatAppearance.BorderSize = 0;
            this.Create_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Create_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Diet.Image = global::Flex_Trainer.Properties.Resources.icons8_create_24;
            this.Create_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Diet.Location = new System.Drawing.Point(-4, -4);
            this.Create_Diet.Name = "Create_Diet";
            this.Create_Diet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Create_Diet.Size = new System.Drawing.Size(217, 68);
            this.Create_Diet.TabIndex = 0;
            this.Create_Diet.Text = "CREATE\r\nDIET PLAN\r\n";
            this.Create_Diet.UseVisualStyleBackColor = false;
            this.Create_Diet.Click += new System.EventHandler(this.Create_Diet_Click);
            // 
            // Accessdiet_panel
            // 
            this.Accessdiet_panel.BackColor = System.Drawing.Color.Transparent;
            this.Accessdiet_panel.Controls.Add(this.Access_Diet);
            this.Accessdiet_panel.Location = new System.Drawing.Point(3, 279);
            this.Accessdiet_panel.Name = "Accessdiet_panel";
            this.Accessdiet_panel.Size = new System.Drawing.Size(213, 62);
            this.Accessdiet_panel.TabIndex = 3;
            // 
            // Access_Diet
            // 
            this.Access_Diet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Diet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Access_Diet.FlatAppearance.BorderSize = 0;
            this.Access_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Access_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Access_Diet.Image = global::Flex_Trainer.Properties.Resources.icons8_cutlery_24;
            this.Access_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Access_Diet.Location = new System.Drawing.Point(-4, -5);
            this.Access_Diet.Name = "Access_Diet";
            this.Access_Diet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Access_Diet.Size = new System.Drawing.Size(217, 67);
            this.Access_Diet.TabIndex = 0;
            this.Access_Diet.Text = "ACCESS \r\nDIET PLAN";
            this.Access_Diet.UseVisualStyleBackColor = false;
            this.Access_Diet.Click += new System.EventHandler(this.Access_Diet_Click);
            // 
            // Booking_Panel
            // 
            this.Booking_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Booking_Panel.Controls.Add(this.Booking1);
            this.Booking_Panel.Location = new System.Drawing.Point(3, 347);
            this.Booking_Panel.Name = "Booking_Panel";
            this.Booking_Panel.Size = new System.Drawing.Size(213, 62);
            this.Booking_Panel.TabIndex = 3;
            // 
            // Booking1
            // 
            this.Booking1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Booking1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Booking1.FlatAppearance.BorderSize = 0;
            this.Booking1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Booking1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Booking1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking1.Image = global::Flex_Trainer.Properties.Resources.icons8_booking_241;
            this.Booking1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booking1.Location = new System.Drawing.Point(0, -5);
            this.Booking1.Name = "Booking1";
            this.Booking1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Booking1.Size = new System.Drawing.Size(217, 67);
            this.Booking1.TabIndex = 1;
            this.Booking1.Text = "BOOKING\r\n";
            this.Booking1.UseVisualStyleBackColor = false;
            this.Booking1.Click += new System.EventHandler(this.Booking1_Click);
            // 
            // SIDEBAR_TRANSITION
            // 
            this.SIDEBAR_TRANSITION.Interval = 10;
            this.SIDEBAR_TRANSITION.Tick += new System.EventHandler(this.SIDEBAR_TRANSITION_Tick);
            // 
            // Main_Member
            // 
            this.Main_Member.BackColor = System.Drawing.SystemColors.Control;
            this.Main_Member.BackgroundImage = global::Flex_Trainer.Properties.Resources.pexels_pixabay_260447;
            this.Main_Member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Member.Controls.Add(this.panel2);
            this.Main_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Member.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Main_Member.Location = new System.Drawing.Point(218, 47);
            this.Main_Member.Name = "Main_Member";
            this.Main_Member.Size = new System.Drawing.Size(840, 515);
            this.Main_Member.TabIndex = 3;
            this.Main_Member.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Member_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 89);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "FLEX TRAINER - MEMBER INTERFACE";
            // 
            // Member_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 562);
            this.Controls.Add(this.Main_Member);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Member_Interface";
            this.Text = "Member_Interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Dashboard_panel.ResumeLayout(false);
            this.Createworkout_panel.ResumeLayout(false);
            this.Accessworkout_panel.ResumeLayout(false);
            this.Creatediet_panel.ResumeLayout(false);
            this.Accessdiet_panel.ResumeLayout(false);
            this.Booking_Panel.ResumeLayout(false);
            this.Main_Member.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HNDL_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel Creatediet_panel;
        private System.Windows.Forms.Button Create_Diet;
        private System.Windows.Forms.Panel Accessworkout_panel;
        private System.Windows.Forms.Button Access_Workout;
        private System.Windows.Forms.Panel Accessdiet_panel;
        private System.Windows.Forms.Button Access_Diet;
        private System.Windows.Forms.Panel Dashboard_panel;
        private System.Windows.Forms.Panel Createworkout_panel;
        private System.Windows.Forms.Button Create_Workout;
        private System.Windows.Forms.Panel Booking_Panel;
        private System.Windows.Forms.Timer SIDEBAR_TRANSITION;
        private System.Windows.Forms.FlowLayoutPanel Main_Member;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Booking1;
        private System.Windows.Forms.Button DASHBOARD1;
        private System.Windows.Forms.Button button1;
    }
}