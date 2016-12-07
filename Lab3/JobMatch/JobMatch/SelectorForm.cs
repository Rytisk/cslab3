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
    public partial class SelectorForm : Form
    {
        public SelectorForm()
        {
            InitializeComponent();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            var myControl = new JobSeekerSelector();
            panel1.Controls.Add(myControl);
        }
    }
}
