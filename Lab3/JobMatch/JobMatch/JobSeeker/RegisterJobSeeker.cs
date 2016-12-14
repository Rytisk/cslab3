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
    public partial class RegisterJobSeeker : Form
    {
        ProfileController profileController = new ProfileController();
        private int _myId;

        public RegisterJobSeeker(int Id)
        {
            _myId = Id;
            InitializeComponent();
        }

        private void update_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile()
            {
                JobSeeker_Id = _myId,
                ContactData = contact_data_box.Text,
                Education = education_box.Text,
                FirstName = first_name_box.Text,
                LastName = last_name_box.Text,
                ShortDescription = short_description_data.Text,
                WorkExperience = work_experience_box.Text
            };

            if (profileController.Select(_myId) != null)
                profileController.Update(profile);
            else if (profileController.Select(_myId) == null)
                profileController.Insert(profile);


            SkillController skillController = new SkillController();
            var checkedskills = skills_checklist.CheckedItems;
            var skills = skills_checklist.Items;
            foreach(var skl in skills)
            {
                skillController.Delete(profile.JobSeeker_Id, skl.ToString());
            }
            foreach(var skill in checkedskills)
            {
                Skill skl = new Skill()
                {
                    Profile_Id = profile.JobSeeker_Id,
                    Skill1 = skill.ToString()
                };
                skillController.Insert(skl);
            }

            Dispose();
        }

        private void RegisterJobSeeker_Load(object sender, EventArgs e)
        {
            Profile profile = profileController.Select(_myId);
            if(profile != null)
            {
                contact_data_box.Text = profile.ContactData;
                education_box.Text = profile.Education;
                first_name_box.Text = profile.FirstName;
                last_name_box.Text = profile.LastName;
                short_description_data.Text = profile.ShortDescription;
                work_experience_box.Text = profile.WorkExperience;

                var skills = profile.Skill.ToList();
                if(skills != null)
                {
                    foreach (var skill in skills)
                    {
                        int index = skills_checklist.Items.IndexOf(skill.Skill1);
                        skills_checklist.SetItemChecked(index, true);
                    }
                }
                                
            }
        }
    }
}
