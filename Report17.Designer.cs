namespace Flex_Trainer
{
    partial class report17
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
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(257, 139);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRevenue.TabIndex = 0;
            // 
            // report17
            // 
            this.ClientSize = new System.Drawing.Size(304, 64);
            this.Controls.Add(this.lblTotalRevenue);
            this.Name = "report17";
            this.Load += new System.EventHandler(this.report17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRevenue;
    }
}