namespace JobMatch
{
    partial class RatedEmployees
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
            this.job_position_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobseeker_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.your_rate_column = new System.Windows.Forms.DataGridViewImageColumn();
            this.jobseeker_rate_column = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.job_position_column,
            this.jobseeker_column,
            this.your_rate_column,
            this.jobseeker_rate_column});
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(422, 401);
            this.dataGridView1.TabIndex = 1;
            // 
            // job_position_column
            // 
            this.job_position_column.HeaderText = "Job Position";
            this.job_position_column.Name = "job_position_column";
            // 
            // jobseeker_column
            // 
            this.jobseeker_column.HeaderText = "Job Seeker";
            this.jobseeker_column.Name = "jobseeker_column";
            // 
            // your_rate_column
            // 
            this.your_rate_column.HeaderText = "Your Rate";
            this.your_rate_column.Name = "your_rate_column";
            this.your_rate_column.ReadOnly = true;
            // 
            // jobseeker_rate_column
            // 
            this.jobseeker_rate_column.HeaderText = "Job Seeker\'s Rate";
            this.jobseeker_rate_column.Name = "jobseeker_rate_column";
            this.jobseeker_rate_column.ReadOnly = true;
            // 
            // RatedEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 489);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RatedEmployees";
            this.Text = "RatedEmployees";
            this.Load += new System.EventHandler(this.RatedEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_position_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobseeker_column;
        private System.Windows.Forms.DataGridViewImageColumn your_rate_column;
        private System.Windows.Forms.DataGridViewImageColumn jobseeker_rate_column;
    }
}