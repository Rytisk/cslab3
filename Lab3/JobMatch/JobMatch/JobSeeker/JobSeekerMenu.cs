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
    public partial class JobSeekerMenu : Form
    {
        private int _myId;
        public JobSeekerMenu(int Id)
        {
            _myId = Id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SelectorForm slform = new SelectorForm(Type.JobSeeker);
            slform.ShowDialog(this);
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterJobSeeker JBReg = new RegisterJobSeeker(_myId);
            JBReg.ShowDialog(this);
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RatedJobs ratedJobsForm = new RatedJobs();
            ratedJobsForm.ShowDialog(this);
            Show();
        }
    }
}
