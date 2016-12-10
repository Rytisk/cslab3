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
        List<DataForSelector> employers;
        DBHandler db;

        public SelectorForm()
        {
            db = new DBHandler();
            employers = db.GetEmployer();
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            myControl = new JobSeekerSelector();
            panel1.Controls.Add(myControl);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataForSelector emp;
            if(employers.Count > employerIndex)
            {
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
                
                
                
            }
            else
            {
                MessageBox.Show("No more jobs!");
            }   
        }

    }
}
