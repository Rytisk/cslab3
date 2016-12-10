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
            this.short_description_box = new System.Windows.Forms.TextBox();
            this.company_name_box = new System.Windows.Forms.TextBox();
            this.job_position_box = new System.Windows.Forms.TextBox();
            this.required_skills_listview = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.education_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aditional_requirements_box = new System.Windows.Forms.TextBox();
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
            // short_description_box
            // 
            this.short_description_box.Location = new System.Drawing.Point(36, 121);
            this.short_description_box.Multiline = true;
            this.short_description_box.Name = "short_description_box";
            this.short_description_box.ReadOnly = true;
            this.short_description_box.Size = new System.Drawing.Size(291, 127);
            this.short_description_box.TabIndex = 3;
            // 
            // company_name_box
            // 
            this.company_name_box.Location = new System.Drawing.Point(143, 12);
            this.company_name_box.Multiline = true;
            this.company_name_box.Name = "company_name_box";
            this.company_name_box.ReadOnly = true;
            this.company_name_box.Size = new System.Drawing.Size(184, 22);
            this.company_name_box.TabIndex = 4;
            // 
            // job_position_box
            // 
            this.job_position_box.Location = new System.Drawing.Point(143, 55);
            this.job_position_box.Multiline = true;
            this.job_position_box.Name = "job_position_box";
            this.job_position_box.ReadOnly = true;
            this.job_position_box.Size = new System.Drawing.Size(184, 22);
            this.job_position_box.TabIndex = 5;
            // 
            // required_skills_listview
            // 
            this.required_skills_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.required_skills_listview.Location = new System.Drawing.Point(36, 287);
            this.required_skills_listview.Name = "required_skills_listview";
            this.required_skills_listview.Size = new System.Drawing.Size(291, 97);
            this.required_skills_listview.TabIndex = 6;
            this.required_skills_listview.UseCompatibleStateImageBehavior = false;
            this.required_skills_listview.View = System.Windows.Forms.View.Details;
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
            // education_box
            // 
            this.education_box.Location = new System.Drawing.Point(103, 403);
            this.education_box.Name = "education_box";
            this.education_box.ReadOnly = true;
            this.education_box.Size = new System.Drawing.Size(224, 20);
            this.education_box.TabIndex = 9;
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
            // aditional_requirements_box
            // 
            this.aditional_requirements_box.Location = new System.Drawing.Point(36, 477);
            this.aditional_requirements_box.Multiline = true;
            this.aditional_requirements_box.Name = "aditional_requirements_box";
            this.aditional_requirements_box.ReadOnly = true;
            this.aditional_requirements_box.Size = new System.Drawing.Size(291, 127);
            this.aditional_requirements_box.TabIndex = 11;
            // 
            // JobSeekerSelectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aditional_requirements_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.education_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.required_skills_listview);
            this.Controls.Add(this.job_position_box);
            this.Controls.Add(this.company_name_box);
            this.Controls.Add(this.short_description_box);
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
        private System.Windows.Forms.TextBox short_description_box;
        private System.Windows.Forms.TextBox company_name_box;
        private System.Windows.Forms.TextBox job_position_box;
        private System.Windows.Forms.ListView required_skills_listview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox education_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aditional_requirements_box;
    }
}
