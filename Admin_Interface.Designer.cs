namespace Flex_Trainer
{
    partial class Admin_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Interface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HNDL_btn = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Performance_Gyms = new System.Windows.Forms.Button();
            this.Approve = new System.Windows.Forms.Button();
            this.Revoke = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Main_Admin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.Main_Admin.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(907, 52);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADMIN";
            // 
            // HNDL_btn
            // 
            this.HNDL_btn.BackColor = System.Drawing.Color.Transparent;
            this.HNDL_btn.BackgroundImage = global::Flex_Trainer.Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Bars_48;
            this.HNDL_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HNDL_btn.Location = new System.Drawing.Point(12, 12);
            this.HNDL_btn.Name = "HNDL_btn";
            this.HNDL_btn.Size = new System.Drawing.Size(36, 38);
            this.HNDL_btn.TabIndex = 5;
            this.HNDL_btn.TabStop = false;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sidebar.Controls.Add(this.Performance_Gyms);
            this.Sidebar.Controls.Add(this.Approve);
            this.Sidebar.Controls.Add(this.Revoke);
            this.Sidebar.Controls.Add(this.Report);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 52);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(222, 463);
            this.Sidebar.TabIndex = 8;
            // 
            // Performance_Gyms
            // 
            this.Performance_Gyms.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Performance_Gyms.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Performance_Gyms.FlatAppearance.BorderSize = 0;
            this.Performance_Gyms.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Performance_Gyms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Performance_Gyms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Performance_Gyms.Image = global::Flex_Trainer.Properties.Resources.icons8_access_241;
            this.Performance_Gyms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Performance_Gyms.Location = new System.Drawing.Point(3, 3);
            this.Performance_Gyms.Name = "Performance_Gyms";
            this.Performance_Gyms.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Performance_Gyms.Size = new System.Drawing.Size(217, 60);
            this.Performance_Gyms.TabIndex = 7;
            this.Performance_Gyms.Text = "PERFORMANCE\r\nGYMS\r\n";
            this.Performance_Gyms.UseVisualStyleBackColor = false;
            this.Performance_Gyms.Click += new System.EventHandler(this.Performance_Gyms_Click);
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Approve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Approve.FlatAppearance.BorderSize = 0;
            this.Approve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Approve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approve.Image = global::Flex_Trainer.Properties.Resources.icons8_create_242;
            this.Approve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Approve.Location = new System.Drawing.Point(3, 69);
            this.Approve.Name = "Approve";
            this.Approve.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Approve.Size = new System.Drawing.Size(217, 60);
            this.Approve.TabIndex = 11;
            this.Approve.Text = "APPROVE\r\nGYMS\r\n\r\n";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Revoke
            // 
            this.Revoke.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Revoke.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Revoke.FlatAppearance.BorderSize = 0;
            this.Revoke.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Revoke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Revoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Revoke.Image = global::Flex_Trainer.Properties.Resources.icons8_booking_244;
            this.Revoke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Revoke.Location = new System.Drawing.Point(3, 135);
            this.Revoke.Name = "Revoke";
            this.Revoke.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Revoke.Size = new System.Drawing.Size(217, 60);
            this.Revoke.TabIndex = 10;
            this.Revoke.Text = "REVOKE\r\nMEMBERSHIP\r\n";
            this.Revoke.UseVisualStyleBackColor = false;
            this.Revoke.Click += new System.EventHandler(this.Revoke_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Report.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Image = global::Flex_Trainer.Properties.Resources.icons8_gym_162;
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(3, 201);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Report.Size = new System.Drawing.Size(217, 60);
            this.Report.TabIndex = 9;
            this.Report.Text = "REPORTS\r\n\r\n";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Main_Admin
            // 
            this.Main_Admin.BackgroundImage = global::Flex_Trainer.Properties.Resources.pexels_victorfreitas_22614771;
            this.Main_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Admin.Controls.Add(this.panel2);
            this.Main_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Admin.Location = new System.Drawing.Point(222, 52);
            this.Main_Admin.Name = "Main_Admin";
            this.Main_Admin.Size = new System.Drawing.Size(685, 463);
            this.Main_Admin.TabIndex = 10;
            this.Main_Admin.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Admin_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(19, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 100);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "FLEX TRAINER - ADMIN INTERFACE";
            // 
            // Admin_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 515);
            this.Controls.Add(this.Main_Admin);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Admin_Interface";
            this.Text = "Admin_Interface";
            this.Load += new System.EventHandler(this.Admin_Interface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HNDL_btn)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Main_Admin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HNDL_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Performance_Gyms;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Revoke;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Panel Main_Admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}