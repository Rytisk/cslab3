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
            EmployerController empController = new EmployerController();

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

            var companiesOffers = from job in jobs
                                  group job by job.Employer_Id into g
                                  select new
                                  {
                                      Name = jobs.First(x => x.Employer_Id == g.Key).Name,
                                      Count = g.Count()
                                  };
            dataGridView2.DataSource = companiesOffers.ToList();

        }



    }
}
