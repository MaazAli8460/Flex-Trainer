namespace Flex_Trainer
{
    partial class report2
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GymName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.f,
            this.Ln,
            this.G,
            this.Add,
            this.PhoneNO,
            this.UID,
            this.PlanID,
            this.PlanName,
            this.GymName});
            this.dataGridView1.Location = new System.Drawing.Point(68, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // f
            // 
            this.f.HeaderText = "Fname";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.Width = 125;
            // 
            // Ln
            // 
            this.Ln.HeaderText = "LName";
            this.Ln.MinimumWidth = 6;
            this.Ln.Name = "Ln";
            this.Ln.Width = 125;
            // 
            // G
            // 
            this.G.HeaderText = "Gender";
            this.G.MinimumWidth = 6;
            this.G.Name = "G";
            this.G.Width = 125;
            // 
            // Add
            // 
            this.Add.HeaderText = "Address";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Width = 125;
            // 
            // PhoneNO
            // 
            this.PhoneNO.HeaderText = "Phone";
            this.PhoneNO.MinimumWidth = 6;
            this.PhoneNO.Name = "PhoneNO";
            this.PhoneNO.Width = 125;
            // 
            // UID
            // 
            this.UID.HeaderText = "UserID";
            this.UID.MinimumWidth = 6;
            this.UID.Name = "UID";
            this.UID.Width = 125;
            // 
            // PlanID
            // 
            this.PlanID.HeaderText = "PlanID";
            this.PlanID.MinimumWidth = 6;
            this.PlanID.Name = "PlanID";
            this.PlanID.Width = 125;
            // 
            // PlanName
            // 
            this.PlanName.HeaderText = "PlanName";
            this.PlanName.MinimumWidth = 6;
            this.PlanName.Name = "PlanName";
            this.PlanName.Width = 125;
            // 
            // GymName
            // 
            this.GymName.HeaderText = "Gym";
            this.GymName.MinimumWidth = 6;
            this.GymName.Name = "GymName";
            this.GymName.Width = 125;
            // 
            // report2
            // 
            this.ClientSize = new System.Drawing.Size(994, 473);
            this.Controls.Add(this.dataGridView1);
            this.Name = "report2";
            this.Load += new System.EventHandler(this.report2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GymName;
    }
}