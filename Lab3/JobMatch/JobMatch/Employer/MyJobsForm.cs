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
    public partial class MyJobsForm : Form
    {
        public MyJobsForm()
        {
            InitializeComponent();
        }

        private void MyJobsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += DataGridView_ButtonClick;                                                                         //Load Existing Jobs from DB implement row insertion
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[0].Value = "Software engineer";                                 //DATA FROM DATABASE
                r.Cells[1].Value = "Edit";
                r.Cells[2].Value = "Delete";
            }
        }

        private void DataGridView_ButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["edit_btn_column"].Index)  //Still need to check which row
            {
                Console.WriteLine("edit clicked");
            }
            if(e.ColumnIndex == dataGridView1.Columns["delete_btn_column"].Index)
            {
                Console.WriteLine("delete clicked");
            }
        }

        private void add_job_btn_Click(object sender, EventArgs e)                      //Pass row.Cells[0].Value through EventArgs
        {
            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //row.Cells[0].Value = "IT dev";                                              //DATA FROM DATABASE
            //row.Cells[1].Value = "Edit";
            //row.Cells[2].Value = "Delete";
            //dataGridView1.Rows.Add(row);

            Hide();
            JobRegistration jbreg = new JobRegistration();
            jbreg.ShowDialog(this);
            Show();
        }
    }
}
