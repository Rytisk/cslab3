namespace JobMatch
{
    partial class JobRegistration
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
            this.job_position_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.short_description_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skills_checklist = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.education_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aditional_requirements_box = new System.Windows.Forms.TextBox();
            this.upload_job_btn = new System.Windows.Forms.Button();
            this.company_name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // job_position_box
            // 
            this.job_position_box.Location = new System.Drawing.Point(115, 12);
            this.job_position_box.Multiline = true;
            this.job_position_box.Name = "job_position_box";
            this.job_position_box.Size = new System.Drawing.Size(242, 22);
            this.job_position_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Short Job Description";
            // 
            // short_description_box
            // 
            this.short_description_box.Location = new System.Drawing.Point(30, 124);
            this.short_description_box.Multiline = true;
            this.short_description_box.Name = "short_description_box";
            this.short_description_box.Size = new System.Drawing.Size(327, 127);
            this.short_description_box.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Required Skills";
            // 
            // skills_checklist
            // 
            this.skills_checklist.FormattingEnabled = true;
            this.skills_checklist.Items.AddRange(new object[] {
            "C# and .NET",
            "Java",
            "SQL",
            "C++",
            "HTML",
            "JavaScript",
            "CSS",
            "C",
            "Agile",
            "ASP.Net"});
            this.skills_checklist.Location = new System.Drawing.Point(30, 279);
            this.skills_checklist.Name = "skills_checklist";
            this.skills_checklist.Size = new System.Drawing.Size(327, 109);
            this.skills_checklist.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Education";
            // 
            // education_box
            // 
            this.education_box.Location = new System.Drawing.Point(97, 406);
            this.education_box.Name = "education_box";
            this.education_box.Size = new System.Drawing.Size(260, 20);
            this.education_box.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Aditional Requirements";
            // 
            // aditional_requirements_box
            // 
            this.aditional_requirements_box.Location = new System.Drawing.Point(30, 467);
            this.aditional_requirements_box.Multiline = true;
            this.aditional_requirements_box.Name = "aditional_requirements_box";
            this.aditional_requirements_box.Size = new System.Drawing.Size(327, 127);
            this.aditional_requirements_box.TabIndex = 15;
            // 
            // upload_job_btn
            // 
            this.upload_job_btn.Location = new System.Drawing.Point(147, 609);
            this.upload_job_btn.Name = "upload_job_btn";
            this.upload_job_btn.Size = new System.Drawing.Size(137, 23);
            this.upload_job_btn.TabIndex = 16;
            this.upload_job_btn.Text = "Upload A Job";
            this.upload_job_btn.UseVisualStyleBackColor = true;
            this.upload_job_btn.Click += new System.EventHandler(this.upload_job_btn_Click);
            // 
            // company_name_box
            // 
            this.company_name_box.Location = new System.Drawing.Point(115, 63);
            this.company_name_box.Multiline = true;
            this.company_name_box.Name = "company_name_box";
            this.company_name_box.Size = new System.Drawing.Size(242, 22);
            this.company_name_box.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Company Name";
            // 
            // JobRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.company_name_box);
            this.Controls.Add(this.upload_job_btn);
            this.Controls.Add(this.aditional_requirements_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.education_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skills_checklist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.short_description_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.job_position_box);
            this.Name = "JobRegistration";
            this.Text = "JobRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox job_position_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox short_description_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox skills_checklist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox education_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aditional_requirements_box;
        private System.Windows.Forms.Button upload_job_btn;
        private System.Windows.Forms.TextBox company_name_box;
        private System.Windows.Forms.Label label2;
    }
}