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
    public partial class EmployerMenu : Form
    {
        private int _myId;

        public EmployerMenu(int Id)
        {
            _myId = Id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SelectorForm slform = new SelectorForm(Type.Employer, _myId);
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
            MyJobsForm myjobsForm = new MyJobsForm(_myId);
            myjobsForm.ShowDialog(this);
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RatedEmployees ratedEmployees = new RatedEmployees();
            ratedEmployees.ShowDialog(this);
            Show();
        }
    }
}
