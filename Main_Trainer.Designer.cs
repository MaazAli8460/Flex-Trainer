namespace Flex_Trainer
{
    partial class Main_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Trainer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HNDL_btn = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.DASHBOARD1 = new System.Windows.Forms.Button();
            this.Create_Workout = new System.Windows.Forms.Button();
            this.Access_Workout = new System.Windows.Forms.Button();
            this.Create_Diet = new System.Windows.Forms.Button();
            this.Access_Diet = new System.Windows.Forms.Button();
            this.Booking1 = new System.Windows.Forms.Button();
            this.Main_Member = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).BeginInit();
            this.Sidebar.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1032, 51);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRAINER";
            // 
            // HNDL_btn
            // 
            this.HNDL_btn.BackColor = System.Drawing.Color.Transparent;
            this.HNDL_btn.BackgroundImage = global::Flex_Trainer.Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Bars_48;
            this.HNDL_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HNDL_btn.Location = new System.Drawing.Point(12, 12);
            this.HNDL_btn.Name = "HNDL_btn";
            this.HNDL_btn.Size = new System.Drawing.Size(46, 32);
            this.HNDL_btn.TabIndex = 1;
            this.HNDL_btn.TabStop = false;
            this.HNDL_btn.Click += new System.EventHandler(this.HNDL_btn_Click_1);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sidebar.Controls.Add(this.DASHBOARD1);
            this.Sidebar.Controls.Add(this.Create_Workout);
            this.Sidebar.Controls.Add(this.Access_Workout);
            this.Sidebar.Controls.Add(this.Create_Diet);
            this.Sidebar.Controls.Add(this.Access_Diet);
            this.Sidebar.Controls.Add(this.Booking1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 51);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(216, 467);
            this.Sidebar.TabIndex = 4;
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
            this.DASHBOARD1.Location = new System.Drawing.Point(3, 3);
            this.DASHBOARD1.Name = "DASHBOARD1";
            this.DASHBOARD1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.DASHBOARD1.Size = new System.Drawing.Size(217, 60);
            this.DASHBOARD1.TabIndex = 8;
            this.DASHBOARD1.Text = "DASHBOARD\r\n\r\n";
            this.DASHBOARD1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DASHBOARD1.UseVisualStyleBackColor = false;
            this.DASHBOARD1.Click += new System.EventHandler(this.DASHBOARD1_Click);
            // 
            // Create_Workout
            // 
            this.Create_Workout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Workout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create_Workout.FlatAppearance.BorderSize = 0;
            this.Create_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Create_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Workout.Image = global::Flex_Trainer.Properties.Resources.icons8_battle_ropes_24;
            this.Create_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Workout.Location = new System.Drawing.Point(3, 69);
            this.Create_Workout.Name = "Create_Workout";
            this.Create_Workout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Create_Workout.Size = new System.Drawing.Size(217, 60);
            this.Create_Workout.TabIndex = 3;
            this.Create_Workout.Text = "CREATE\r\nWORKOUT\r\n";
            this.Create_Workout.UseVisualStyleBackColor = false;
            this.Create_Workout.Click += new System.EventHandler(this.Create_Workout_Click_1);
            // 
            // Access_Workout
            // 
            this.Access_Workout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Workout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Access_Workout.FlatAppearance.BorderSize = 0;
            this.Access_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Access_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Access_Workout.Image = global::Flex_Trainer.Properties.Resources.icons8_access_24;
            this.Access_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Access_Workout.Location = new System.Drawing.Point(3, 135);
            this.Access_Workout.Name = "Access_Workout";
            this.Access_Workout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Access_Workout.Size = new System.Drawing.Size(217, 65);
            this.Access_Workout.TabIndex = 4;
            this.Access_Workout.Text = "ACCESS\r\nWORKOUT\r\n";
            this.Access_Workout.UseVisualStyleBackColor = false;
            this.Access_Workout.Click += new System.EventHandler(this.Access_Workout_Click_1);
            // 
            // Create_Diet
            // 
            this.Create_Diet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Diet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create_Diet.FlatAppearance.BorderSize = 0;
            this.Create_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Create_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Diet.Image = global::Flex_Trainer.Properties.Resources.icons8_cutlery_241;
            this.Create_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create_Diet.Location = new System.Drawing.Point(3, 206);
            this.Create_Diet.Name = "Create_Diet";
            this.Create_Diet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Create_Diet.Size = new System.Drawing.Size(217, 68);
            this.Create_Diet.TabIndex = 5;
            this.Create_Diet.Text = "CREATE\r\nDIET PLAN\r\n";
            this.Create_Diet.UseVisualStyleBackColor = false;
            this.Create_Diet.Click += new System.EventHandler(this.Create_Diet_Click_1);
            // 
            // Access_Diet
            // 
            this.Access_Diet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Diet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Access_Diet.FlatAppearance.BorderSize = 0;
            this.Access_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Access_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Access_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Access_Diet.Image = global::Flex_Trainer.Properties.Resources.icons8_create_24;
            this.Access_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Access_Diet.Location = new System.Drawing.Point(3, 280);
            this.Access_Diet.Name = "Access_Diet";
            this.Access_Diet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Access_Diet.Size = new System.Drawing.Size(217, 68);
            this.Access_Diet.TabIndex = 6;
            this.Access_Diet.Text = "ACCESS\r\nDIET PLAN\r\n";
            this.Access_Diet.UseVisualStyleBackColor = false;
            this.Access_Diet.Click += new System.EventHandler(this.Access_Diet_Click_1);
            // 
            // Booking1
            // 
            this.Booking1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Booking1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Booking1.FlatAppearance.BorderSize = 0;
            this.Booking1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Booking1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Booking1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking1.Image = global::Flex_Trainer.Properties.Resources.icons8_booking_242;
            this.Booking1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booking1.Location = new System.Drawing.Point(3, 354);
            this.Booking1.Name = "Booking1";
            this.Booking1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Booking1.Size = new System.Drawing.Size(217, 60);
            this.Booking1.TabIndex = 7;
            this.Booking1.Text = "Booking";
            this.Booking1.UseVisualStyleBackColor = false;
            this.Booking1.Click += new System.EventHandler(this.Booking1_Click);
            // 
            // Main_Member
            // 
            this.Main_Member.BackgroundImage = global::Flex_Trainer.Properties.Resources.pexels_pixabay_260447__1_;
            this.Main_Member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Member.Controls.Add(this.panel2);
            this.Main_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Member.Location = new System.Drawing.Point(216, 51);
            this.Main_Member.Name = "Main_Member";
            this.Main_Member.Size = new System.Drawing.Size(816, 467);
            this.Main_Member.TabIndex = 5;
            this.Main_Member.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Member_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 84);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "FLEX TRAINER - TRAINER INTERFACE";
            // 
            // Main_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 518);
            this.Controls.Add(this.Main_Member);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main_Trainer";
            this.Text = "Main_Trainer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Main_Member.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HNDL_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button Create_Workout;
        private System.Windows.Forms.Button Access_Workout;
        private System.Windows.Forms.Button Create_Diet;
        private System.Windows.Forms.Button Access_Diet;
        private System.Windows.Forms.FlowLayoutPanel Main_Member;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Booking1;
        private System.Windows.Forms.Button DASHBOARD1;
        private System.Windows.Forms.Button button1;

        //    #endregion
        //    /// <summary>
        //    /// Required designer variable.
        //    /// </summary>
        //    private System.ComponentModel.IContainer components = null;

        //    /// <summary>
        //    /// Clean up any resources being used.
        //    /// </summary>
        //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing && (components != null))
        //        {
        //            components.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    #region Windows Form Designer generated code

        //    /// <summary>
        //    /// Required method for Designer support - do not modify
        //    /// the contents of this method with the code editor.
        //    /// </summary>
        //    private void InitializeComponent()
        //    {
        //        this.components = new System.ComponentModel.Container();
        //        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MEMBER));
        //        this.panel1 = new System.Windows.Forms.Panel();
        //        this.label1 = new System.Windows.Forms.Label();
        //        this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
        //        this.panelDashboard = new System.Windows.Forms.Panel();
        //        this.panelCreateDiet = new System.Windows.Forms.Panel();
        //        this.panelCreateWorkout = new System.Windows.Forms.Panel();
        //        this.panelBook = new System.Windows.Forms.Panel();
        //        this.panelAccessDiet = new System.Windows.Forms.Panel();
        //        this.panelAccessWorkout = new System.Windows.Forms.Panel();
        //        this.Sidebar_transition = new System.Windows.Forms.Timer(this.components);
        //        this.Dashboard = new System.Windows.Forms.Button();
        //        this.Create_Workout = new System.Windows.Forms.Button();
        //        this.Access_Workout = new System.Windows.Forms.Button();
        //        this.Create_Diet = new System.Windows.Forms.Button();
        //        this.Access_Diet = new System.Windows.Forms.Button();
        //        this.Booking = new System.Windows.Forms.Button();
        //        this.button1 = new System.Windows.Forms.Button();
        //        this.Handle_btn = new System.Windows.Forms.PictureBox();
        //        this.panel2 = new System.Windows.Forms.Panel();
        //        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        //        this.panel1.SuspendLayout();
        //        this.Sidebar.SuspendLayout();
        //        this.panelDashboard.SuspendLayout();
        //        this.panelCreateDiet.SuspendLayout();
        //        this.panelCreateWorkout.SuspendLayout();
        //        this.panelBook.SuspendLayout();
        //        this.panelAccessDiet.SuspendLayout();
        //        this.panelAccessWorkout.SuspendLayout();
        //        ((System.ComponentModel.ISupportInitialize)(this.Handle_btn)).BeginInit();
        //        this.panel2.SuspendLayout();
        //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        //        this.SuspendLayout();
        //        // 
        //        // panel1
        //        // 
        //        this.panel1.BackColor = System.Drawing.Color.Transparent;
        //        this.panel1.Controls.Add(this.label1);
        //        this.panel1.Controls.Add(this.Handle_btn);
        //        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        //        this.panel1.Location = new System.Drawing.Point(0, 0);
        //        this.panel1.Name = "panel1";
        //        this.panel1.Size = new System.Drawing.Size(1071, 49);
        //        this.panel1.TabIndex = 0;
        //        this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
        //        // 
        //        // label1
        //        // 
        //        this.label1.AutoSize = true;
        //        this.label1.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
        //        this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        //        this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        //        this.label1.Location = new System.Drawing.Point(43, 9);
        //        this.label1.Name = "label1";
        //        this.label1.Size = new System.Drawing.Size(155, 37);
        //        this.label1.TabIndex = 1;
        //        this.label1.Text = "TRAINER";
        //        this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        //        this.label1.Click += new System.EventHandler(this.label1_Click);
        //        // 
        //        // Sidebar
        //        // 
        //        this.Sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        //        this.Sidebar.Controls.Add(this.panelDashboard);
        //        this.Sidebar.Controls.Add(this.panelCreateDiet);
        //        this.Sidebar.Controls.Add(this.panelCreateWorkout);
        //        this.Sidebar.Controls.Add(this.panelBook);
        //        this.Sidebar.Controls.Add(this.panelAccessDiet);
        //        this.Sidebar.Controls.Add(this.panelAccessWorkout);
        //        this.Sidebar.Controls.Add(this.button1);
        //        this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
        //        this.Sidebar.Location = new System.Drawing.Point(0, 49);
        //        this.Sidebar.Name = "Sidebar";
        //        this.Sidebar.Size = new System.Drawing.Size(190, 472);
        //        this.Sidebar.TabIndex = 1;
        //        this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
        //        // 
        //        // panelDashboard
        //        // 
        //        this.panelDashboard.Controls.Add(this.Dashboard);
        //        this.panelDashboard.ForeColor = System.Drawing.Color.Black;
        //        this.panelDashboard.Location = new System.Drawing.Point(3, 3);
        //        this.panelDashboard.Name = "panelDashboard";
        //        this.panelDashboard.Size = new System.Drawing.Size(187, 66);
        //        this.panelDashboard.TabIndex = 3;
        //        // 
        //        // panelCreateDiet
        //        // 
        //        this.panelCreateDiet.Controls.Add(this.Create_Workout);
        //        this.panelCreateDiet.Location = new System.Drawing.Point(3, 75);
        //        this.panelCreateDiet.Name = "panelCreateDiet";
        //        this.panelCreateDiet.Size = new System.Drawing.Size(187, 64);
        //        this.panelCreateDiet.TabIndex = 5;
        //        // 
        //        // panelCreateWorkout
        //        // 
        //        this.panelCreateWorkout.Controls.Add(this.Access_Workout);
        //        this.panelCreateWorkout.Location = new System.Drawing.Point(3, 145);
        //        this.panelCreateWorkout.Name = "panelCreateWorkout";
        //        this.panelCreateWorkout.Size = new System.Drawing.Size(187, 64);
        //        this.panelCreateWorkout.TabIndex = 4;
        //        // 
        //        // panelBook
        //        // 
        //        this.panelBook.Controls.Add(this.Create_Diet);
        //        this.panelBook.Location = new System.Drawing.Point(3, 215);
        //        this.panelBook.Name = "panelBook";
        //        this.panelBook.Size = new System.Drawing.Size(187, 64);
        //        this.panelBook.TabIndex = 5;
        //        // 
        //        // panelAccessDiet
        //        // 
        //        this.panelAccessDiet.Controls.Add(this.Access_Diet);
        //        this.panelAccessDiet.Location = new System.Drawing.Point(3, 285);
        //        this.panelAccessDiet.Name = "panelAccessDiet";
        //        this.panelAccessDiet.Size = new System.Drawing.Size(187, 57);
        //        this.panelAccessDiet.TabIndex = 7;
        //        // 
        //        // panelAccessWorkout
        //        // 
        //        this.panelAccessWorkout.Controls.Add(this.Booking);
        //        this.panelAccessWorkout.Location = new System.Drawing.Point(3, 348);
        //        this.panelAccessWorkout.Name = "panelAccessWorkout";
        //        this.panelAccessWorkout.Size = new System.Drawing.Size(187, 64);
        //        this.panelAccessWorkout.TabIndex = 6;
        //        // 
        //        // Sidebar_transition
        //        // 
        //        this.Sidebar_transition.Interval = 10;
        //        this.Sidebar_transition.Tick += new System.EventHandler(this.timer1_Tick);
        //        // 
        //        // Dashboard
        //        // 
        //        this.Dashboard.BackColor = System.Drawing.Color.Black;
        //        this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Dashboard.FlatAppearance.BorderSize = 0;
        //        this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Dashboard.ForeColor = System.Drawing.Color.White;
        //        this.Dashboard.Image = global::Member_Interface.Properties.Resources.icons8_dashboard_layout_241;
        //        this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Dashboard.Location = new System.Drawing.Point(-3, -3);
        //        this.Dashboard.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Dashboard.Name = "Dashboard";
        //        this.Dashboard.Size = new System.Drawing.Size(187, 64);
        //        this.Dashboard.TabIndex = 2;
        //        this.Dashboard.Text = "DASHBOARD";
        //        this.Dashboard.UseVisualStyleBackColor = false;
        //        this.Dashboard.Click += new System.EventHandler(this.button1_Click);
        //        // 
        //        // Create_Workout
        //        // 
        //        this.Create_Workout.BackColor = System.Drawing.Color.Black;
        //        this.Create_Workout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Create_Workout.FlatAppearance.BorderSize = 0;
        //        this.Create_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Create_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Create_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Create_Workout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Create_Workout.ForeColor = System.Drawing.Color.White;
        //        this.Create_Workout.Image = global::Member_Interface.Properties.Resources.icons8_workout_24;
        //        this.Create_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Create_Workout.Location = new System.Drawing.Point(0, -11);
        //        this.Create_Workout.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Create_Workout.Name = "Create_Workout";
        //        this.Create_Workout.Size = new System.Drawing.Size(187, 64);
        //        this.Create_Workout.TabIndex = 3;
        //        this.Create_Workout.Text = "CREATE \r\nWORKOUT\r\n";
        //        this.Create_Workout.UseVisualStyleBackColor = false;
        //        this.Create_Workout.Click += new System.EventHandler(this.button7_Click);
        //        // 
        //        // Access_Workout
        //        // 
        //        this.Access_Workout.BackColor = System.Drawing.Color.Black;
        //        this.Access_Workout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Access_Workout.FlatAppearance.BorderSize = 0;
        //        this.Access_Workout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Access_Workout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Access_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Access_Workout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Access_Workout.ForeColor = System.Drawing.Color.White;
        //        this.Access_Workout.Image = global::Member_Interface.Properties.Resources.icons8_access_24;
        //        this.Access_Workout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Access_Workout.Location = new System.Drawing.Point(0, -3);
        //        this.Access_Workout.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Access_Workout.Name = "Access_Workout";
        //        this.Access_Workout.Size = new System.Drawing.Size(187, 64);
        //        this.Access_Workout.TabIndex = 5;
        //        this.Access_Workout.Text = "ACCESS \r\nWORKOUT";
        //        this.Access_Workout.UseVisualStyleBackColor = false;
        //        this.Access_Workout.Click += new System.EventHandler(this.Access_Workout_Click);
        //        // 
        //        // Create_Diet
        //        // 
        //        this.Create_Diet.BackColor = System.Drawing.Color.Black;
        //        this.Create_Diet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Create_Diet.FlatAppearance.BorderSize = 0;
        //        this.Create_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Create_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Create_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Create_Diet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Create_Diet.ForeColor = System.Drawing.Color.White;
        //        this.Create_Diet.Image = global::Member_Interface.Properties.Resources.icons8_create_24;
        //        this.Create_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Create_Diet.Location = new System.Drawing.Point(-3, -3);
        //        this.Create_Diet.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Create_Diet.Name = "Create_Diet";
        //        this.Create_Diet.Size = new System.Drawing.Size(187, 64);
        //        this.Create_Diet.TabIndex = 4;
        //        this.Create_Diet.Text = "CREATE \r\nDIET PLAN";
        //        this.Create_Diet.UseVisualStyleBackColor = false;
        //        this.Create_Diet.Click += new System.EventHandler(this.Create_Diet_Click);
        //        // 
        //        // Access_Diet
        //        // 
        //        this.Access_Diet.BackColor = System.Drawing.Color.Black;
        //        this.Access_Diet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Access_Diet.FlatAppearance.BorderSize = 0;
        //        this.Access_Diet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Access_Diet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Access_Diet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Access_Diet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Access_Diet.ForeColor = System.Drawing.Color.White;
        //        this.Access_Diet.Image = global::Member_Interface.Properties.Resources.icons8_cutlery_24;
        //        this.Access_Diet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Access_Diet.Location = new System.Drawing.Point(-3, -9);
        //        this.Access_Diet.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Access_Diet.Name = "Access_Diet";
        //        this.Access_Diet.Size = new System.Drawing.Size(190, 64);
        //        this.Access_Diet.TabIndex = 6;
        //        this.Access_Diet.Text = "ACCESS\r\nDIET PLANS";
        //        this.Access_Diet.UseVisualStyleBackColor = false;
        //        this.Access_Diet.Click += new System.EventHandler(this.Access_Diet_Click);
        //        // 
        //        // Booking
        //        // 
        //        this.Booking.BackColor = System.Drawing.Color.Black;
        //        this.Booking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.Booking.FlatAppearance.BorderSize = 0;
        //        this.Booking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.Booking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.Booking.ForeColor = System.Drawing.Color.White;
        //        this.Booking.Image = global::Member_Interface.Properties.Resources.icons8_booking_24;
        //        this.Booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.Booking.Location = new System.Drawing.Point(-3, -8);
        //        this.Booking.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.Booking.Name = "Booking";
        //        this.Booking.Size = new System.Drawing.Size(187, 64);
        //        this.Booking.TabIndex = 7;
        //        this.Booking.Text = "BOOKINGS";
        //        this.Booking.UseVisualStyleBackColor = false;
        //        this.Booking.Click += new System.EventHandler(this.Booking_Click);
        //        // 
        //        // button1
        //        // 
        //        this.button1.BackColor = System.Drawing.Color.Black;
        //        this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        //        this.button1.FlatAppearance.BorderSize = 0;
        //        this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
        //        this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
        //        this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //        this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.button1.ForeColor = System.Drawing.Color.White;
        //        this.button1.Image = global::Member_Interface.Properties.Resources.new_exit__1_;
        //        this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        this.button1.Location = new System.Drawing.Point(50, 415);
        //        this.button1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
        //        this.button1.Name = "button1";
        //        this.button1.Size = new System.Drawing.Size(187, 64);
        //        this.button1.TabIndex = 8;
        //        this.button1.Text = "EXIT";
        //        this.button1.UseVisualStyleBackColor = false;
        //        this.button1.Click += new System.EventHandler(this.button1_Click_1);
        //        // 
        //        // Handle_btn
        //        // 
        //        this.Handle_btn.Image = global::Member_Interface.Properties.Resources.menu1;
        //        this.Handle_btn.Location = new System.Drawing.Point(12, 12);
        //        this.Handle_btn.Name = "Handle_btn";
        //        this.Handle_btn.Size = new System.Drawing.Size(27, 27);
        //        this.Handle_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        //        this.Handle_btn.TabIndex = 1;
        //        this.Handle_btn.TabStop = false;
        //        this.Handle_btn.Click += new System.EventHandler(this.Handle_btn_Click);
        //        // 
        //        // panel2
        //        // 
        //        this.panel2.Controls.Add(this.pictureBox1);
        //        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        //        this.panel2.Location = new System.Drawing.Point(190, 49);
        //        this.panel2.Name = "panel2";
        //        this.panel2.Size = new System.Drawing.Size(881, 472);
        //        this.panel2.TabIndex = 3;
        //        // 
        //        // pictureBox1
        //        // 
        //        this.pictureBox1.BackgroundImage = global::Member_Interface.Properties.Resources.th;
        //        this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //        this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        //        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        //        this.pictureBox1.Name = "pictureBox1";
        //        this.pictureBox1.Size = new System.Drawing.Size(881, 472);
        //        this.pictureBox1.TabIndex = 0;
        //        this.pictureBox1.TabStop = false;
        //        this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
        //        // 
        //        // MEMBER
        //        // 
        //        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        //        this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
        //        this.ClientSize = new System.Drawing.Size(1071, 521);
        //        this.Controls.Add(this.panel2);
        //        this.Controls.Add(this.Sidebar);
        //        this.Controls.Add(this.panel1);
        //        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //        this.IsMdiContainer = true;
        //        this.Name = "MEMBER";
        //        this.Text = "GYM FLEX";
        //        this.Load += new System.EventHandler(this.MEMBER_Load);
        //        this.panel1.ResumeLayout(false);
        //        this.panel1.PerformLayout();
        //        this.Sidebar.ResumeLayout(false);
        //        this.panelDashboard.ResumeLayout(false);
        //        this.panelCreateDiet.ResumeLayout(false);
        //        this.panelCreateWorkout.ResumeLayout(false);
        //        this.panelBook.ResumeLayout(false);
        //        this.panelAccessDiet.ResumeLayout(false);
        //        this.panelAccessWorkout.ResumeLayout(false);
        //        ((System.ComponentModel.ISupportInitialize)(this.Handle_btn)).EndInit();
        //        this.panel2.ResumeLayout(false);
        //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        //        this.ResumeLayout(false);

        //    }

        //    #endregion

        //    private System.Windows.Forms.Panel panel1;
        //    private System.Windows.Forms.PictureBox Handle_btn;
        //    private System.Windows.Forms.Label label1;
        //    private System.Windows.Forms.FlowLayoutPanel Sidebar;
        //    private System.Windows.Forms.Button Dashboard;
        //    private System.Windows.Forms.Panel panelDashboard;
        //    private System.Windows.Forms.Panel panelCreateWorkout;
        //    private System.Windows.Forms.Panel panelCreateDiet;
        //    private System.Windows.Forms.Panel panelBook;
        //    private System.Windows.Forms.Panel panelAccessWorkout;
        //    private System.Windows.Forms.Panel panelAccessDiet;
        //    private System.Windows.Forms.Timer Sidebar_transition;
        //    private System.Windows.Forms.Button Create_Workout;
        //    private System.Windows.Forms.Button Create_Diet;
        //    private System.Windows.Forms.Button Access_Workout;
        //    private System.Windows.Forms.Button Access_Diet;
        //    private System.Windows.Forms.Button Booking;
        //    private System.Windows.Forms.Button button1;
        //    private System.Windows.Forms.Panel panel2;
        //    private System.Windows.Forms.PictureBox pictureBox1;
        //}
    }
}
#endregion