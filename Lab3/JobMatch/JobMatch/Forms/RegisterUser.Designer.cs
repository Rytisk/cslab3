namespace JobMatch
{
    partial class RegisterUser
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
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employer_rdbtn = new System.Windows.Forms.RadioButton();
            this.jobseeker_rdbtn = new System.Windows.Forms.RadioButton();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(77, 44);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(117, 20);
            this.username_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(76, 86);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(118, 20);
            this.password_box.TabIndex = 1;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(76, 128);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(118, 20);
            this.email_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // employer_rdbtn
            // 
            this.employer_rdbtn.AutoSize = true;
            this.employer_rdbtn.Location = new System.Drawing.Point(19, 192);
            this.employer_rdbtn.Name = "employer_rdbtn";
            this.employer_rdbtn.Size = new System.Drawing.Size(68, 17);
            this.employer_rdbtn.TabIndex = 7;
            this.employer_rdbtn.TabStop = true;
            this.employer_rdbtn.Text = "Employer";
            this.employer_rdbtn.UseVisualStyleBackColor = true;
            // 
            // jobseeker_rdbtn
            // 
            this.jobseeker_rdbtn.AutoSize = true;
            this.jobseeker_rdbtn.Location = new System.Drawing.Point(193, 192);
            this.jobseeker_rdbtn.Name = "jobseeker_rdbtn";
            this.jobseeker_rdbtn.Size = new System.Drawing.Size(79, 17);
            this.jobseeker_rdbtn.TabIndex = 8;
            this.jobseeker_rdbtn.TabStop = true;
            this.jobseeker_rdbtn.Text = "Job Seeker";
            this.jobseeker_rdbtn.UseVisualStyleBackColor = true;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(100, 230);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.jobseeker_rdbtn);
            this.Controls.Add(this.employer_rdbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton employer_rdbtn;
        private System.Windows.Forms.RadioButton jobseeker_rdbtn;
        private System.Windows.Forms.Button register_btn;
    }
}