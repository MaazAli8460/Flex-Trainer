namespace Flex_Trainer
{
    partial class report19
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Gym,
            this.Loc,
            this.sat});
            this.dataGridView1.Location = new System.Drawing.Point(84, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Gym
            // 
            this.Gym.HeaderText = "Gym";
            this.Gym.MinimumWidth = 6;
            this.Gym.Name = "Gym";
            this.Gym.Width = 125;
            // 
            // Loc
            // 
            this.Loc.HeaderText = "Location";
            this.Loc.MinimumWidth = 6;
            this.Loc.Name = "Loc";
            this.Loc.Width = 125;
            // 
            // sat
            // 
            this.sat.HeaderText = "CusSatisfaction";
            this.sat.MinimumWidth = 6;
            this.sat.Name = "sat";
            this.sat.Width = 125;
            // 
            // report19
            // 
            this.ClientSize = new System.Drawing.Size(880, 413);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report19";
            this.Load += new System.EventHandler(this.report19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gym;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
    }
}