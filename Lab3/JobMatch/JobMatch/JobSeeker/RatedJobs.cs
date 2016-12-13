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

namespace JobMatch
{
    public partial class RatedJobs : Form
    {

        private int _myId;

        public RatedJobs(int Id)
        {
            _myId = Id;

            InitializeComponent();
        }

        private void RatedJobs_Load(object sender, EventArgs e)
        {
            JobController jobController = new JobController();
            var jobs = jobController.GetJobs();

            JobSeekerController jobSeekerController = new JobSeekerController();
            var seekerRates = jobSeekerController.Select(_myId);



            var result = from job in jobs
                         join rate in seekerRates.JobSeekerRates on job.Id equals rate.Job_Id
                         select new RatedJobsData
                         {
                             JobPosition = job.Position,
                             CompanyName = job.Name,
                             YourRate = new RatedJobsData().GetImage(rate.Rate),
                             CompanysRate =  new RatedJobsData().SetCompanysRate(job.Id, rate.JobSeeker_Id)
                            
                         };

            dataGridView1.DataSource = result.ToList();

            /*
            


            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[0].Value = "Software engineer";                                 //
                r.Cells[1].Value = "Google";                                            //DATA FROM DATABASE
                r.Cells[2].Value = _yesImg;                                             //
                r.Cells[3].Value = _maybeImg;                                           //
            }*/
        }



    }
}
