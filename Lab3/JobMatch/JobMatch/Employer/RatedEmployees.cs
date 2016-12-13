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
    public partial class RatedEmployees : Form
    {
        Image _yesImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\yes_img.png");
        Image _noImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\no_img.png");
        Image _maybeImg = Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\maybe_img.png");
        private int _myId;

        public RatedEmployees(int Id)
        {
            _myId = Id;
            _yesImg = resizeImage(_yesImg, new Size(15, 15));
            _noImg = resizeImage(_noImg, new Size(15, 15));
            _maybeImg = resizeImage(_maybeImg, new Size(15, 15));
            InitializeComponent();
        }

        private void RatedEmployees_Load(object sender, EventArgs e)
        {
            JobController jobController = new JobController();
            var jobs = jobController.GetJobs().Where(x => x.Employer_Id == _myId).ToList();

            ProfileController profileController = new ProfileController();

            EmployerController empController = new EmployerController();
            var rates = empController.Select(_myId).EmployerRates;

            var result = from job in jobs
                         join rate in rates on new { cont1 = job.Employer_Id, cont2 = job.Id } equals new { cont1 = rate.Employer_Id, cont2 = rate.Job_Id }
                         select new RatedEmployeesData
                         {
                             Position = job.Position,
                             YourRate = new RatedEmployeesData().GetImage(rate.Rate),
                             JobSeekersRate = new RatedEmployeesData().SetCompanysRate(job.Id, rate.JobSeeker_Id),
                             JobSeekersName = profileController.Select(rate.JobSeeker_Id).FirstName
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
    }
}
