using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobMatch.Database;

namespace JobMatch
{
    class RatedJobsData
    {
        Image _yesImg = resizeImage(Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\yes_img.png"), new Size(15, 15));
        Image _noImg = resizeImage(Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\no_img.png"), new Size(15, 15));
        Image _maybeImg = resizeImage(Image.FromFile(@"C:\Users\Acer\cslab3\Lab3\imgs\maybe_img.png"), new Size(15, 15));

        public string CompanyName
        {
            get;
            set;
        }
        public string JobPosition
        {
            get;
            set;
        }
        public Image YourRate
        {
            get;
            set;
        }
        public Image CompanysRate
        {
            get;
            set;
        }
        

        public Image GetImage(bool value)
        {

            if(value == true)
            {
                return _yesImg;
            }
            if (value == false)
            {
                return _noImg;
            }
            return _maybeImg;
        }

        public Image SetCompanysRate(int job_id, int jobSeeker_id)
        {
            EmployerRatesController empRatesController = new EmployerRatesController();
            var empRates = empRatesController.GetRates();


            bool value;
            if(empRatesController.ExistsRateByJob(job_id, jobSeeker_id))
            {
                value = empRates.SingleOrDefault(x => x.Job_Id == job_id && x.JobSeeker_Id == jobSeeker_id).Rate;
                if (value == true)
                {
                    return _yesImg;
                }
                if (value == false)
                {
                    return _noImg;
                }
            }

            return _maybeImg;
              
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
    }
}
