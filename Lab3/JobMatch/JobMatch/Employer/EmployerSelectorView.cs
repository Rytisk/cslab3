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
    public partial class EmployerSelectorView : UserControl
    {
        public string JobSeekerName
        {
            get
            {
                return name_box.Text;
            }
            set
            {
                name_box.Text = value;
            }
        }

        public string ContactData
        {
            get
            {
                return contact_data_box.Text;
            }
            set
            {
                contact_data_box.Text = value;
            }
        }

        public string ShortDescription
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

        public ListView Skills
        {
            get
            {
                return skills_viewlist;
            }
            set
            {
                skills_viewlist = value;
            }
        }

        public string WorkExperience
        {
            get
            {
                return work_experience_box.Text;
            }
            set
            {
                work_experience_box.Text = value;
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

        public EmployerSelectorView()
        {
            InitializeComponent();
        }
    }
}
