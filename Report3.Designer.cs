namespace Flex_Trainer
{
    partial class report3
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.f,
            this.Ln,
            this.G,
            this.Add,
            this.PhoneNO,
            this.UID,
            this.PlanID,
            this.PlanName});
            this.dataGridView2.Location = new System.Drawing.Point(48, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(880, 401);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.UID.HeaderText = "UName";
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
            // report3
            // 
            this.ClientSize = new System.Drawing.Size(1039, 417);
            this.Controls.Add(this.dataGridView2);
            this.Name = "report3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
    }
}