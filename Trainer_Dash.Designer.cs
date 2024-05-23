namespace Flex_Trainer
{
    //partial class Trainer_Dash
    //{
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
    //        this.SuspendLayout();
    //        // 
    //        // Trainer_Dash
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(800, 450);
    //        this.Name = "Trainer_Dash";
    //        this.Text = "Trainer_Dash";
    //        this.Load += new System.EventHandler(this.Trainer_Dash_Load);
    //        this.ResumeLayout(false);

    //    }

    //    #endregion
    //}
    partial class Trainer_Dash
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.T_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.DataGridViewButtonColumn();
            this.feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_ID,
            this.T_name,
            this.Appointments,
            this.report,
            this.feedback});
            this.dataGridView1.Location = new System.Drawing.Point(126, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 242);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // T_ID
            // 
            this.T_ID.HeaderText = "Trainer ID";
            this.T_ID.MinimumWidth = 6;
            this.T_ID.Name = "T_ID";
            this.T_ID.Width = 125;
            // 
            // T_name
            // 
            this.T_name.HeaderText = "Trainer Name";
            this.T_name.MinimumWidth = 6;
            this.T_name.Name = "T_name";
            this.T_name.Width = 125;
            // 
            // Appointments
            // 
            this.Appointments.HeaderText = "Number of Appointments";
            this.Appointments.MinimumWidth = 6;
            this.Appointments.Name = "Appointments";
            this.Appointments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Appointments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Appointments.Width = 125;
            // 
            // report
            // 
            this.report.HeaderText = "View Report";
            this.report.MinimumWidth = 6;
            this.report.Name = "report";
            this.report.Width = 125;
            // 
            // feedback
            // 
            this.feedback.HeaderText = "View Feedback";
            this.feedback.MinimumWidth = 6;
            this.feedback.Name = "feedback";
            this.feedback.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(126, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 68);
            this.panel1.TabIndex = 4;
            // 
            // Trainer_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Flex_Trainer.Properties.Resources.pexels_pixabay_2604471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainer_Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Dashboard";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointments;
        private System.Windows.Forms.DataGridViewButtonColumn report;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedback;
        private System.Windows.Forms.Panel panel1;
    }
}