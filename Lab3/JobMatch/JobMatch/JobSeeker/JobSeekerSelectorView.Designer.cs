namespace JobMatch
{
    partial class JobSeekerSelectorView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.short_description = new System.Windows.Forms.TextBox();
            this.company_name = new System.Windows.Forms.TextBox();
            this.job_position = new System.Windows.Forms.TextBox();
            this.required_skills = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.education_place = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aditional_requirements = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Job Description";
            // 
            // short_description
            // 
            this.short_description.Location = new System.Drawing.Point(36, 121);
            this.short_description.Multiline = true;
            this.short_description.Name = "short_description";
            this.short_description.ReadOnly = true;
            this.short_description.Size = new System.Drawing.Size(291, 127);
            this.short_description.TabIndex = 3;
            // 
            // company_name
            // 
            this.company_name.Location = new System.Drawing.Point(143, 12);
            this.company_name.Multiline = true;
            this.company_name.Name = "company_name";
            this.company_name.ReadOnly = true;
            this.company_name.Size = new System.Drawing.Size(184, 22);
            this.company_name.TabIndex = 4;
            // 
            // job_position
            // 
            this.job_position.Location = new System.Drawing.Point(143, 55);
            this.job_position.Multiline = true;
            this.job_position.Name = "job_position";
            this.job_position.ReadOnly = true;
            this.job_position.Size = new System.Drawing.Size(184, 22);
            this.job_position.TabIndex = 5;
            // 
            // required_skills
            // 
            this.required_skills.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.required_skills.Location = new System.Drawing.Point(36, 287);
            this.required_skills.Name = "required_skills";
            this.required_skills.Size = new System.Drawing.Size(291, 97);
            this.required_skills.TabIndex = 6;
            this.required_skills.UseCompatibleStateImageBehavior = false;
            this.required_skills.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required Skills";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Education";
            // 
            // education_place
            // 
            this.education_place.Location = new System.Drawing.Point(103, 403);
            this.education_place.Name = "education_place";
            this.education_place.ReadOnly = true;
            this.education_place.Size = new System.Drawing.Size(224, 20);
            this.education_place.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aditional Requirements";
            // 
            // aditional_requirements
            // 
            this.aditional_requirements.Location = new System.Drawing.Point(36, 477);
            this.aditional_requirements.Multiline = true;
            this.aditional_requirements.Name = "aditional_requirements";
            this.aditional_requirements.ReadOnly = true;
            this.aditional_requirements.Size = new System.Drawing.Size(291, 127);
            this.aditional_requirements.TabIndex = 11;
            // 
            // JobSeekerSelectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aditional_requirements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.education_place);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.required_skills);
            this.Controls.Add(this.job_position);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.short_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobSeekerSelectorView";
            this.Size = new System.Drawing.Size(555, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox short_description;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.TextBox job_position;
        private System.Windows.Forms.ListView required_skills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox education_place;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aditional_requirements;
    }
}
