using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobMatch.Database;
using System.Data.SqlClient;

namespace JobMatch
{
    public partial class MyJobsForm : Form
    {
        private int _myId;

        public MyJobsForm(int Id)
        {
            _myId = Id;
            InitializeComponent();
        }

        private void MyJobsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += DataGridView_ButtonClick;
            RefreshData();
        }
        private void RefreshData()
        {
            jobTableAdapter.FillBy(findJobDBDataSet.Job, _myId);
            dataGridView1.CellClick += DataGridView_ButtonClick;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[2].Value = "Delete";
            }
        }

        private void DataGridView_ButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["delete_btn_column"].Index)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[3].Value);
                JobController jobController = new JobController();
                jobController.Delete(id);
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
            JobRegistration jbreg = new JobRegistration(_myId);
            jbreg.ShowDialog(this);
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
