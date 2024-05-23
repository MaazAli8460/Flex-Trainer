namespace Flex_Trainer
{
    partial class report18
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
            this.loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Growth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Gym,
            this.loc,
            this.Growth});
            this.dataGridView1.Location = new System.Drawing.Point(140, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // loc
            // 
            this.loc.HeaderText = "Location";
            this.loc.MinimumWidth = 6;
            this.loc.Name = "loc";
            this.loc.Width = 125;
            // 
            // Growth
            // 
            this.Growth.HeaderText = "Growth";
            this.Growth.MinimumWidth = 6;
            this.Growth.Name = "Growth";
            this.Growth.Width = 125;
            // 
            // report18
            // 
            this.ClientSize = new System.Drawing.Size(929, 404);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report18";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gym;
        private System.Windows.Forms.DataGridViewTextBoxColumn loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Growth;
    }
}