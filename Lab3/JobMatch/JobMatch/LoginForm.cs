using System;
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
    public enum Type
    {
        JobSeeker,
        Employer
    }
    public partial class Form1 : Form
    {
        Type type;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                type = Type.JobSeeker;
            }
            else if (radioButton2.Checked)
            {
                type = Type.Employer;
            }
            else
            {
                MessageBox.Show("Please choose a type of login");
            }

            
            
        }
    }
}
