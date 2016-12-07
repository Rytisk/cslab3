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
        List<Employer> employers;

        public SelectorForm()
        {
            DBHandler db = new DBHandler();
            employers = db.GetEmployers();
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            myControl = new JobSeekerSelector();
            panel1.Controls.Add(myControl);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employer emp;
            if(employers.Count > employerIndex)
            {
                emp = employers.ElementAt(employerIndex++);
                myControl.NameOfCompany = emp.Name;
            }
            else
            {
                MessageBox.Show("No more jobs!");
            }   
        }

    }
}
