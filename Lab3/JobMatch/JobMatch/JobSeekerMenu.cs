﻿using System;
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
        public JobSeekerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SelectorForm slform = new SelectorForm();
            slform.ShowDialog(this);
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
