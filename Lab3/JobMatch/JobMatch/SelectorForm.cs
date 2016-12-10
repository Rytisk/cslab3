using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobMatch
{
    public partial class SelectorForm : Form
    {
        JobSeekerSelector _jobSeekerControl;
        EmployerSelector _employerControl;
        private int employerIndex;
        //  List<EmployerDataSelector> employers;
        Type _userType;
        DBHandler db;

        public SelectorForm(Type userType)
        {
            _userType = userType;
           
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {

            if(_userType == Type.JobSeeker)
            {
                _jobSeekerControl = new JobSeekerSelector();
                panel1.Controls.Add(_jobSeekerControl);
            }
            else if(_userType == Type.Employer)
            {
                _employerControl = new EmployerSelector();
                panel1.Controls.Add(_employerControl);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
      /*     if(employers.Count > employerIndex)
           {
                //BAD CODE
                //emp = employers.ElementAt(employerIndex++);
                //myControl.NameOfCompany = emp.CompanyName;
                //myControl.Education = emp.Education;
                //myControl.JobPosition = emp.Position;
                //myControl.ShortJobDescription = emp.ShortJobDescription;
                //myControl.AditionalRequirements = emp.AdditionalRequirements;

                //var reqSkills = db.GetRequiredSkills(emp.Id);

                //foreach (RequiredSkill skill in reqSkills)
                //{
                //    ListViewItem listItems = new ListViewItem(skill.Skill.ToString());
                //    listItems.SubItems.Add(skill.Experience.ToString());
                //    myControl.RequiredSkills.Items.Add(listItems);
                //}
                
               
            }
            else
            {
                MessageBox.Show("No more jobs!");
            }   */
        }

    }
}
