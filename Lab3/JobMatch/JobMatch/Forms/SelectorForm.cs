﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobMatch.Database;
using System.Diagnostics;

namespace JobMatch
{
    public partial class SelectorForm : Form
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\databse\FindJobDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework";
        JobSeekerSelectorView _jobSeekerControl;
        EmployerSelectorView _employerControl;
        List<JobSeeker> _jobSeekers;
        List<Job> _jobs;
        DBHandler dbhandler = new DBHandler();
        private int employerIndex = 0;
        private int jobSeekerIndex = 0;
        //  List<EmployerDataSelector> employers;
        Type _userType;

        public SelectorForm(Type userType)
        {
            _userType = userType;
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
           
            if(_userType == Type.JobSeeker)
            {
                _jobSeekerControl = new JobSeekerSelectorView();
                panel1.Controls.Add(_jobSeekerControl);
                _jobSeekerControl.RequiredSkills.Columns.Add("Skill", 140);

                JobController jcontr = new JobController();
                _jobs = jcontr.GetJobs();
                JobSeekersView();

            }
            else if(_userType == Type.Employer)
            {
                _employerControl = new EmployerSelectorView();
                panel1.Controls.Add(_employerControl);
                _employerControl.Skills.Columns.Add("Skill", 140);

                JobSeekerController jscontr = new JobSeekerController();
                _jobSeekers = jscontr.GetJobSeekers();
                EmployersView();
            }
            

        }

        private void EmployersView()
        {
            try
            {
                var jobSeeker = _jobSeekers.Take(1).Single();
                _employerControl.JobSeekerName = string.Format("{0} {1}", jobSeeker.Profile.FirstName, jobSeeker.Profile.LastName);
                _employerControl.ContactData = jobSeeker.Profile.ContactData;
                _employerControl.ShortDescription = jobSeeker.Profile.ShortDescription;
                _employerControl.WorkExperience = jobSeeker.Profile.WorkExperience;
                _employerControl.Education = jobSeeker.Profile.Education;

                string query = string.Format("select skill from skill where profile_Id = '{0}'", jobSeeker.Profile.JobSeeker_Id);
                var skills = dbhandler.ReadQuery(query, _connectionString);
                foreach (DataRow row in skills.Rows)
                {
                    string skill = row["skill"].ToString();
                    _employerControl.Skills.Items.Add(new ListViewItem(skill));
                }
                _jobSeekers = _jobSeekers.Skip(1).ToList();
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
                MessageBox.Show("No more Job Seekers!");
                Dispose();
            }
            
        }

        private void JobSeekersView()
        {
            try
            {
                var job = _jobs.Take(1).Single();
                _jobSeekerControl.NameOfCompany = job.Name;
                _jobSeekerControl.JobPosition = job.Position;
                _jobSeekerControl.ShortJobDescription = job.JobDescription;
                _jobSeekerControl.Education = job.EducationRequirements;
                _jobSeekerControl.AditionalRequirements = job.AditionalRequirements;

                string query = string.Format("select skill from RequiredSkill where job_Id = '{0}'", job.Id);
                var reqskills = dbhandler.ReadQuery(query, _connectionString);
                foreach (DataRow row in reqskills.Rows)
                {
                    string skill = row["skill"].ToString();
                    _jobSeekerControl.RequiredSkills.Items.Add(new ListViewItem(skill));
                }

                _jobs = _jobs.Skip(1).ToList();
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
                MessageBox.Show("No more Jobs!");
                Dispose();
            }
            

        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            if (_userType == Type.Employer)
            {
                ResetEmployerViewFields();
                EmployersView();
            }
            if(_userType == Type.JobSeeker)
            {
                ResetJobSeekerViewFields();
                JobSeekersView();
            }
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            if (_userType == Type.Employer)
            {
                ResetEmployerViewFields();
                EmployersView();
            }
            if (_userType == Type.JobSeeker)
            {
                ResetJobSeekerViewFields();
                JobSeekersView();
            }
        }

        private void ResetEmployerViewFields()
        {
            _employerControl.JobSeekerName = null;
            _employerControl.ContactData = null;
            _employerControl.ShortDescription = null;
            _employerControl.WorkExperience = null;
            _employerControl.Education = null;
            _employerControl.Skills.Items.Clear();
        }

        private void ResetJobSeekerViewFields()
        {
            _jobSeekerControl.NameOfCompany = null;
            _jobSeekerControl.JobPosition = null;
            _jobSeekerControl.ShortJobDescription = null;
            _jobSeekerControl.Education = null;
            _jobSeekerControl.AditionalRequirements = null;
            _jobSeekerControl.RequiredSkills.Items.Clear();
        }
    }
}
