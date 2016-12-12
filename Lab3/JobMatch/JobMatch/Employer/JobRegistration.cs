using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobMatch.Database;

namespace JobMatch
{
    public partial class JobRegistration : Form
    {
        private int _myId;
        JobController jobController = new JobController();

        public JobRegistration(int Id)
        {
            _myId = Id;
            InitializeComponent();
        }

        private void UpdateJob(Job job)
        {
            jobController.Update(job);
            InsertSkill(job);
            Dispose();
        }
        private void InsertJob(Job job)
        {
            jobController.Insert(job);
            InsertSkill(job);
            Dispose();
        }

        private void InsertSkill(Job job)
        {
            RequiredSkillController requiredSkillController = new RequiredSkillController();
            var checkedskills = skills_checklist.CheckedItems;
            var skills = skills_checklist.Items;
            foreach (var skl in skills)
            {
                requiredSkillController.Delete(job.Id, skl.ToString());
            }
            foreach (var skill in checkedskills)
            {
                RequiredSkill skl = new RequiredSkill()
                {
                    Job_Id = job.Id,
                    Skill = skill.ToString()
                };
                requiredSkillController.Insert(skl);
            }
        }

        private void upload_job_btn_Click(object sender, EventArgs e)
        {
            Job job = new Job()
            {
                Name = company_name_box.Text,
                Employer_Id = _myId,
                Position = job_position_box.Text,
                JobDescription = short_description_box.Text,
                EducationRequirements = education_box.Text,
                AditionalRequirements = aditional_requirements_box.Text
            };

            if (jobController.Select(job.Id) != null)
                UpdateJob(job);
            else if (jobController.Select(job.Id) == null)
                InsertJob(job);
        }
    }
}
