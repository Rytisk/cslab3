﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JobMatch.Database;
using System.Diagnostics;

namespace JobMatch
{
    public partial class SelectorForm : Form
    {
        JobSeekerSelectorView _jobSeekerControl;
        EmployerSelectorView _employerControl;
        List<JobSeeker> _jobSeekers;
        List<Job> _jobs;
        Type _userType;
        Job _job;
        JobSeeker _jobSeeker;
        private int _myId;

        public SelectorForm(Type userType, int Id)
        {
            _userType = userType;
            _myId = Id;
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
                EmployerRatesController empRatesContr = new EmployerRatesController();
                while (empRatesContr.ExistsRate(_myId, _jobSeekers.Take(1).Single().Id))
                {
                    _jobSeekers = _jobSeekers.Skip(1).ToList();
                }
                _jobSeeker = _jobSeekers.Take(1).Single();

                _employerControl.JobSeekerName = string.Format("{0} {1}", _jobSeeker.Profile.FirstName, _jobSeeker.Profile.LastName);
                _employerControl.ContactData = _jobSeeker.Profile.ContactData;
                _employerControl.ShortDescription = _jobSeeker.Profile.ShortDescription;
                _employerControl.WorkExperience = _jobSeeker.Profile.WorkExperience;
                _employerControl.Education = _jobSeeker.Profile.Education;

                SkillController skillController = new SkillController();
                var skills = skillController.GetSkills(_jobSeeker.Profile.JobSeeker_Id);
                foreach (Skill skill in skills)
                {
                    _employerControl.Skills.Items.Add(new ListViewItem(skill.Skill1));
                }


                JobController jobController = new JobController();
                var jobs = jobController.GetJobs().Where(x=> x.Employer_Id == _myId);

                foreach(Job j in jobs)
                {
                    _employerControl.Positions.Items.Add(j); 
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
                JobSeekerRatesController jobSeekerRatesContr = new JobSeekerRatesController();
                while (jobSeekerRatesContr.ExistsRate(_myId, _jobs.Take(1).Single().Id))
                {
                    _jobs = _jobs.Skip(1).ToList();
                }
                _job = _jobs.Take(1).Single();
                _jobSeekerControl.NameOfCompany = _job.Name;
                _jobSeekerControl.JobPosition = _job.Position;
                _jobSeekerControl.ShortJobDescription = _job.JobDescription;
                _jobSeekerControl.Education = _job.EducationRequirements;
                _jobSeekerControl.AditionalRequirements = _job.AditionalRequirements;

                RequiredSkillController reqSkillController = new RequiredSkillController();
                var skills = reqSkillController.GetRequiredSkills(_job.Id);
                foreach(RequiredSkill skill in skills)
                {
                    _jobSeekerControl.RequiredSkills.Items.Add(new ListViewItem(skill.Skill));
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
                EmployerRatesController rateController = new EmployerRatesController();
                EmployerController employerController = new EmployerController();
                Employer emp = employerController.Select(_myId);

                var jobs = _employerControl.Positions.Items;

                foreach (Job j in jobs)
                {
                    EmployerRates rate = null;
                    if (_employerControl.Positions.CheckedItems.Contains(j))
                    {
                        rate = new EmployerRates()
                        {
                            Employer_Id = _myId,
                            JobSeeker_Id = _jobSeeker.Id,
                            Job_Id = j.Id,
                            Rate = true
                        };
                    }
                    else
                    {
                        rate = new EmployerRates()
                        {
                            Employer_Id = _myId,
                            JobSeeker_Id = _jobSeeker.Id,
                            Job_Id = j.Id,
                            Rate = false
                        };
                    }
                    rateController.Insert(rate);
                }

                ResetEmployerViewFields();
                EmployersView();
            }
            if(_userType == Type.JobSeeker)
            {
                JobSeekerRatesController rateController = new JobSeekerRatesController();
                JobSeekerController jobSeekerController = new JobSeekerController();
                JobSeeker jobSeeker = jobSeekerController.Select(_myId);
                JobSeekerRates rate = new JobSeekerRates()
                {
                    JobSeeker_Id = _myId,
                    Job_Id = _job.Id,
                    Rate = true
                };
                rateController.Insert(rate);
                ResetJobSeekerViewFields();
                JobSeekersView();
            }
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            if (_userType == Type.Employer)
            {
                EmployerRatesController rateController = new EmployerRatesController();
                EmployerController employerController = new EmployerController();
                Employer emp = employerController.Select(_myId);
                
                var jobs = _employerControl.Positions.Items;
                foreach(Job j in jobs)
                {
                    EmployerRates rate = new EmployerRates()
                    {
                        Employer_Id = _myId,
                        JobSeeker_Id = _jobSeeker.Id,
                        Job_Id = j.Id,
                        Rate = false
                    };
                    rateController.Insert(rate);
                }
                ResetEmployerViewFields();
                EmployersView();
            }
            if (_userType == Type.JobSeeker)
            {
                JobSeekerRatesController rateController = new JobSeekerRatesController();
                JobSeekerController jobSeekerController = new JobSeekerController();
                JobSeeker jobSeeker = jobSeekerController.Select(_myId);
                JobSeekerRates rate = new JobSeekerRates()
                {
                    JobSeeker_Id = _myId,
                    Job_Id = _job.Id,
                    Rate = false
                };
                rateController.Insert(rate);
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
            _employerControl.Positions.Items.Clear();
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
