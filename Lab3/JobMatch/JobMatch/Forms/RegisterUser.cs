﻿using System;
using System.Windows.Forms;
using JobMatch.Database;

namespace JobMatch
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
           
            if (employer_rdbtn.Checked)
            {
                Employer emp = new Employer()
                {
                    Username = username_box.Text,
                    Password = password_box.Text,
                    Email = email_box.Text
                };
                EmployerController empController = new EmployerController();
                empController.Insert(emp);
                Dispose();

            }
            else if (jobseeker_rdbtn.Checked)
            {
                JobSeeker jobSeeker = new JobSeeker()
                {
                    Username = username_box.Text,
                    Password = password_box.Text,
                    Email = email_box.Text
                };
                JobSeekerController jobSeekerController = new JobSeekerController();
                jobSeekerController.Insert(jobSeeker);
                Dispose();
            }
            else
            {
                MessageBox.Show("Please select a type");
            }
            
        }
    }
}
