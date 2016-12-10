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
        JobSeekerSelector myControl;
        private int employerIndex;
<<<<<<< HEAD
        List<EmployerDataSelector> employers;
        DBHandler db;
        Type _userType;
=======
        List<DataForSelector> employers;
        DBHandler db;
>>>>>>> e1abfe853d1c44d4645dcf8fc50584882ee4591f

        public SelectorForm(Type userType)
        {
<<<<<<< HEAD
            _userType = userType;
            if(userType == Type.JobSeeker)
            {
                myControl = new JobSeekerSelector();
                panel1.Controls.Add(myControl);
            }
            else if(userType == Type.Employer)
            {
                myControl = new EmployerSelector();
                panel1.Controls.Add(myControl);
            }
           // db = new DBHandler();
         //   employers = db.GetEmployer();
=======
            db = new DBHandler();
            employers = db.GetEmployer();
>>>>>>> e1abfe853d1c44d4645dcf8fc50584882ee4591f
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployerDataSelector emp;
            if(employers.Count > employerIndex)
            {
<<<<<<< HEAD
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



=======
                emp = employers.ElementAt(employerIndex++);
                myControl.NameOfCompany = emp.CompanyName;
                myControl.Education = emp.Education;
                myControl.JobPosition = emp.Position;
                myControl.ShortJobDescription = emp.ShortJobDescription;
                myControl.AditionalRequirements = emp.AdditionalRequirements;

                var reqSkills = db.GetRequiredSkills(emp.RequiredSkillId);

                foreach(RequiredSkill skill in reqSkills)
                {
                    ListViewItem listItems = new ListViewItem(skill.Skill.ToString());
                    listItems.SubItems.Add(skill.Experience.ToString());
                    myControl.RequiredSkills.Items.Add(listItems);
                }
                
                
                
>>>>>>> e1abfe853d1c44d4645dcf8fc50584882ee4591f
            }
            else
            {
                MessageBox.Show("No more jobs!");
            }   
        }

    }
}
