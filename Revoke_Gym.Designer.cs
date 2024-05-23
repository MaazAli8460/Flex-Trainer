namespace Flex_Trainer
{
    partial class Revoke_Gym
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OWNER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GYM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REVOKE = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OWNER_NAME,
            this.GYM_NAME,
            this.REVOKE});
            this.dataGridView1.Location = new System.Drawing.Point(91, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 296);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(91, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 83);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "REVOKE GYM MEMBERSHIP";
            // 
            // OWNER_NAME
            // 
            this.OWNER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OWNER_NAME.HeaderText = "GYM NAME";
            this.OWNER_NAME.MinimumWidth = 6;
            this.OWNER_NAME.Name = "OWNER_NAME";
            // 
            // GYM_NAME
            // 
            this.GYM_NAME.HeaderText = "LOCATION";
            this.GYM_NAME.MinimumWidth = 6;
            this.GYM_NAME.Name = "GYM_NAME";
            this.GYM_NAME.Width = 125;
            // 
            // REVOKE
            // 
            this.REVOKE.HeaderText = "REVOKE";
            this.REVOKE.MinimumWidth = 6;
            this.REVOKE.Name = "REVOKE";
            this.REVOKE.Width = 125;
            // 
            // Revoke_Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flex_Trainer.Properties.Resources.risen_wang_20jX9b35r_M_unsplash3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Revoke_Gym";
            this.Text = "Revoke_Gym";
            this.Load += new System.EventHandler(this.Revoke_Gym_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OWNER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GYM_NAME;
        private System.Windows.Forms.DataGridViewButtonColumn REVOKE;
    }
}