namespace JobMatch
{
    partial class MyJobsForm
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
            this.add_job_btn = new System.Windows.Forms.Button();
            this.job_txt_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_btn_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_btn_column = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.job_txt_column,
            this.edit_btn_column,
            this.delete_btn_column});
            this.dataGridView1.Location = new System.Drawing.Point(73, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(353, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_job_btn
            // 
            this.add_job_btn.Location = new System.Drawing.Point(172, 455);
            this.add_job_btn.Name = "add_job_btn";
            this.add_job_btn.Size = new System.Drawing.Size(126, 23);
            this.add_job_btn.TabIndex = 1;
            this.add_job_btn.Text = "Add a new Job";
            this.add_job_btn.UseVisualStyleBackColor = true;
            this.add_job_btn.Click += new System.EventHandler(this.add_job_btn_Click);
            // 
            // job_txt_column
            // 
            this.job_txt_column.HeaderText = "Position";
            this.job_txt_column.Name = "job_txt_column";
            this.job_txt_column.ReadOnly = true;
            this.job_txt_column.Width = 200;
            // 
            // edit_btn_column
            // 
            this.edit_btn_column.HeaderText = "";
            this.edit_btn_column.Name = "edit_btn_column";
            this.edit_btn_column.Text = "Edit";
            this.edit_btn_column.Width = 50;
            // 
            // delete_btn_column
            // 
            this.delete_btn_column.HeaderText = "";
            this.delete_btn_column.Name = "delete_btn_column";
            this.delete_btn_column.Text = "Delete";
            this.delete_btn_column.Width = 80;
            // 
            // MyJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 505);
            this.Controls.Add(this.add_job_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyJobsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_job_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_txt_column;
        private System.Windows.Forms.DataGridViewButtonColumn edit_btn_column;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn_column;
    }
}