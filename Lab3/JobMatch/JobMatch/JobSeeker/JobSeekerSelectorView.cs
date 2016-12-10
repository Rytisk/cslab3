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
                return company_name_box.Text;
            }
            set
            {
                company_name_box.Text = value;
            }
        }

        public string JobPosition
        {
            get
            {
                return job_position_box.Text;
            }
            set
            {
                job_position_box.Text = value;
            }
        }

        public string ShortJobDescription
        {
            get
            {
                return short_description_box.Text;
            }
            set
            {
                short_description_box.Text = value;
            }
        }

        public ListView RequiredSkills
        {
            get
            {
                return required_skills_listview;
            }
            set
            {
                required_skills_listview = value;
            }
        }

        public string Education
        {
            get
            {
                return education_box.Text;
            }
            set
            {
                education_box.Text = value;
            }
        }

        public string AditionalRequirements
        {
            get
            {
                return aditional_requirements_box.Text;
            }
            set
            {
                aditional_requirements_box.Text = value;
            }

        }

        public JobSeekerSelectorView()
        {
            InitializeComponent();
        }
    }
}
