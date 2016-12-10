using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobMatch
{
    public partial class JobSeekerSelectorView : UserControl
    {
        public string NameOfCompany
        {
            get
            {
                return company_name.Text;
            }
            set
            {
                company_name.Text = value;
            }
        }

        public string JobPosition
        {
            get
            {
                return job_position.Text;
            }
            set
            {
                job_position.Text = value;
            }
        }

        public string ShortJobDescription
        {
            get
            {
                return short_description.Text;
            }
            set
            {
                short_description.Text = value;
            }
        }

        public ListView RequiredSkills
        {
            get
            {
                return required_skills;
            }
            set
            {
                required_skills = value;
            }
        }

        public string Education
        {
            get
            {
                return education_place.Text;
            }
            set
            {
                education_place.Text = value;
            }
        }

        public string AditionalRequirements
        {
            get
            {
                return aditional_requirements.Text;
            }
            set
            {
                aditional_requirements.Text = value;
            }

        }

        public JobSeekerSelectorView()
        {
            InitializeComponent();
        }
    }
}
