namespace Flex_Trainer
{
    partial class report9
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
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.GID,
            this.JDate,
            this.Gname,
            this.Fname,
            this.lname});
            this.dataGridView1.Location = new System.Drawing.Point(57, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UID
            // 
            this.UID.HeaderText = "ID";
            this.UID.MinimumWidth = 6;
            this.UID.Name = "UID";
            this.UID.Width = 125;
            // 
            // GID
            // 
            this.GID.HeaderText = "GYMID";
            this.GID.MinimumWidth = 6;
            this.GID.Name = "GID";
            this.GID.Width = 125;
            // 
            // JDate
            // 
            this.JDate.HeaderText = "JoinDate";
            this.JDate.MinimumWidth = 6;
            this.JDate.Name = "JDate";
            this.JDate.Width = 125;
            // 
            // Gname
            // 
            this.Gname.HeaderText = "GymName";
            this.Gname.MinimumWidth = 6;
            this.Gname.Name = "Gname";
            this.Gname.Width = 125;
            // 
            // Fname
            // 
            this.Fname.HeaderText = "FName";
            this.Fname.MinimumWidth = 6;
            this.Fname.Name = "Fname";
            this.Fname.Width = 125;
            // 
            // lname
            // 
            this.lname.HeaderText = "LName";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.Width = 125;
            // 
            // report9
            // 
            this.ClientSize = new System.Drawing.Size(997, 430);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report9";
            this.Load += new System.EventHandler(this.report9_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    }
}